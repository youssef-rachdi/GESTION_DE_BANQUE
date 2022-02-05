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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionstring = "Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True";
            //string query = "select CIN from Client where CIN =@id";



            //SqlConnection cnx = new SqlConnection(connectionstring);
            //cnx.Open();
            //SqlParameter[] param = new SqlParameter[1];
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = query;

            //cmd.Connection = cnx;
            //param[0] = new SqlParameter("@id",SqlDbType.Int,20);
            //param[0].Value = textBox1.Text;


            //if (param[0].Value == this.textBox1.Text.Trim())
            //{
            //    les_Operation opereration = new les_Operation();
            //    opereration.Show();
            //}
            //MessageBox.Show("try again !!");

            //cmd.ExecuteNonQuery();
            //cnx.Close();
            //if (textBox1.Text != "admin"&& textBox2.Text != "admin")
            //{
            //    MessageBox.Show("error!!");
            //    return;
            //}
            les_Operation opereration = new les_Operation();
            opereration.Show();
            

        }
    }
}
