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

        public Entite entitegui = new Entite();

        private Game game;

        public Form2(Game game)
        {
            InitializeComponent();
            this.game = game;
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
    }
}
