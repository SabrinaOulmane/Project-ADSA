using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {   /*List<Node> totalnodes = new List<Node>();
           
            Random rmd = new Random();
            int rando = rmd.Next(0, 101);

            Node node_A = new Node("A");
            Node node_B = new Node("B");
            Node node_C = new Node("C");
            Node node_D = new Node("D");
            Node node_E = new Node("E");
            node_A.AddNeighbor(node_B, rando);
            node_A.AddNeighbor(node_D, rando);
            node_B.AddNeighbor(node_C, rando);
            node_D.AddNeighbor(node_E, rando);
            node_C.AddNeighbor(node_E, rando);
            node_C.AddNeighbor(node_D, rando);
            totalnodes.Add(node_A);

           
            public void SeeGraph(List <Node> totalnodes)
            {

            }*/

            Graph testGraph = new Graph(5);
            testGraph.GraphPrint();



            Console.ReadKey();
        }
    }
}
