using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoEnRaya
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int contador_de_turnos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juego 3 en raya");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)

                b.Text = "x";

            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            contador_de_turnos++;
            verGanador();
        }
    }
}
