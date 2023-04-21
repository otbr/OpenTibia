﻿using OpenTibia.Common.Objects;
using OpenTibia.Game.Events;
using OpenTibia.Network.Packets.Outgoing;
using System;

namespace OpenTibia.Game.Commands
{
    public class CreatureUpdateHealthCommand : Command
    {
        public CreatureUpdateHealthCommand(Creature creature, int health) : this(creature, health, creature.MaxHealth)
        {
            
        }

        public CreatureUpdateHealthCommand(Creature creature, int health, int maxHealth)
        {
            Creature = creature;

            Health = (ushort)Math.Max(0, Math.Min(creature.MaxHealth, health) );

            MaxHealth = (ushort)Math.Max(0, Math.Min(creature.MaxHealth, maxHealth) );
        }

        public Creature Creature { get; set; }

        public ushort Health { get; set; }

        public ushort MaxHealth { get; set; }

        public override Promise Execute()
        {
            if (Creature.Health != Health || Creature.MaxHealth != MaxHealth)
            {
                Creature.Health = Health;

                Creature.MaxHealth = MaxHealth;

                Tile fromTile = Creature.Tile;

                foreach (var observer in Context.Server.GameObjects.GetPlayers() )
                {
                    if (observer == Creature)
                    {
                        Context.AddPacket(observer.Client.Connection, new SendStatusOutgoingPacket(observer.Health, observer.MaxHealth, observer.Capacity, observer.Experience, observer.Level, observer.LevelPercent, observer.Mana, observer.MaxMana, observer.Skills.MagicLevel, observer.Skills.MagicLevelPercent, observer.Soul, observer.Stamina) );
                    }
                    
                    if (observer.Tile.Position.CanSee(fromTile.Position) )
                    {
                        Context.AddPacket(observer.Client.Connection, new SetHealthOutgoingPacket(Creature.Id, Creature.HealthPercentage) );
                    }
                }

                Context.AddEvent(new CreatureUpdateHealthEventArgs(Creature, Health) );

                if (Creature.Health == 0)
                {
                    switch (Creature) 
                    {
                        case Monster monster:

                            return Context.AddCommand(new MonsterDestroyCommand(monster) );

                        case Npc npc:

                            return Context.AddCommand(new NpcDestroyCommand(npc) );

                        case Player player:

                            return Context.AddCommand(new PlayerDestroyCommand(player) );
                    }
                }
            }

            return Promise.Completed;
        }
    }
}