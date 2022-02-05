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
    public partial class super_gerant_child : Form
    {
        string connectionstring = "Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True";
        public super_gerant_child()
        {
            InitializeComponent();
        }

        public void getAll()
        {
            this.dataGridView1.Rows.Clear();
            string Query = "select * from Gerant";
            SqlConnection cnx = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand(Query, cnx);


            cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
                //MessageBox.Show("Name = " + dr[1] + "\nAuteur = " + dr[2] + "\nLe Prix = " + dr[3] + "\nPage = " + dr[4]);

            }
            else
            {
                MessageBox.Show("non gerant !!");

            }
            cnx.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            string connectionstring = "Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True";
            string Query = "select * from Gerant where ID_gerant = @p1";
            SqlConnection cnx = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand(Query, cnx);
            cmd.Parameters.AddWithValue("@p1", this.textBox1.Text.Trim());

            cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                //MessageBox.Show("Name = " + dr[1] + "\nAuteur = " + dr[2] + "\nLe Prix = " + dr[3] + "\nPage = " + dr[4]);

                this.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("entre un id de gerant");
            }
            //else
            //{
            //    MessageBox.Show("le gerant de id = " + this.textBox1.Text + " ne pas existe !!");
            //}
            cnx.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(connectionstring);

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("vider !! Non donnes pour Ajouter ");
            }
            else
            {
                string query = "insert into Gerant values(" + this.textBox1.Text.Trim() + ",'" + this.textBox2.Text.Trim() + "','" + this.textBox3.Text.Trim() + "','" + this.textBox4.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(query, cnx);
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cnx.Open();
                int a = cmd.ExecuteNonQuery();
                MessageBox.Show(a + " (row affected)");
                cnx.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                getAll();
            }
        }

        private void super_gerant_child_Load(object sender, EventArgs e)
        {
            getAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string Query = "update Gerant set NomG=@p2, PrenomG=@p3,Mot_de_passeG=@p4 where ID_gerant = @p1";
            SqlConnection cnx = new SqlConnection(connectionstring);


            SqlCommand cmd = new SqlCommand(Query, cnx);
            cmd.Parameters.AddWithValue("@p1", this.textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@p2", this.textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@p3", this.textBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@p4", this.textBox4.Text.Trim());

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("modifier est secces!");
            getAll();

            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }
        int position = -1, IdBook;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                position = this.dataGridView1.CurrentRow.Index;
                IdBook = int.Parse(this.dataGridView1.Rows[position].Cells[0].Value.ToString());

                this.textBox1.Text = this.dataGridView1.Rows[position].Cells[0].Value.ToString();
                this.textBox2.Text = this.dataGridView1.Rows[position].Cells[1].Value.ToString();
                this.textBox3.Text = this.dataGridView1.Rows[position].Cells[2].Value.ToString();
                this.textBox4.Text = this.dataGridView1.Rows[position].Cells[3].Value.ToString();
                this.textBox1.Enabled = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(connectionstring);
            cnx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from Gerant where ID_gerant = @id";
            cmd.Parameters.AddWithValue("@id", IdBook);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridView1.Rows.RemoveAt(position);
            MessageBox.Show("le Gerent est sepprimer");
            cnx.Close();

            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox1.Text = "";
            this.textBox1.Enabled = true;
        }

    }
}
