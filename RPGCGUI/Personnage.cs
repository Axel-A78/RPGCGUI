using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCGUI // Note: actual namespace depends on the project name.
{
    public class Personnage : Entite
    {
        private String attaqueZ;
        public Personnage()
        {
        }

        public Personnage(string nom, int pointDeVie, int attaque, int defense, int vitesse, List<Capacite> capacites, String attaqueZ) : base(nom, pointDeVie, attaque, defense, vitesse, capacites)
        {
            this.attaqueZ = attaqueZ;
        }
    }
}