﻿using OpenTibia.Common.Objects;
using OpenTibia.Network.Packets.Outgoing;

namespace OpenTibia.Game.Commands
{
    public class TileRemoveItemCommand : Command
    {
        public TileRemoveItemCommand(Tile tile, byte index)
        {
            Tile = tile;

            Index = index;
        }

        public Tile Tile { get; set; }

        public byte Index { get; set; }

        public override void Execute(Server server, CommandContext context)
        {
            //Arrange

            Item item = Tile.GetContent(Index) as Item;

            //Act

            Tile.RemoveContent(Index);

            //Notify

            foreach (var observer in server.Map.GetPlayers() )
            {
                if (observer.Tile.Position.CanSee(Tile.Position) )
                {
                    context.Write(observer.Client.Connection, new ThingRemoveOutgoingPacket(Tile.Position, Index) );
                }
            }

            foreach (var script in server.Scripts.TileRemoveItemScripts)
            {
                script.OnTileRemoveItem(item, Tile, Index, server, context);
            }

            base.Execute(server, context);
        }
    }
}