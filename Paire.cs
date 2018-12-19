using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Graph
{
    class Paire
    {
        private Noeud node;
        private int edgeValue;

        public Paire(Noeud node, int edgeValue)
        {
            this.node = node;
            this.edgeValue = edgeValue;
        }

        public int EdgeValue { get => edgeValue; set => edgeValue = value; }

        public Noeud Node
        {
            get { return node; }
            set { this.node = value; }
        }


    }
}
