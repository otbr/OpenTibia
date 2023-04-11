﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;

namespace OpenTibia.Game.Commands
{
    public class ParseMoveItemFromTileToTileCommand : ParseMoveItemCommand
    {
        public ParseMoveItemFromTileToTileCommand(Player player, Position fromPosition, byte fromIndex, ushort itemId, Position toPosition, byte count) : base(player)
        {
            FromPosition = fromPosition;

            FromIndex = fromIndex;

            ItemId = itemId;

            ToPosition = toPosition;

            Count = count;
        }

        public Position FromPosition { get; set; }

        public byte FromIndex { get; set; }

        public ushort ItemId { get; set; }

        public Position ToPosition { get; set; }

        public byte Count { get; set; }

        public override Promise Execute()
        {
            return Promise.Run( (resolve, reject) =>
            {
                Tile fromTile = Context.Server.Map.GetTile(FromPosition);

                if (fromTile != null)
                {
                    if (Player.Tile.Position.CanSee(fromTile.Position) )
                    {
                        switch (fromTile.GetContent(FromIndex) )
                        {
                            case Item fromItem:

                                if (fromItem.Metadata.TibiaId == ItemId)
                                {
                                    Tile toTile = Context.Server.Map.GetTile(ToPosition);

                                    if (toTile != null)
                                    {
                                        if (IsMoveable(Context, fromItem, Count) )
                                        {
                                            Context.AddCommand(new PlayerMoveItemCommand(Player, fromItem, toTile, 0, Count, true) ).Then( () =>
                                            {
                                                resolve();
                                            } );
                                        }
                                    }
                                }

                                break;

                            case Creature fromCreature:

                                if (ItemId == 99)
                                {
                                    Tile toTile = Context.Server.Map.GetTile(ToPosition);

                                    if (toTile != null)
                                    {
                                        if (IsMoveable(Context, fromCreature) )
                                        {
                                            Context.AddCommand(new PlayerMoveCreatureCommand(Player, fromCreature, toTile) ).Then( () =>
                                            {
                                                resolve();
                                            } );
                                        }
                                    }
                                }

                                break;
                        }
                    }
                }
            } );
        }
    }
}