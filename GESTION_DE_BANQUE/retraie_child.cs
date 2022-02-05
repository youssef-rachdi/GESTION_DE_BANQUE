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
    public partial class retraie_child : Form
    {
        public retraie_child()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True";
            string Query = "update Client set Montant = Montant - @p1 ,Date_retrait=@Date  where CIN = @id";

            SqlConnection cnx = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            cmd.Parameters.AddWithValue("@p1", this.textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@id", this.textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@Date", this.textBox3.Text.Trim());


            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("ratrait est secces!");
        }
    }
}
