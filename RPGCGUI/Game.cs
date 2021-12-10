using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGCGUI // Note: actual namespace depends on the project name.
{
    public class Game
    {        
        bool buttonListenerAtk1 = false;
        bool buttonListenerAtk2 = false;
        bool buttonListenerAtk3 = false;
        bool buttonListenerAtk4 = false;
       
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
                Dino.degatsInfligesMonstre(Dino, monEntite);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                

                if (monEntite.EstMort())
                {
                    victoire = false;
                    break;
                }

                //Tour du Personnage
               MessageBox.Show(String.Join(Environment.NewLine, monEntite));

                Form formAtk = new Form2(this);


                while (buttonListenerAtk1 == false && buttonListenerAtk2 == false && buttonListenerAtk3 == false && buttonListenerAtk4 == false)
                {
                    formAtk.ShowDialog();
                    formAtk.Close();

                    if (buttonListenerAtk1 == true)
                    {
                        if (monEntite.Capacites.ElementAt(0).IdStat != 0)
                        {
                            monEntite.ChgtStat(monEntite, Dino, 0);
                            monEntite.Capacites.ElementAt(0).diminutionPP();
                        }
                        else
                        {
                            MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(0)}");
                            monEntite.Capacites.ElementAt(0).diminutionPP();
                            monEntite.degatsInfliges(monEntite, Dino, 0);
                        }
                        formAtk.Close();
                    }

                    if (buttonListenerAtk2 == true)
                    {
                        if (monEntite.Capacites.ElementAt(1).IdStat != 0)
                        {
                            monEntite.ChgtStat(monEntite, Dino, 1);
                            monEntite.Capacites.ElementAt(1).diminutionPP();
                        }
                        else
                        {
                            MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(1)}");
                            monEntite.Capacites.ElementAt(1).diminutionPP();
                            monEntite.degatsInfliges(monEntite, Dino, 1);
                        }

                        formAtk.Close();
                    }

                    if (buttonListenerAtk3 == true)
                    {
                        if (monEntite.Capacites.ElementAt(2).IdStat != 0)
                        {
                            monEntite.ChgtStat(monEntite, Dino, 2);
                            monEntite.Capacites.ElementAt(2).diminutionPP();
                        }
                        else
                        {
                            MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(2)}");
                            monEntite.Capacites.ElementAt(2).diminutionPP();
                            monEntite.degatsInfliges(monEntite, Dino, 2);
                        }

                        formAtk.Close();
                    }

                    if (buttonListenerAtk4 == true)
                    {
                        if (monEntite.Capacites.ElementAt(3).IdStat != 0)
                        {
                            monEntite.ChgtStat(monEntite, Dino, 3);
                            monEntite.Capacites.ElementAt(3).diminutionPP();
                        }
                        else
                        {
                            MessageBox.Show($"{monEntite.Nom}  utilise : {monEntite.Capacites.ElementAt(3)}");
                            monEntite.Capacites.ElementAt(3).diminutionPP();
                            monEntite.degatsInfliges(monEntite, Dino, 3);
                        }
                        formAtk.Close();
                    }
                }
                buttonListenerAtk1 = false;
                buttonListenerAtk2 = false;
                buttonListenerAtk3 = false;
                buttonListenerAtk4 = false;
            }

            if (victoire)
            {
                SoundPlayer music = new SoundPlayer(@"C:\Users\donat\source\repos\Axel-A78\RPGCGUI\music\ffi-victory.wav");
                music.PlayLooping();
                MessageBox.Show("+ 1.000.000 de PO, 5.000XP et rien d'autre.");
                Application.Exit();

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
                SoundPlayer music = new SoundPlayer(@"C:\Users\donat\source\repos\Axel-A78\RPGCGUI\music\a-quoi-sert-ton-million-si-tu-prends-perpet.wav");
                music.PlayLooping();
                MessageBox.Show("C'est perdu...");
                Application.Exit();
                
            }
        }
    }
}