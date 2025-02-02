﻿using OpenTibia.Common.Objects;

namespace OpenTibia.Game.Events
{
    public class PlayerUpdateManaEventArgs : GameEventArgs
    {
        public PlayerUpdateManaEventArgs(Player player, ushort mana)
        {
            Player = player;

            Mana = mana;
        }

        public Player Player { get; }

        public ushort Mana { get; }
    }
}