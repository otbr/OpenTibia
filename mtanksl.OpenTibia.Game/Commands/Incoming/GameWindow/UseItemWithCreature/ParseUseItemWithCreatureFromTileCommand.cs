﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;

namespace OpenTibia.Game.Commands
{
    public class ParseUseItemWithCreatureFromTileCommand : ParseUseItemWithCreatureCommand
    {
        public ParseUseItemWithCreatureFromTileCommand(Player player, Position fromPosition, byte fromIndex, ushort itemId, uint toCreatureId) : base(player)
        {
            Player = player;

            FromPosition = fromPosition;

            FromIndex = fromIndex;

            ItemId = itemId;

            ToCreatureId = toCreatureId;
        }

        public Position FromPosition { get; set; }

        public byte FromIndex { get; set; }

        public ushort ItemId { get; set; }

        public uint ToCreatureId { get; set; }

        public override Promise Execute()
        {
            return Promise.Run( (resolve, reject) =>
            {
                Tile fromTile = Context.Server.Map.GetTile(FromPosition);

                if (fromTile != null)
                {
                    if (Player.Tile.Position.CanSee(fromTile.Position) )
                    {
                        Item fromItem = fromTile.GetContent(FromIndex) as Item;

                        if (fromItem != null && fromItem.Metadata.TibiaId == ItemId)
                        {
                            Creature toCreature = Context.Server.GameObjects.GetCreature(ToCreatureId);

                            if (toCreature != null)
                            {
                                if ( IsUseable(Context, fromItem) )
                                {
                                    Context.AddCommand(new PlayerUseItemWithCreatureCommand(Player, fromItem, toCreature) ).Then( () =>
                                    {
                                        resolve();
                                    } );
                                }
                            }
                        }
                    }
                }
            } );
        }
    }
}