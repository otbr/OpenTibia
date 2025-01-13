﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Common;
using System;

namespace OpenTibia.Game.Commands
{
    public class DamageCondition : Condition
    {
        public DamageCondition(SpecialCondition specialCondition, MagicEffectType? magicEffectType, AnimatedTextColor? animatedTextColor, int[] damages, TimeSpan interval) : base( (ConditionSpecialCondition)specialCondition)
        {
            MagicEffectType = magicEffectType;

            AnimatedTextColor = animatedTextColor;

            Damages = damages;

            Interval = interval;
        }

        public MagicEffectType? MagicEffectType { get; set; }

        public AnimatedTextColor? AnimatedTextColor { get; set; }

        public int[] Damages { get; set; }

        public TimeSpan Interval { get; set; }

        private string key = Guid.NewGuid().ToString();

        public override async Promise OnStart(Creature creature)
        {
            for (int i = 0; i < Damages.Length; i++)
            {
                await Promise.Delay(key, Interval);

                await Context.Current.AddCommand(new CreatureAttackCreatureCommand(null, creature, 
                    
                    new SimpleAttack(null, MagicEffectType, AnimatedTextColor, Damages[i], Damages[i] ) ) );
            }
        }

        public override void Cancel()
        {
            Context.Current.Server.CancelQueueForExecution(key);
        }

        public override Promise OnStop(Creature creature)
        {
            return Promise.Completed;  
        } 
    }
}