﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;

namespace OpenTibia.Game.Commands
{
    public class RotateItemFromInventoryCommand : RotateItemCommand
    {
        public RotateItemFromInventoryCommand(Player player, byte fromSlot, ushort itemId) : base(player)
        {
            FromSlot = fromSlot;

            ItemId = itemId;
        }

        public byte FromSlot { get; set; }

        public ushort ItemId { get; set; }

        public override void Execute(Server server, Context context)
        {
            //Arrange

            Inventory fromInventory = Player.Inventory;

            Item fromItem = fromInventory.GetContent(FromSlot) as Item;

            if (fromItem != null && fromItem.Metadata.TibiaId == ItemId)
            {
                //Act

                if ( IsRotatable(fromItem, server, context) )
                {
                    RotateItem(fromItem, server, context);
                }
            }
        }
    }
}