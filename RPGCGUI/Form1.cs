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


        public Game game;
        public Entite entitegui = new Entite();
        Monstre Dino = new Monstre();
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ChooseAtk_Click(object sender, EventArgs e)
        {
            DisplayChoice.Text = "Vous avez choisi Clebs, l'Attaquant";
            Entite Clebs = new Entite("Clebs", 250, 35, 15, 15, entitegui.addMoveSet());
            SetValueForText1 = Clebs.Capacites.ElementAt(0).ToString();
            SetValueForText2 = Clebs.Capacites.ElementAt(1).ToString();
            SetValueForText3 = Clebs.Capacites.ElementAt(2).ToString();
            SetValueForText4 = Clebs.Capacites.ElementAt(3).ToString();
            game.Play(Clebs);
        }

        private void ChoosePolyvalent_Click(object sender, EventArgs e)
        {
            DisplayChoice.Text = "Vous avez choisi Cristaline, le Polyvalent";
            Entite Cristaline = new Entite("Cristaline", 300, 15, 15, 15, entitegui.addMoveSet());
            SetValueForText1 = Cristaline.Capacites.ElementAt(0).ToString();
            SetValueForText2 = Cristaline.Capacites.ElementAt(1).ToString();
            SetValueForText3 = Cristaline.Capacites.ElementAt(2).ToString();
            SetValueForText4 = Cristaline.Capacites.ElementAt(3).ToString();
            game.Play(Cristaline);
        }

        private void ChooseTank_Click(object sender, EventArgs e)
        {
            DisplayChoice.Text = "Vous avez choisi Clebs, l'Attaquant";
            Entite Clebs = new Entite("Clebs", 250, 35, 15, 15, entitegui.addMoveSet());
            SetValueForText1 = Clebs.Capacites.ElementAt(0).ToString();
            SetValueForText2 = Clebs.Capacites.ElementAt(1).ToString();
            SetValueForText3 = Clebs.Capacites.ElementAt(2).ToString();
            SetValueForText4 = Clebs.Capacites.ElementAt(3).ToString();
            game.Play(Clebs);
        }
    }
}
