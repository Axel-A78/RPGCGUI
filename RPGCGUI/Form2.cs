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
    public partial class Form2 : Form


    {

        public Entite entitegui;

        private Game game;

        public Form2(Game game)
        {
            InitializeComponent();
            this.game = game;

            //Recupère les valeurs des attaques du Form1
            attaque1.Text = Form1.SetValueForText1;
            attaque1.Font = new Font(attaque1.Font.FontFamily, 20);

            attaque2.Text = Form1.SetValueForText2;
            attaque2.Font = new Font(attaque2.Font.FontFamily, 20);

            attaque3.Text = Form1.SetValueForText3;
            attaque3.Font = new Font(attaque3.Font.FontFamily, 20);

            attaque4.Text = Form1.SetValueForText4;
            attaque4.Font = new Font(attaque4.Font.FontFamily, 20);

        }

        public void attaque1_Click(object sender, EventArgs e)
        {
           game.ButtonListenerAtk1 = true;
           this.Close();
           //MessageBox.Show($"{game.ButtonListenerAtk1} Click");

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void attaque1_Click_1(object sender, EventArgs e)
        {
            game.ButtonListenerAtk1 = true;
            this.Close();
        }
        private void attaque2_Click_1(object sender, EventArgs e)
        {
            game.ButtonListenerAtk2 = true;
            this.Close();
        }

        

        private void attaque3_Click_1(object sender, EventArgs e)
        {
            game.ButtonListenerAtk3 = true;
            this.Close();
        }
        
        private void attaque4_Click_1(object sender, EventArgs e)
        {
            game.ButtonListenerAtk4 = true;
            this.Close();
        }
    }
}
