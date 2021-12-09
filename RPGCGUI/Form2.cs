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
            attaque1.Text = Form1.SetValueForText1;
            attaque2.Text = Form1.SetValueForText2;
            attaque3.Text = Form1.SetValueForText3;
            attaque4.Text = Form1.SetValueForText4;
           // attaque1.Text = $"{game.Atk1}";
            //MessageBox.Show($"{game.ButtonListenerAtk1} ouverture form2");
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

        private void attaque2_Click(object sender, EventArgs e)
        {
            game.ButtonListenerAtk2 = true;
            this.Close();
        }

        private void attaque3_Click(object sender, EventArgs e)
        {
            game.ButtonListenerAtk3 = true;
            this.Close();
        }

        private void attaque4_Click(object sender, EventArgs e)
        {
            game.ButtonListenerAtk4 = true;
            this.Close();
        }
    }
}
