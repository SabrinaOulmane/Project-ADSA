using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Graph
{
    class Noeud
    {
        private string valeur;
        private List<Paire> voisins;

        public Noeud(string valeur, List<Paire> voisins)
        {
            this.Valeur = valeur;
            this.Voisins = voisins;

        }

        public Noeud(string valeur)
        {
            this.valeur = valeur;
            this.voisins = null;
        }

        public string Valeur { get => valeur; set => valeur = value; }

        public List<Paire> Voisins { get => voisins; set => voisins = value; }

        public void addVoisin (Noeud nveauVoisin, int edgeValeur)
        {
            if (this.voisins == null)
            {
                this.voisins = new List<Paire>();
            }

            Paire nvellePaire1 = new Paire(nveauVoisin, edgeValeur);
            this.voisins.Add(nvellePaire1);

            if(nveauVoisin.voisins == null)
            {
                nveauVoisin.voisins = new List<Paire>();
            }

            Paire nvellePaire2 = new Paire(this, edgeValeur);
            nveauVoisin.voisins.Add(nvellePaire2);
        }




        public override string ToString()
        {
            string s = "";
            s = "Valeur de noeud : " + this.valeur + "/n";
            if (voisins !=  null)
            {
                s = s + "Ses voisins sont : ";
                foreach (Paire voisin in voisins)
                {
                    s = s + "le noeud " + voisin.Node.Valeur + " de distance " + voisin.EdgeValue + " et ";
                }
                s = s + " c'est tout";
            }
            else
            {
                s = s + " et il n'a pas de voisin";
            }
            return s;
            
        }


        public void printVoisins()
        {

        }

    }
}
