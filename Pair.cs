using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git
{
    class Pair
    {
        private Node node;
        private int edgeValue;

        public Pair(Node node, int edgeValue)
        { this.node = node;
            this.edgeValue = edgeValue;
        }
        public Node Node
        { get { return node; }

        set { node = value; }
        }
        public int EdgeValue
        {
            get { return edgeValue; }

            set { edgeValue = value; }
        }
    }
}
