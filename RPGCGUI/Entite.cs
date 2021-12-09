using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGCGUI // Note: actual namespace depends on the project name.
{
    public class Entite
    {

        private String nom;
        private int pointDeVie;
        private int attaque;
        private int defense;
        private int vitesse;
        protected bool estMort = false;
        private List<Capacite> capacites = new List<Capacite>();

        // Getters setters
        public String Nom { get => nom; set => nom = value; }
        public List<Capacite> Capacites { get => capacites; set => capacites = value; }
        public int PointDeVie { get => pointDeVie; set => pointDeVie = value; }
        public int Attaque { get => attaque; set => attaque = value; }
        public int Defense { get => defense; set => defense = value; }
        public int Vitesse { get => vitesse; set => vitesse = value; }

        //Constructeurs
        public Entite()
        {
        }

        public Entite(String nom, int pointDeVie, int attaque, int defense, int vitesse, List<Capacite> capacites)
        {
            this.nom = nom;
            this.pointDeVie = pointDeVie;
            this.attaque = attaque;
            this.defense = defense;
            this.vitesse = vitesse;
            this.capacites = capacites;
        }

        //Methodes
        public void degatsInfliges(Entite atk, Entite def, int id)
        {
            double degatsDec = atk.attaque * atk.Capacites.ElementAt(id).PointDeDegat / def.defense - (def.vitesse * (25 / 100));
            Math.Round(degatsDec, 2);
            int degats = (int)degatsDec;
            def.LoseHP(degats);
           MessageBox.Show(atk.nom + "(" + atk.pointDeVie + ")" + "attaque : " + def.nom + "\r\n" +
                            def.nom + " a perdu " + degats + " points de vie. \r\n " +
                            "Il reste : " + def.pointDeVie + " points de vie à " + def.nom);
           
            if (def.estMort)
            {
                MessageBox.Show(def.nom + " est mort !");
            }
        }

        public void degatsInfligesMonstre(Entite atk, Entite def)
        {
            double degatsDec = atk.attaque * 80 / def.defense - (def.vitesse * (25 / 100));
            Math.Round(degatsDec, 2);
            int degats = (int)degatsDec;
            def.LoseHP(degats);
            MessageBox.Show(atk.nom + "(" + atk.pointDeVie + ")" + "attaque : " + def.nom + "\r\n" +
                            def.nom + " a perdu " + degats + " points de vie. \r\n" +
                            "Il reste : " + def.pointDeVie + " points de vie à " + def.nom);
            if (def.estMort)
            {
                Console.WriteLine(def.nom + " est mort !");
            }
        }

        protected void LoseHP(int pointDeVie)
        {
            this.pointDeVie -= pointDeVie;
            if (this.pointDeVie <= 0)
            {
                this.pointDeVie = 0;
                estMort = true;
            }
        }

        public bool EstMort()
        {
            return this.estMort;
        }



        public override string ToString()
        {
            return $"| Nom : {nom} | PV : {pointDeVie} |\r\n Capacités : \r\n {String.Join(" \r\n ", capacites)}  ";
        }

        private static Random rng = new Random();

        //Liste aléatoire de 4 attaques
        public List<Capacite> addMoveSet()
        {
            List<Capacite> moveset = new List<Capacite>();
            capacites.Add(new Capacite(10, 50, "Slash cieux"));
            capacites.Add(new Capacite(5, 90, "Avan Strash"));
            capacites.Add(new Capacite(15, 40, "Slash Mer"));
            capacites.Add(new Capacite(20, 20, "Slash Terre"));
            capacites.Add(new Capacite(20, 0, "AtkPlus",1));
            capacites.Add(new Capacite(40, 0, "Miaule",4));
            capacites.Add(new Capacite(20, 0, "En garde",5));
            capacites.Add(new Capacite(20, 0, "Cavale"));
            var shuffledMoveSet = capacites.OrderBy(a => rng.Next()).ToList();

            for (int i = 0; i < Capacites.Count; i++)
            {
                if (i < 4)
                {
                    Capacite c = shuffledMoveSet[i];
                    moveset.Add(c);
                }
            }
            return moveset;
        }

        public int ChgtStat(Entite atk, Entite def, int id)
        {
            //Augmentation de la stat Attaque pour l'attaquant
            if (atk.Capacites.ElementAt(id).IdStat == 1)
            {
                atk.Attaque += atk.Attaque*1/2;
                MessageBox.Show("L'attaque de  " + atk.nom + $" augmente ! { atk.Attaque}");
                return atk.Attaque;
            }

            //Diminution de la stat Attaque pour l'attaquant
            if (atk.Capacites.ElementAt(id).IdStat == 2)
            {
                atk.Attaque -= atk.Attaque * 50 / 100;
                MessageBox.Show("l'attaque de " + atk.nom + $" diminue !");
                return atk.Attaque;
            }

            //Augmentation de la stat Attaque pour le défenseur
            if (atk.Capacites.ElementAt(id).IdStat == 3)
            {
                def.Attaque +=def.Attaque * 50 / 100;
                MessageBox.Show("l'attaque de " + def.nom + $" augmente !");
                return atk.Attaque;
            }

            //Diminution de la stat Attaque pour le défenseur
            if (atk.Capacites.ElementAt(id).IdStat == 4)
            {
                def.Attaque -= def.Attaque * 50 / 100;
                MessageBox.Show("l'attaque de " + def.nom + $" diminue ! {def.Attaque}");
                return def.Attaque;
            }

            //Augmentation de la stat Défense pour l'attaquant
            if (atk.Capacites.ElementAt(id).IdStat == 5)
            {
                atk.Defense +=  atk.Defense * 50 / 100;
                MessageBox.Show("la défense de " + atk.nom + $" augmente ! {atk.Defense}");
                return atk.Defense;
            }

            //Diminution de la stat Défense pour l'attaquant
            if (atk.Capacites.ElementAt(id).IdStat == 6)
            {
                atk.Defense -= atk.Defense * 50 / 100;
                MessageBox.Show("la défense de " + atk.nom + $" diminue !");
                return atk.Defense;
            }

            //Augmentation de la stat Defense pour le défenseur
            if (atk.Capacites.ElementAt(id).IdStat == 7)
            {
                def.Defense += def.Defense * 50 / 100;
                MessageBox.Show("la défense de " + def.nom + $" diminue !");
                return atk.Defense;
            }

            //Diminution de la stat Défense pour le défenseur
            if (atk.Capacites.ElementAt(id).IdStat == 8)
            {
                def.Defense -= def.Defense * 50 / 100;
                MessageBox.Show("la défense de " + def.nom + $" diminue !");
                return atk.Defense;
            }
            return atk.attaque;

        }

    }
}