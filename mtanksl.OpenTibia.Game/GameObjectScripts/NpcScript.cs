﻿using OpenTibia.Common.Objects;
using OpenTibia.Common.Structures;
using OpenTibia.Game.Components;

namespace OpenTibia.Game.GameObjectScripts
{
    public class NpcScript : GameObjectScript<string, Npc>
    {
        public override string Key
        {
            get
            {
                return "";
            }
        }

        public override void Start(Npc npc)
        {
            if (npc.Metadata.Sentences != null)
            {
                Context.Server.GameObjectComponents.AddComponent(npc, new CreatureTalkBehaviour(TalkType.Say, npc.Metadata.Sentences) );
            }

            ConversationPlugin conversationPlugin = Context.Server.Plugins.GetConversationPlugin(npc.Name);

            if (conversationPlugin != null)
            {
                Context.Server.GameObjectComponents.AddComponent(npc, new NpcThinkBehaviour(conversationPlugin, new RandomWalkStrategy(2) ) );
            }
        }

        public override void Stop(Npc npc)
        {

        }
    }
}