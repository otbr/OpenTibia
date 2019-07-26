﻿using OpenTibia.Common.Objects;
using OpenTibia.Game.Commands;

namespace OpenTibia.Game.Scripts.Speech
{
    public class TeleportDownScript : SpeechScript
    {
        public override void Register(Server server)
        {
            server.SpeechScripts.Add("/down", this);
        }

        public override bool Execute(Player player, string parameters, Server server, CommandContext context)
        {
            TeleportCommand command = new TeleportCommand(player, player.Tile.Position.Offset(0, 0, 1) );

            command.Execute(server, context);

            return true;
        }
    }
}