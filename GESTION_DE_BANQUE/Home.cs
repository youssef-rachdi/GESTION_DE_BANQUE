using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GESTION_DE_BANQUE
{

    public partial class Home : Form
    {
        string Connectionstring = "Data Source=DESKTOP-6R21DPP;Initial Catalog=Gestion_de_BANQUE;Integrated Security=True";
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client f2 = new client();
            f2.Show();
        }

        private void btngerant_Click(object sender, EventArgs e)
        {
            gerant gerant = new gerant();
            gerant.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }
    }
}
