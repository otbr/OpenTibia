﻿using OpenTibia.Common.Objects;

namespace OpenTibia.Game.Commands
{
    public class TileCreateNpcCommand : CommandResult<Npc>
    {
        public TileCreateNpcCommand(Tile tile, string name)
        {
            Tile = tile;

            Name = name;
        }

        public Tile Tile { get; set; }

        public string Name { get; set; }

        public override PromiseResult<Npc> Execute()
        {
            return Promise.Run<Npc>( (resolve, reject) =>
            {
                Npc npc = Context.Server.NpcFactory.Create(Name);

                if (npc != null)
                {
                    Context.AddCommand(new TileAddCreatureCommand(Tile, npc) );
                }

                resolve(npc);
            } );
        }
    }
}