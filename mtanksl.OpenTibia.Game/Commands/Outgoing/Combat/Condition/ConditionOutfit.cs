﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Components;
using System;

namespace OpenTibia.Game.Commands
{
    public class ConditionOutfit : Condition
    {
        private DelayBehaviour delayBehaviour;

        public ConditionOutfit(Outfit outfit, int durationInMilliseconds) : base(ConditionSpecialCondition.Outfit)
        {
            Outfit = outfit;

            DurationInMilliseconds = durationInMilliseconds;
        }

        public Outfit Outfit { get; set; }

        public int DurationInMilliseconds { get; set; }

        public override Promise Update(Creature target)
        {
            return Context.Current.AddCommand(new CreatureUpdateOutfitCommand(target, target.BaseOutfit, Outfit) ).Then( () =>
            {
                delayBehaviour = Context.Current.Server.Components.AddComponent(target, new DelayBehaviour(DurationInMilliseconds) );

                return delayBehaviour.Promise;

            } ).Then( () =>
            {
                return Context.Current.AddCommand(new CreatureUpdateOutfitCommand(target, target.BaseOutfit, target.BaseOutfit) );
            } );
        }

        public override void Stop(Server server)
        {
            if (delayBehaviour != null)
            {
                delayBehaviour.Stop(server);
            }
        }
    }
}