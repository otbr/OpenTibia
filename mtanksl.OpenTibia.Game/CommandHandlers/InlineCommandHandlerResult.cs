﻿using OpenTibia.Game.Commands;
using System;

namespace OpenTibia.Game.CommandHandlers
{
    public class InlineCommandHandlerResult<T, TResult> : CommandHandlerResult<T, TResult> where T : CommandResult<TResult>
    {
        private Func<Context, Func<PromiseResult<TResult>>, T, PromiseResult<TResult> > handle;

        public InlineCommandHandlerResult(Func<Context, Func<PromiseResult<TResult>>, T, PromiseResult<TResult> > handle)
        {
            this.handle = handle;
        }

        public override PromiseResult<TResult> Handle(Func<PromiseResult<TResult>> next, T command)
        {
            return handle(Context, next, command);
        }
    }
}