using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Graph
{
    class Graph
    {
        private List<Noeud> nodes;


        public Graph(List<Noeud> nodes)
        {
            this.Nodes = nodes;
        }

        public Graph()
        {
            this.Nodes = new List<Noeud>();
        }

        public List<Noeud> Nodes { get => nodes; set => nodes = value; }


        /*public void recherche (Noeud start, Noeud finish, )
        {

        }*/
    }
}
