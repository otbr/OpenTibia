﻿using OpenTibia.Common.Objects;
using OpenTibia.Game.Commands;
using System;
using System.Collections.Generic;

namespace OpenTibia.Game.CommandHandlers
{
    public class ScytheHandler : CommandHandler<PlayerUseItemWithItemCommand>
    {
        private HashSet<ushort> scythes = new HashSet<ushort>() { 2550 };

        private Dictionary<ushort, ushort> wheats = new Dictionary<ushort, ushort>()
        {
            { 2739, 2737 }
        };

        private Dictionary<ushort, ushort> decay = new Dictionary<ushort, ushort>()
        {
            { 2737, 2738 },
            { 2738, 2739 }
        };

        private ushort wheat = 2694;

        public override Promise Handle(Func<Promise> next, PlayerUseItemWithItemCommand command)
        {
            ushort toOpenTibiaId;

            if (scythes.Contains(command.Item.Metadata.OpenTibiaId) && wheats.TryGetValue(command.ToItem.Metadata.OpenTibiaId, out toOpenTibiaId) )
            {
                return Context.AddCommand(new TileIncrementOrCreateItemCommand( (Tile)command.ToItem.Parent, wheat, 1) ).Then( () =>
                {
                    return Context.AddCommand(new ItemTransformCommand(command.ToItem, toOpenTibiaId, 1) );

                } ).Then( (item) =>
                {
                    return Context.AddCommand(new ItemDecayTransformCommand(item, 10000, decay[item.Metadata.OpenTibiaId], 1) );

                } ).Then( (item) =>
                {
                    return Context.AddCommand(new ItemDecayTransformCommand(item, 10000, decay[item.Metadata.OpenTibiaId], 1) );
                } );
            }

            return next();
        }
    }
}