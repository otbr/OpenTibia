﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;

namespace OpenTibia.Game.Commands
{
    public class MoveItemFromTileToInventoryCommand : MoveItemCommand
    {
        public MoveItemFromTileToInventoryCommand(Player player, Position fromPosition, byte fromIndex, ushort itemId, byte toSlot, byte count) : base(player)
        {
            FromPosition = fromPosition;

            FromIndex = fromIndex;

            ItemId = itemId;

            ToSlot = toSlot;

            Count = count;
        }

        public Position FromPosition { get; set; }

        public byte FromIndex { get; set; }

        public ushort ItemId { get; set; }

        public byte ToSlot { get; set; }

        public byte Count { get; set; }
        
        public override void Execute(Context context)
        {
            Tile fromTile = context.Server.Map.GetTile(FromPosition);

            if (fromTile != null)
            {
                Item fromItem = fromTile.GetContent(FromIndex) as Item;

                if (fromItem != null && fromItem.Metadata.TibiaId == ItemId)
                {
                    Inventory toInventory = Player.Inventory;

                    if (IsMoveable(context, fromItem, Count) && IsPickupable(context, fromItem) )
                    {
                        MoveItem(context, fromItem, toInventory, ToSlot, Count);
                    }
                }
            }
        }
    }
}