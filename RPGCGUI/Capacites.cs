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
        private int idStat;
        //Getters Setters
        public String NomCapacite { get => nomCapacite; set => nomCapacite = value; }
        public int PointDePouvoir { get => pointDePouvoir; set => pointDePouvoir = value; }
        public int PointDeDegat { get => pointDeDegat; set => pointDeDegat = value; }
        public int IdStat { get => idStat; set => idStat = value; }

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

        public Capacite(int pointDePouvoir, int pointDeDegat, string nomCapacite, int IdStat)
        {
            this.pointDePouvoir = pointDePouvoir;
            this.pointDeDegat = pointDeDegat;
            this.nomCapacite = nomCapacite;
            this.IdStat = IdStat;
        }

        //Methodes
        public void diminutionPP()
        {
            this.pointDePouvoir--;
        }
        public override string ToString()
        {
            return $"{nomCapacite} => {pointDePouvoir}PP "; //=> {pointDePouvoir}PP
        }
    }
}