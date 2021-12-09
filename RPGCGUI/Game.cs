using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCGUI // Note: actual namespace depends on the project name.
{
    public class Game
    {
        //static List<Capacite> listeCapacites = new List<Capacite>();
        //static List<Capacite> ListeCapacites { get => listeCapacites; set => listeCapacites = value; }
        public Game()
        {

            Menu();

            Entite e = new Entite();

            /*   var capacites = e.Capacites;
               // List<Capacite> capacites = new List<Capacite>();
               capacites.Add(new Capacite(10, 50, "Slash cieux"));
               capacites.Add(new Capacite(5, 90, "Avan Strash"));
               capacites.Add(new Capacite(15, 40, "Slash Mer"));
               capacites.Add(new Capacite(20, 20, "Slash Terre"));
               capacites.Add(new Capacite(20, 20, "Slash Mer"));
               capacites.Add(new Capacite(40, 0, "Miaule"));
               capacites.Add(new Capacite(20, 0, "En garde"));
               capacites.Add(new Capacite(20, 0, "Cavale"));

                    List<Entite> entites = new List<Entite>();
                    entites.Add(new Entite("Astaroth", 350, 20, 30, 10, e.addMoveSet()));
                    entites.Add(new Entite("Clebs", 350, 20, 30, 10, e.addMoveSet()));

                    Console.Write(String.Join(Environment.NewLine, entites));
                   */
        }
        //Methodes

        static void chooseSkill()
        {

        }
        public void Play(Entite monEntite)
        {
            //Entite e = new Entite();
            Monstre m = new Monstre();
            Monstre Dino = new Monstre("Dino", 500, 10, 20, 5, m.addMoveSet(), "Dinosaure grrrrr !!");
            bool victoire = true;
            bool suivant = false;

            while (!Dino.EstMort())
            {
                // Tour monstre
                Console.ForegroundColor = ConsoleColor.Red;
                Dino.degatsInfligesMonstre(Dino, monEntite);
                Console.WriteLine();
                //Console.ReadKey(true);

                if (monEntite.EstMort())
                {
                    victoire = false;
                    break;
                }

                //Tour du Personnage
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(String.Join(Environment.NewLine, monEntite));
                Console.WriteLine("Selectionnez l'attaque ! (1,2,3,4)");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        monEntite.Capacites.ElementAt(0).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(1)}");
                        monEntite.Capacites.ElementAt(1).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 1);

                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(2)}");
                        monEntite.Capacites.ElementAt(2).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 2);

                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(3)}");
                        monEntite.Capacites.ElementAt(3).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 3);

                        Console.WriteLine();
                        break;
                }

                // monEntite.degatsInfliges(monEntite, Dino);
                Console.WriteLine();
                //Console.ReadKey(true);

            }

            if (victoire)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("+ 1.000.000 de PO, à quoi sert ton million si tu prend perpèt' ?");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Salle suivant ? (O/N)");
                    String saisie = Console.ReadLine().ToUpper();
                    if (saisie == "O")
                    {
                        suivant = true;
                        Play(monEntite);
                    }
                    else if (saisie == "N")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("C'est perdu...");
                //Console.ReadKey();
            }
        }
        static void Menu()
        {
            Entite e = new Entite();
            var capacites = e.Capacites;

            capacites.Add(new Capacite(10, 50, "Slash cieux"));
            capacites.Add(new Capacite(5, 90, "Avan Strash"));
            capacites.Add(new Capacite(15, 40, "Slash Mer"));
            capacites.Add(new Capacite(20, 20, "Slash Terre"));
            capacites.Add(new Capacite(20, 0, "AtkPlus"));
            capacites.Add(new Capacite(40, 0, "Miaule"));
            capacites.Add(new Capacite(20, 0, "En garde"));
            capacites.Add(new Capacite(20, 0, "Cavale"));

            Console.WriteLine("Le jeu");
            Console.WriteLine();
            Console.WriteLine("Choisis ton personnage");
            Console.WriteLine("1. Tank");
            Console.WriteLine("2. Attaquant");
            Console.WriteLine("3. Polyvalent");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();

            /*switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisi Astaroth, le Tank");
                    Console.WriteLine();
                    Play(new Entite("Astaroth", 350, 20, 30, 10, e.addMoveSet()));
                    break;

                case "2":
                    Console.WriteLine("Vous avez choisi Clebs, l'Attaquant");
                    Console.WriteLine();
                    Play(new Entite("Clebs", 250, 35, 15, 15, e.addMoveSet()));
                    break;

                case "3":
                    Console.WriteLine("Vous avez choisi Cristaline, le Polyvalent");
                    Console.WriteLine();
                    Play(new Entite("Cristaline", 300, 15, 15, 15, e.addMoveSet()));
                    break;

                case "4":
                    break;
            }*/
        }
    }
}