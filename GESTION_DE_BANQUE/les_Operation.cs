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
    public partial class les_Operation : Form
    {
        public les_Operation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transfere_child tc = new transfere_child();
            tc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modifier_le_Mot_de_Passe mp = new Modifier_le_Mot_de_Passe();
            mp.Show();
        }

        private void btn_versement_Click(object sender, EventArgs e)
        {
            virsement_child vc = new virsement_child();
            vc.Show();
        }

        private void btn_retraie_Click(object sender, EventArgs e)
        {
            retraie_child rc = new retraie_child();
            rc.Show();
        }

        private void btn_Etats_Click(object sender, EventArgs e)
        {
            Etats_Client ec = new Etats_Client();
            ec.Show();
        }
    }
}
