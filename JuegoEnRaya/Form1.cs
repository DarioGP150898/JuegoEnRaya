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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void verGanador()
        {
            bool eres_el_ganador = false;



            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                eres_el_ganador = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                eres_el_ganador = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                eres_el_ganador = true;


            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                eres_el_ganador = true;

        }
    }

}
