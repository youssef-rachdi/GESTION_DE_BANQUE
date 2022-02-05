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
    public partial class inscriptionClient_child : Form
    {
        public inscriptionClient_child()
        {
            InitializeComponent();
        }

        private void inscriptionClient_child_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True";
            string query = $"insert into Client values(" + textBox5.Text.Trim() + ",'" + textBox1.Text.Trim() + "','" + this.textBox2.Text.Trim() + "','" + this.textBox3.Text.Trim() + "','" + this.textBox4.Text.Trim() + "','" + this.maskedTextBox1.Text.Trim() + "','" + this.textBox6.Text.Trim() + "'," + this.textBox7.Text.Trim() + ",'02-02-2000','02-02-2000','02-02-2000')";
            
            SqlConnection cnx = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(query,cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("succes!!");
            cnx.Close();
            
        }
    }
}
