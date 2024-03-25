﻿using OpenTibia.Common.Objects;
using System;

namespace OpenTibia.Game.Commands
{
    public class ItemTransformCommand : CommandResult<Item>
    {
        public ItemTransformCommand(Item fromItem, ushort openTibiaId, byte count)
        {
            FromItem = fromItem;

            OpenTibiaId = openTibiaId;

            Count = count;
        }

        public Item FromItem { get; set; }

        public ushort OpenTibiaId { get; set; }

        public byte Count { get; set; }

        public override PromiseResult<Item> Execute()
        {
            Item toItem = Context.Server.ItemFactory.Create(OpenTibiaId, Count);

            if (toItem != null)
            {
                Context.Server.ItemFactory.Attach(toItem);

                toItem.ActionId = FromItem.ActionId;

                toItem.UniqueId = FromItem.UniqueId;

                if (FromItem is Container fromContainer && toItem is Container toContainer)
                {
                    while (fromContainer.Count > 0)
                    {
                        IContent content = fromContainer.GetContent(fromContainer.Count - 1);

                        fromContainer.RemoveContent(fromContainer.Count - 1);

                        toContainer.AddContent(content);
                    }
                }
                else if (FromItem is ReadableItem fromReadableItem && toItem is ReadableItem toReadableItem)
                {
                    toReadableItem.Text = fromReadableItem.Text;

                    toReadableItem.Author = fromReadableItem.Author;

                    toReadableItem.Date = fromReadableItem.Date;
                }
                else if (FromItem is SignItem fromSignItem && toItem is SignItem toSignItem)
                {
                    toSignItem.Text = fromSignItem.Text;
                }

                switch (FromItem.Parent)
                {
                    case Tile tile:

                        return Context.AddCommand(new TileReplaceItemCommand(tile, FromItem, toItem) ).Then( () =>
                        {
                            return Context.AddCommand(new ItemDestroyCommand(FromItem) );

                        } ).Then( () =>
                        {
                            return Promise.FromResult(toItem);
                        } );

                    case Inventory inventory:

                        return Context.AddCommand(new InventoryReplaceItemCommand(inventory, FromItem, toItem) ).Then( () =>
                        {
                            return Context.AddCommand(new ItemDestroyCommand(FromItem) );

                        } ).Then( () =>
                        {
                            return Promise.FromResult(toItem);
                        } );

                    case Container container:

                        return Context.AddCommand(new ContainerReplaceItemCommand(container, FromItem, toItem) ).Then( () =>
                        {
                            return Context.AddCommand(new ItemDestroyCommand(FromItem) );

                        } ).Then( () =>
                        {
                            return Promise.FromResult(toItem);
                        } );

                    default:

                        throw new NotImplementedException();
                }
            }

            return Promise.FromResult(toItem);
        }
    }
}