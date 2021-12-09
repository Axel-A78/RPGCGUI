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

        bool buttonListenerAtk1 = false;
        bool buttonListenerAtk2 = false;
        bool buttonListenerAtk3 = false;
        bool buttonListenerAtk4 = false;
        /* String atk1 = " ";
        String atk2 = " ";
        String atk3 = " ";
        String atk4 = " ";
        */
        public bool ButtonListenerAtk1 { get => buttonListenerAtk1; set => buttonListenerAtk1 = value; }
        public bool ButtonListenerAtk2 { get => buttonListenerAtk2; set => buttonListenerAtk2 = value; }
        public bool ButtonListenerAtk3 { get => buttonListenerAtk3; set => buttonListenerAtk3 = value; }
        public bool ButtonListenerAtk4 { get => buttonListenerAtk4; set => buttonListenerAtk4 = value; }
        /*
        public String Atk1 { get => atk1; set => atk1 = value; }
        public String Atk2 { get => atk2; set => atk2 = value; }
        public String Atk3 { get => atk3; set => atk3 = value; }
        public String Atk4 { get => atk4; set => atk4 = value; }
        */

        public void Play(Entite monEntite)
        {

            Monstre m = new Monstre();
            Monstre Dino = new Monstre("Dino", 500, 10, 20, 5, m.addMoveSet(), "Dinosaure grrrrr !!");

            bool victoire = true;
            bool suivant = false;

            


            while (!Dino.EstMort())
            {
                // Tour monstre
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                

                if (monEntite.EstMort())
                {
                    victoire = false;
                    break;
                }

                //Tour du Personnage
               MessageBox.Show(String.Join(Environment.NewLine, monEntite));

                //MessageBox.Show($"{ButtonListenerAtk1} game");
                Form formAtk = new Form2(this);


                while (buttonListenerAtk1 == false && buttonListenerAtk2 == false && buttonListenerAtk3 == false && buttonListenerAtk4 == false)
                {
                    formAtk.ShowDialog();
                    formAtk.Close();
                    //MessageBox.Show($"{ButtonListenerAtk1} dans le while");
                    



                    if (buttonListenerAtk1 == true)
                    {
                        //MessageBox.Show($"{ButtonListenerAtk1} atk 1 true");
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(0)}");
                        monEntite.Capacites.ElementAt(0).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        formAtk.Close();

                    }

                    if (buttonListenerAtk2 == true)
                    {
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(1)}");
                        monEntite.Capacites.ElementAt(1).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        formAtk.Close();


                    }

                    if (buttonListenerAtk3 == true)
                    {
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(2)}");
                        monEntite.Capacites.ElementAt(2).diminutionPP();
                        monEntite.degatsInfliges(monEntite, Dino, 0);
                        formAtk.Close();


                    }

                    if (buttonListenerAtk4 == true)
                    {
                        //Console.WriteLine($"{monEntite.Nom} attaque {monEntite.Capacites.ElementAt(0)}");
                        MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(3)}");
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

              /*  while (!suivant)
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
              */
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