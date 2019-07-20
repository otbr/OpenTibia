﻿using OpenTibia.Common.Objects;

namespace OpenTibia.Game.Commands
{
    public class FollowCommand : Command
    {
        public FollowCommand(Player player, uint creatureId, uint nonce)
        {
            Player = player;

            CreatureId = creatureId;

            Nonce = nonce;
        }

        public Player Player { get; set; }

        public uint CreatureId { get; set; }

        public uint Nonce{ get; set; }

        public override void Execute(Server server, CommandContext context)
        {
            //Arrange

            //Act
            
            //Notify
            
            base.Execute(server, context);
        }
    }
}