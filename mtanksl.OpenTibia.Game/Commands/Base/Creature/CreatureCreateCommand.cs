﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Components;

namespace OpenTibia.Game.Commands
{
    public class CreatureCreateCommand : Command
    {
        public CreatureCreateCommand(string name, Position position)
        {
            Name = name;

            Position = position;
        }

        public string Name { get; set; }

        public Position Position { get; set; }

        public override void Execute(Server server, Context context)
        {
            //Arrange

            Creature creature = server.NpcFactory.Create(Name);

            if (creature == null)
            {
                creature = server.MonsterFactory.Create(Name);
            }

            if (creature != null)
            {
                Tile tile = server.Map.GetTile(Position);

                if (tile != null)
                {
                    //Act

                    server.Map.AddCreature(creature);

                    //Notify

                    new TileAddCreatureCommand(tile, creature).Execute(server, context);

                    foreach (var component in creature.GetComponents<Behaviour>() )
                    {
                        component.Start(server);
                    }

                    base.Execute(server, context);
                }
            }
        }
    }
}