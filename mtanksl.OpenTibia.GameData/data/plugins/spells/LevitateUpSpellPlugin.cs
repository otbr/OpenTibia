﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Commands;
using OpenTibia.Game.Components;
using OpenTibia.Game.Plugins;
using System.Linq;

namespace OpenTibia.GameData.Plugins.Spells
{
    public class LevitateUpSpellPlugin : SpellPlugin
    {
        public LevitateUpSpellPlugin(Spell spell) : base(spell)
        {

        }

        public override PromiseResult<bool> OnCasting(Player player, Creature target, string message)
        {
            Tile up = Context.Server.Map.GetTile(player.Tile.Position.Offset(0, 0, -1) );

            Tile toTile = Context.Server.Map.GetTile(player.Tile.Position.Offset(0, 0, -1).Offset(player.Direction) );

            if (up != null || toTile == null || toTile.Ground == null || toTile.GetItems().Any(i => i.Metadata.Flags.Is(ItemMetadataFlags.NotWalkable) ) )
            {
                return Promise.FromResultAsBooleanFalse;
            }

            return Promise.FromResultAsBooleanTrue;
        }

        public override Promise OnCast(Player player, Creature target, string message)
        {
            Tile toTile = Context.Server.Map.GetTile(player.Tile.Position.Offset(0, 0, -1).Offset(player.Direction) );

            return Context.AddCommand(new ShowMagicEffectCommand(player, MagicEffectType.Teleport) ).Then( () =>
            {
                return Context.AddCommand(new CreatureMoveCommand(player, toTile) );

            } ).Then( () =>
            {
                return Context.AddCommand(new ShowMagicEffectCommand(toTile.Position, MagicEffectType.Teleport) );
            } );
        }
    }
}