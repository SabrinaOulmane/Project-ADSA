using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git
{
    class Node
    {
        private string adress;
        private List<Pair> neighbor;

        public Node(string adress, List<Pair> neighbor)
        {
            this.adress = adress;
            this.neighbor = new List<Pair>();
        }
        public Node(string adress)
        {
            this.adress = adress;
           
        }

        public Node()
        {
            this.neighbor = new List<Pair>();
        }

        public string Adress 
        {
           get { return adress; }
            set { adress = value; }
        }
        public List<Pair> Neighbor
        {
            get { return neighbor; }
            set { neighbor = value; }
        }

        public void AddNeighbor(Node newNeighbor, int edgeValue)
        {

            if (this.neighbor == null)
            {
                this.neighbor = new List<Pair>();
            }
            Pair newPair = new Pair(newNeighbor, edgeValue);
            this.neighbor.Add(newPair);
        }

        public override string ToString()
        {
            string s = "\n";
            s = "Node value : " + this.adress + "\n";
            if(this.neighbor != null)
            {
                s = s + "His neighbors are : ";
                foreach(Pair element in neighbor)
                {
                    s = s + "the node " + element.Node.Adress +  " of distance " + element.EdgeValue + " and ";          
                }
                s = s + "and that's all";
            }
            else
            {
                s = s + " and he has no neighbor";
            }




            return s;
        }

    }
}
