using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCGUI // Note: actual namespace depends on the project name.
{
    public class Capacite
    {

        private int pointDePouvoir;
        private int pointDeDegat;
        private String nomCapacite;
        //Getters Setters
        public String NomCapacite { get => nomCapacite; set => nomCapacite = value; }
        public int PointDePouvoir { get => pointDePouvoir; set => pointDePouvoir = value; }
        public int PointDeDegat { get => pointDeDegat; set => pointDeDegat = value; }

        //Constructeurs
        public Capacite()
        {
        }

        public Capacite(int pointDePouvoir, int pointDeDegat, string nomCapacite)
        {
            this.pointDePouvoir = pointDePouvoir;
            this.pointDeDegat = pointDeDegat;
            this.nomCapacite = nomCapacite;
        }

        //Methodes
        public void diminutionPP()
        {
            this.pointDePouvoir--;
        }
        public override string ToString()
        {
            return $"{nomCapacite} => {pointDePouvoir}PP";
        }
    }
}