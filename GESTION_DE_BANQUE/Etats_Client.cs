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
    public partial class Etats_Client : Form
    {
        public Etats_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True";

            this.dataGridView1.Rows.Clear();
            string Query = "select Nom,Prenom,CIN,Date_versement,Date_retrait,Montant from Client where CIN = @id";
            using (SqlConnection cnx = new SqlConnection(connectionstring))
            {

                SqlCommand cmd = new SqlCommand(Query, cnx);
                cmd.Parameters.AddWithValue("@id", this.textBox1.Text.Trim());

                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    
                    this.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4],dr[5]);

                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("entre RIB de Compte");
                }
                else
                {
                    MessageBox.Show("le Compte de R.I.B = " + this.textBox1.Text + " ne pas existe !!");
                }
                cnx.Close();

            }
        }
    }
}
