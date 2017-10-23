using System;
using System.Collections.Generic;
using System.Text;

namespace animal_guessing_game
{
    class Node
    {
        public string Message
        {
            get; set;
        }
        public Node nadaNode
        {
            get; set;
        }
        public Node yesNode
        {
            get; set;
        }
        public Node(string nodeMessage)
        {
            Message = nodeMessage;
            nadaNode = null;
            yesNode = null;
        }
        public void setMessage(string nodeMessage)
        {
            Message = nodeMessage;
        }
        public string getMessage()
        {
            return Message;
        }
        public void setNoNode(Node node)
        {
            nadaNode = node;
        }
        public Node getNoNode()
        {
            return nadaNode;
        }
        public void setYesNode(Node node)
        {
            yesNode = node;
        }
        public bool isQuestion()
        {
            if (nadaNode == null && yesNode == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
