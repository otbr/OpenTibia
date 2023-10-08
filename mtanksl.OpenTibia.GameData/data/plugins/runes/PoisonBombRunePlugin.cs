﻿using mtanksl.OpenTibia.Game.Plugins;
using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Commands;
using OpenTibia.Game.Components;
using System;
using System.Linq;

namespace mtanksl.OpenTibia.GameData.Plugins.Runes
{
    public class PoisonBombRunePlugin : RunePlugin
    {
        public PoisonBombRunePlugin(Rune rune) : base(rune)
        {

        }

        public override void Start()
        {
            
        }

        public override PromiseResult<bool> OnUsingRune(Player player, Creature target, Tile tile, Item item)
        {
            if (tile == null || tile.Ground == null || tile.GetItems().Any(i => i.Metadata.Flags.Is(ItemMetadataFlags.NotWalkable) || i.Metadata.Flags.Is(ItemMetadataFlags.BlockPathFinding) ) )
            {
                return Promise.FromResult(false);
            }

            return Promise.FromResult(true);
        }

        public override Promise OnUseRune(Player player, Creature target, Tile tile, Item item)
        {
            Offset[] area = new Offset[]
            {
                new Offset(-1, -1), new Offset(0, -1), new Offset(1, -1),
                new Offset(-1, 0) , new Offset(0, 0) , new Offset(1, 0),
                new Offset(-1, 1) , new Offset(0, 1) , new Offset(1, 1)
            };

            return Context.AddCommand(new CreatureAttackAreaCommand(player, false, tile.Position, area, ProjectileType.Poison, MagicEffectType.GreenRings, 1503, 1,

                new SimpleAttack(null, MagicEffectType.GreenRings, AnimatedTextColor.Green, 5, 5),

                new DamageCondition(SpecialCondition.Poisoned, MagicEffectType.GreenRings, AnimatedTextColor.Green, new[] { 5, 5, 5, 5, 4, 4, 4, 4, 4, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, TimeSpan.FromSeconds(4) ) ) );
        }

        public override void Stop()
        {
            
        }
    }
}
