using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            namePolyvalent.Text = "Sora";
            nameTank.Text = "Blue Moon";
            nameAttaquant.Text = "Clebs";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer start = new SoundPlayer(@"C:\Users\donat\source\repos\Axel-A78\RPGCGUI\music\the-legend-of-zelda-nes-intro-main-theme.wav");
            start.Play();
        }

        private void play(string file)//Fonction pour jouer les musiques
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\donat\source\repos\Axel-A78\RPGCGUI\music\" + file);
            simpleSound.PlayLooping();
        }

        private void ChooseAtk_Click(object sender, EventArgs e)
        {
            DisplayChoice.Text = "Vous avez choisi Clebs, l'Attaquant";
            Entite Clebs = new Entite("Clebs", 250, 35, 15, 15, entitegui.addMoveSet());
            SetValueForText1 = Clebs.Capacites.ElementAt(0).ToString();
            SetValueForText2 = Clebs.Capacites.ElementAt(1).ToString();
            SetValueForText3 = Clebs.Capacites.ElementAt(2).ToString();
            SetValueForText4 = Clebs.Capacites.ElementAt(3).ToString();
            play("undertale-annoying-dog-theme_1.wav"); //ost
            game.Play(Clebs);
        }

        private void ChoosePolyvalent_Click(object sender, EventArgs e)
        {
            DisplayChoice.Text = "Vous avez choisi Sora, le Polyvalent";
            Entite Cristaline = new Entite("Sora", 300, 15, 15, 15, entitegui.addMoveSet());
            SetValueForText1 = Cristaline.Capacites.ElementAt(0).ToString();
            SetValueForText2 = Cristaline.Capacites.ElementAt(1).ToString();
            SetValueForText3 = Cristaline.Capacites.ElementAt(2).ToString();
            SetValueForText4 = Cristaline.Capacites.ElementAt(3).ToString();
            play("kingdom-hearts-boss-themewave-of-darkness-8-bit_1.wav");
            game.Play(Cristaline);
        }

        private void ChooseTank_Click(object sender, EventArgs e)
        {
            DisplayChoice.Text = "Vous avez choisi Blue Moon, le Tank !";
            Entite Clebs = new Entite("Blue Moon", 300, 10, 30, 5, entitegui.addMoveSet());
            SetValueForText1 = Clebs.Capacites.ElementAt(0).ToString();
            SetValueForText2 = Clebs.Capacites.ElementAt(1).ToString();
            SetValueForText3 = Clebs.Capacites.ElementAt(2).ToString();
            SetValueForText4 = Clebs.Capacites.ElementAt(3).ToString();
            play("8-bit-orange-star-theme-advance-wars-dual-strike.wav");
            game.Play(Clebs);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
