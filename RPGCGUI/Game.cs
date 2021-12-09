using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGCGUI // Note: actual namespace depends on the project name.
{
    public class Game
    {
        //static List<Capacite> listeCapacites = new List<Capacite>();
        //static List<Capacite> ListeCapacites { get => listeCapacites; set => listeCapacites = value; }
        

        
        public void Play(Entite monEntite)
        {

            //Entite e = new Entite();
            Monstre m = new Monstre();
            Monstre Dino = new Monstre("Dino", 500, 10, 20, 5, m.addMoveSet(), "Dinosaure grrrrr !!");
            bool victoire = true;
            bool suivant = false;
            Form formAtk = new Form2();
            bool buttonListenerAtk1 = false;
            bool buttonListenerAtk2 = false;
            bool buttonListenerAtk3 = false;
            bool buttonListenerAtk4 = false;

            while (!Dino.EstMort())
            {
                // Tour monstre
                Console.ForegroundColor = ConsoleColor.Red;
                Dino.degatsInfligesMonstre(Dino, monEntite);
                Console.WriteLine();
                

                if (monEntite.EstMort())
                {
                    victoire = false;
                    break;
                }

                //Tour du Personnage
               MessageBox.Show(String.Join(Environment.NewLine, monEntite));
               formAtk.ShowDialog();
               

                while (buttonListenerAtk1 == false && buttonListenerAtk2 == false && buttonListenerAtk3 == false && buttonListenerAtk4 == false)
                {
                    
                    

                    if (buttonListenerAtk1 == true)
                    {
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        monEntite.Capacites.ElementAt(0).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        formAtk.Close();

                    }

                    if (buttonListenerAtk2 == true)
                    {
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        monEntite.Capacites.ElementAt(1).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        formAtk.Close();


                    }

                    if (buttonListenerAtk3 == true)
                    {
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        monEntite.Capacites.ElementAt(2).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        formAtk.Close();


                    }

                    if (buttonListenerAtk4 == true)
                    {
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        monEntite.Capacites.ElementAt(3).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        formAtk.Close();


                    }

                    

                }

                buttonListenerAtk1 = false;
                buttonListenerAtk2 = false;
                buttonListenerAtk3 = false;
                buttonListenerAtk4 = false;



                // monEntite.degatsInfliges(monEntite, Dino);



            }

            if (victoire)
            {
               
                MessageBox.Show("+ 1.000.000 de PO, à quoi sert ton million si tu prend perpèt' ?");

               

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
                
            }
        }
    }
}