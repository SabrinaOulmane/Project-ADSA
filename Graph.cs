using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git
{
    class Graph
    {
        private List<Node> nodes;

        public Graph()
        {
            nodes = new List<Node>();
        }

        public Graph(List<Node> nodes)
        {
            this.nodes = nodes;
        }


        public List<Node> Nodes
        {
            get { return this.nodes; }
            set { this.nodes = value; }
        }

        public Graph(int nodeNumber)
        {
            int[,] array = new int[nodeNumber, nodeNumber];

            Random rmd = new Random();
            //int rando = rmd.Next(0, 2);

            List < Node > list = new List<Node>();
            for(int i=0 ; i<nodeNumber; i++)
            {
                Node newNode = new Node(Convert.ToString(i));
                list.Add(newNode);
                
            }


            //Creation of a matrix to know if two nodes are related or not
            //1 if neighbour, else 0
            for(int i =0; i<nodeNumber; i++)
            {
                for(int j = 0; j<nodeNumber-i; j++)
                {
                    if(j!=i)
                    {
                        if(rmd.Next(0, 2) == 1)
                        {
                            int edgeValue = rmd.Next(0, 20);
                            list[i].AddNeighbor(list[j], edgeValue);
                        }
                    } 
                }
            }

            this.nodes = list;

        }

       public void GraphPrint()
        {
            for(int i = 0; i<this.nodes.Count; i++)
            {
                Console.WriteLine(this.nodes[i].ToString());
            }
        }


    }
}
