﻿using OpenTibia.Common.Objects;
using OpenTibia.Game.Commands;
using OpenTibia.Game.Common;
using OpenTibia.Game.Plugins;

namespace OpenTibia.Plugins.Weapons
{
    public class WandOfCosmicEnergyWeaponPlugin : WeaponPlugin
    {
        public WandOfCosmicEnergyWeaponPlugin(Weapon weapon) : base(weapon)
        {

        }

        public override Promise OnUseWeapon(Player player, Creature target, Item weapon)
        {
           var formula = Formula.WandFormula(45, 8);

            return Context.AddCommand(new CreatureAttackCreatureCommand(player, target,

                new DistanceAttack(weapon.Metadata.ProjectileType.Value, formula.Min, formula.Max) ) );
        }
    }
}