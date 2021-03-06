﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancySaiEditor.Nodes.EventNodes
{
    /// <summary>
    /// SMART_EVENT_RESPAWN
    /// 
    /// </summary>
    [Node(MenuName = "Receive emote", Type = NodeType.EVENT_RECEIVE_EMOTE, AllowedTypes = new NodeType[] { NodeType.PARAM_EMOTE, NodeType.PARAM_NPC, NodeType.ACTION })]
    public class ReceiveEmote : EventNode
    {
        /// <summary>
        /// Standard constructor.
        /// Initializes type, node name, tooltips and adds the connectors.
        /// </summary>
        public ReceiveEmote()
        {
            Type = NodeType.EVENT_RECEIVE_EMOTE;

            //Update text
            NodeName.Content = "Receive emote";

            AddParam<ParamNodes.Emote>(ParamId.PARAM_1, NodeType.PARAM_EMOTE, "Emote");
            AddParam(ParamId.PARAM_2, "Cooldown min:");
            AddParam(ParamId.PARAM_3, "Cooldown max:");
            AddParam(ParamId.PARAM_4, "Condition:"); //???
        }

        /// <summary>
        /// Clones the class instance.
        /// </summary>
        /// <returns>Returns clone of this class.</returns>
        public override Node Clone()
        {
            return new ReceiveEmote();
        }
    }
}
