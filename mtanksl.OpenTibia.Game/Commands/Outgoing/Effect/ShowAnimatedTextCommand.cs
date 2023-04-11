﻿using OpenTibia.Common.Structures;
using OpenTibia.Network.Packets.Outgoing;

namespace OpenTibia.Game.Commands
{
    public class ShowAnimatedTextCommand : Command
    {
        public ShowAnimatedTextCommand(Position position, AnimatedTextColor animatedTextColor, string message)
        {
            Position = position;

            AnimatedTextColor = animatedTextColor;

            Message = message;
        }

        public Position Position { get; set; }

        public AnimatedTextColor AnimatedTextColor { get; set; }

        public string Message { get; set; }

        public override Promise Execute()
        {
            foreach (var observer in Context.Server.GameObjects.GetPlayers() )
            {
                if (observer.Tile.Position.CanSee(Position) )
                {
                    Context.AddPacket(observer.Client.Connection, new ShowAnimatedTextOutgoingPacket(Position, AnimatedTextColor, Message) );
                }
            }

            return Promise.Completed;
        }
    }
}