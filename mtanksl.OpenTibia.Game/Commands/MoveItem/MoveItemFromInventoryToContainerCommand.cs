﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Network.Packets.Outgoing;

namespace OpenTibia.Game.Commands
{
    public class MoveItemFromInventoryToContainerCommand : MoveItemCommand
    {
        public MoveItemFromInventoryToContainerCommand(Player player, byte fromSlot, ushort itemId, byte toContainerId, byte toContainerIndex, byte count)
        {
            Player = player;

            FromSlot = fromSlot;

            ItemId = itemId;

            ToContainerId = toContainerId;

            ToContainerIndex = toContainerIndex;

            Count = count;
        }

        public Player Player { get; set; }

        public byte FromSlot { get; set; }

        public ushort ItemId { get; set; }

        public byte ToContainerId { get; set; }

        public byte ToContainerIndex { get; set; }

        public byte Count { get; set; }

        public override void Execute(Server server, CommandContext context)
        {
            //Arrange

            Inventory fromInventory = Player.Inventory;

            Item fromItem = fromInventory.GetContent(FromSlot) as Item;

            if (fromItem != null && fromItem.Metadata.TibiaId == ItemId)
            {
                Container toContainer = Player.Client.ContainerCollection.GetContainer(ToContainerId);

                if (toContainer != null)
                {
                    if ( toContainer.IsChildOfParent(fromItem) )
                    {
                        context.Write(Player.Client.Connection, new ShowWindowTextOutgoingPacket(TextColor.WhiteBottomGameWindow, Constants.ThisIsImpossible) );
                    }
                    else
                    {
                        //Act

                        RemoveItem(fromInventory, FromSlot, server, context);

                        AddItem(toContainer, fromItem, server, context);

                        Container container = fromItem as Container;

                        if (container != null)
                        {
                            switch (toContainer.GetParent() )
                            {
                                case Tile toTile:

                                    CloseContainer(fromInventory, toTile, container, server, context);

                                    break;

                                case Inventory toInventory:

                                    CloseContainer(fromInventory, toInventory, container, server, context);
                                            
                                    break;
                            }

                            ShowOrHideOpenParentContainer(container, server, context);
                        }

                        base.Execute(server, context);
                    }          
                }
            }
        }
    }
}