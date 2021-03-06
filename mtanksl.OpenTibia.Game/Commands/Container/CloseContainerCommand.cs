﻿using OpenTibia.Common.Objects;
using OpenTibia.Network.Packets.Outgoing;

namespace OpenTibia.Game.Commands
{
    public class CloseContainerCommand : Command
    {
        public CloseContainerCommand(Player player, byte containerId)
        {
            Player = player;

            ContainerId = containerId;
        }

        public Player Player { get; set; }

        public byte ContainerId { get; set; }

        public override void Execute(Server server, Context context)
        {
            //Arrange

            Container container = Player.Client.ContainerCollection.GetContainer(ContainerId);

            if (container != null)
            {
                //Act

                Player.Client.ContainerCollection.CloseContainer(ContainerId);

                //Notify

                context.Write(Player.Client.Connection, new CloseContainerOutgoingPacket(ContainerId) );

                base.Execute(server, context);
            }
        }
    }
}