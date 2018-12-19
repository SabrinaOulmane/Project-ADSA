using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Graph
{
    class Program
    {






        static void Main(string[] args)
        {
            Noeud node_A = new Noeud("A");
            Noeud node_B = new Noeud("B");
            Noeud node_C = new Noeud("C");
            Noeud node_D = new Noeud("D");
            Noeud node_E = new Noeud("E");

            node_A.addVoisin(node_B, 4);
            node_A.addVoisin(node_C, 8);
            node_C.addVoisin(node_B, 7);
            node_C.addVoisin(node_D, 10);
            node_C.addVoisin(node_E, 25);
            node_D.addVoisin(node_B, 18);
            node_D.addVoisin(node_E, 12);

            


        }
    }
}
