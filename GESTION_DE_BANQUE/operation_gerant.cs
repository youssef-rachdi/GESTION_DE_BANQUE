using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_BANQUE
{
    public partial class operation_gerant : Form
    {
        public operation_gerant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_inscriptin_Click(object sender, EventArgs e)
        {
            inscriptionClient_child ic = new inscriptionClient_child();
            ic.Show();
        }

        private void btn_Etats_Click(object sender, EventArgs e)
        {
            Etat_Gerant eg = new Etat_Gerant();
            eg.Show();
        }

        private void btn_GestionGerant_Click(object sender, EventArgs e)
        {
            Form1 super_gerant = new Form1();
            super_gerant.Show();
        }
    }
}
