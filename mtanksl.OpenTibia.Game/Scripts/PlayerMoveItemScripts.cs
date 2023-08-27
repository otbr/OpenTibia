﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.CommandHandlers;
using OpenTibia.Game.Commands;
using OpenTibia.Network.Packets.Outgoing;

namespace OpenTibia.Game.Scripts
{
    public class PlayerMoveItemScripts : Script
    {
        public override void Start()
        {
            Context.Server.CommandHandlers.AddCommandHandler(new MoveItemWalkToSourceHandler() );

            Context.Server.CommandHandlers.AddCommandHandler<PlayerMoveItemCommand>( (context, next, command) => 
            {
                if (command.ToContainer is Tile toTile)
                {
                    if (command.Pathfinding && !Context.Server.Pathfinding.CanThrow(command.Player.Tile.Position, toTile.Position) )
                    {
                        Context.AddPacket(command.Player.Client.Connection, new ShowWindowTextOutgoingPacket(TextColor.WhiteBottomGameWindow, Constants.YouCanNotThrowThere) );

                        return Promise.Break;
                    }
                }
                else if (command.ToContainer is Inventory toInventory)
                {
                    if ( !command.Item.Metadata.Flags.Is(ItemMetadataFlags.Pickupable) )
                    {
                        Context.AddPacket(command.Player.Client.Connection, new ShowWindowTextOutgoingPacket(TextColor.WhiteBottomGameWindow, Constants.YouCanNotTakeThisObject) );

                        return Promise.Break;
                    }
                }
                else if (command.ToContainer is Container toContainer)
                {
                    if ( !command.Item.Metadata.Flags.Is(ItemMetadataFlags.Pickupable) )
                    {
                        Context.AddPacket(command.Player.Client.Connection, new ShowWindowTextOutgoingPacket(TextColor.WhiteBottomGameWindow, Constants.YouCanNotTakeThisObject) );

                        return Promise.Break;
                    }

                    if ( toContainer.IsContentOf(command.Item) )
                    {
                        Context.AddPacket(command.Player.Client.Connection, new ShowWindowTextOutgoingPacket(TextColor.WhiteBottomGameWindow, Constants.ThisIsImpossible) );

                        return Promise.Break;
                    }
                }

                return next();
            } );

            Context.Server.CommandHandlers.AddCommandHandler(new DustbinHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new ShallowWaterHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new SwampHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new LavaHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new TarHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new MagicForcefield2Handler() );

            Context.Server.CommandHandlers.AddCommandHandler(new Hole2Handler() );

            Context.Server.CommandHandlers.AddCommandHandler(new Pitfall2Handler() );

            Context.Server.CommandHandlers.AddCommandHandler(new Stairs2Handler() );

            Context.Server.CommandHandlers.AddCommandHandler(new CandlestickMoveHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new TrapMoveHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new SplitStackableItemHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new ThrowAwayContainerCloseHandler() );

            Context.Server.CommandHandlers.AddCommandHandler(new InventoryHandler() );
        }

        public override void Stop()
        {
            
        }
    }
}