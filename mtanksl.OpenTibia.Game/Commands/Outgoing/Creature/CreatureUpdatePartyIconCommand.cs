﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Network.Packets.Outgoing;

namespace OpenTibia.Game.Commands
{
    public class CreatureUpdatePartyIconCommand : Command
    {
        public CreatureUpdatePartyIconCommand(Creature creature, PartyIcon partyIcon)
        {
            Creature = creature;

            PartyIcon = partyIcon;
        }

        public Creature Creature { get; set; }

        public PartyIcon PartyIcon { get; set; }

        public override Promise Execute()
        {
            return Promise.Run( (resolve, reject) =>
            {
                if (Creature.PartyIcon != PartyIcon)
                {
                    Creature.PartyIcon = PartyIcon;

                    Tile fromTile = Creature.Tile;

                    foreach (var observer in Context.Server.GameObjects.GetPlayers() )
                    {
                        if (observer.Tile.Position.CanSee(fromTile.Position) )
                        {
                            Context.AddPacket(observer.Client.Connection, new SetPartyIconOutgoingPacket(Creature.Id, Creature.PartyIcon) );
                        }
                    }
                }

                resolve();
            } );
        }
    }
}