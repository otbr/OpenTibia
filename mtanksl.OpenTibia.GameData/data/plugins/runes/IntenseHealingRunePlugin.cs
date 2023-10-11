﻿using mtanksl.OpenTibia.Game.Plugins;
using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Commands;
using OpenTibia.Game.Components;

namespace mtanksl.OpenTibia.GameData.Plugins.Runes
{
    public class IntenseHealingRunePlugin : RunePlugin
    {
        public IntenseHealingRunePlugin(Rune rune) : base(rune)
        {

        }

        public override void Start()
        {
            
        }

        public override PromiseResult<bool> OnUsingRune(Player player, Creature target, Tile tile, Item item)
        {
            return Promise.FromResult(true);
        }

        public override Promise OnUseRune(Player player, Creature target, Tile tile, Item item)
        {
            var formula = GenericFormula(player.Level, player.Skills.MagicLevel, 3.184, 20, 5.59, 35);

            return Context.AddCommand(new CreatureAttackCreatureCommand(player, target,

                new HealingAttack(MagicEffectType.BlueShimmer, formula.Min, formula.Max) ) );
        }

        public override void Stop()
        {
            
        }
    }
}