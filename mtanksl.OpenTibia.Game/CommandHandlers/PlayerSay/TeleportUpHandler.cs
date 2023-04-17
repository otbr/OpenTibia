﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Commands;
using System;

namespace OpenTibia.Game.CommandHandlers
{
    public class TeleportUpHandler : CommandHandler<PlayerSayCommand>
    {
        public override Promise Handle(Func<Promise> next, PlayerSayCommand command)
        {
            if (command.Message.StartsWith("/up") )
            {
                Tile toTile = Context.Server.Map.GetTile(command.Player.Tile.Position.Offset(0, 0, -1) );

                if (toTile != null)
                {
                    return Context.AddCommand(new ShowMagicEffectCommand(toTile.Position, MagicEffectType.Teleport) ).Then( () =>
                    {
                        return Context.AddCommand(new CreatureUpdateTileCommand(command.Player, toTile) );
                    } );
                }

                return Context.AddCommand(new ShowMagicEffectCommand(command.Player.Tile.Position, MagicEffectType.Puff) );
            }

            return next();
        }
    }
}