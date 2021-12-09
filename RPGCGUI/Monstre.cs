using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCGUI // Note: actual namespace depends on the project name.
{
    public class Monstre : Entite
    {
        private string description;
        public Monstre()
        {
        }

        public Monstre(string nom, int pointDeVie, int attaque, int defense, int vitesse, List<Capacite> capacites, String description) : base(nom, pointDeVie, attaque, defense, vitesse, capacites)
        {
            this.description = description;
        }

        public override string ToString()
        {
            return $"Description : {description}.";
        }
    }
}