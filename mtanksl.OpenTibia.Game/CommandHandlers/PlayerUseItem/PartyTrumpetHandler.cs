﻿using OpenTibia.Common.Structures;
using OpenTibia.Game.Commands;
using System;
using System.Collections.Generic;

namespace OpenTibia.Game.CommandHandlers
{
    public class PartyTrumpetHandler : CommandHandler<PlayerUseItemCommand>
    {
        private static Dictionary<ushort, ushort> partyTrumpets = new Dictionary<ushort, ushort>() 
        {
            { 6572, 6573 }
        };

        private static Dictionary<ushort, ushort> decay = new Dictionary<ushort, ushort>() 
        {
            { 6573, 6572 }
        };

        public override Promise Handle(Func<Promise> next, PlayerUseItemCommand command)
        {
            ushort toOpenTibiaId;

            if (partyTrumpets.TryGetValue(command.Item.Metadata.OpenTibiaId, out toOpenTibiaId) )
            {
                return Context.AddCommand(new PlayerAchievementCommand(command.Player, AchievementConstants.PartyAnimal, 200, "Party Animal") ).Then( () =>
                {
                    return Context.AddCommand(new ShowMagicEffectCommand(command.Item, MagicEffectType.GreenNotes) );

                } ).Then( () =>
                {
                    return Context.AddCommand(new ShowTextCommand(command.Player, TalkType.MonsterSay, "TOOOOOOT!") );

                } ).Then( () =>
                {
                    return Context.AddCommand(new ItemTransformCommand(command.Item, toOpenTibiaId, 1) );

                } ).Then( (item) =>
                {
                    _ = Context.AddCommand(new ItemDecayTransformCommand(item, TimeSpan.FromSeconds(2), decay[item.Metadata.OpenTibiaId], 1) );

                    return Promise.Completed;
                } );
            }

            return next();
        }
    }
}