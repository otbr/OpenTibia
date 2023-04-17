﻿using OpenTibia.Common.Objects;

namespace OpenTibia.Game.Commands
{
    public class PlayerMoveCreatureCommand : Command
    {
        public PlayerMoveCreatureCommand(Player player, Creature item, Tile toTile)
        {
            Player = player;

            Creature = item;

            ToTile = toTile;
        }

        public Player Player { get; set; }

        public Creature Creature { get; set; }

        public Tile ToTile { get; set; }

        public override Promise Execute()
        {
            return Context.AddCommand(new CreatureUpdateTileCommand(Creature, ToTile) );
        }
    }
}