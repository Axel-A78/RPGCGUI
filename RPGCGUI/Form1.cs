using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RPGCGUI
{
    public partial class Form1 : Form
    {


        private Game game;
        public Entite entitegui = new Entite();
        Monstre Dino = new Monstre();
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAttaquant_Click(object sender, EventArgs e)
        {
            textBoxInterface.Text = "Vous avez choisi Clebs, l'Attaquant";
            game.Play(new Entite("Clebs", 250, 35, 15, 15, entitegui.addMoveSet()));
        }



        private void buttonTank_Click(object sender, EventArgs e)
        {
            textBoxInterface.Text = "Vous avez choisi Astaroth, le Tank";
            game.Play(new Entite("Astaroth", 350, 20, 30, 10, entitegui.addMoveSet()));
        }

        private void buttonPolyvalent_Click(object sender, EventArgs e)
        {
            textBoxInterface.Text = "Vous avez choisi Cristaline, le Polyvalent";
            game.Play(new Entite("Cristaline", 300, 15, 15, 15, entitegui.addMoveSet()));
        }

        /*private void attaque1_Click(object sender, EventArgs e)
        {
            textBoxInterface.Text = ($"{entitegui.Nom} attaque {entitegui.Capacites.ElementAt(0)}");
            entitegui.Capacites.ElementAt(0).diminutionPP();
            entitegui.degatsInfliges(entitegui, Dino, 0);
            Console.WriteLine();

            textBoxInterface.Text = ($"{entitegui.Capacites.Select(c => c.NomCapacite).ToList()}");
        }*/
    }
}
