using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace transfere
{
    public class Ado
    {
        public SqlConnection cnx = new SqlConnection();
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlCommand cmd = new SqlCommand();
        public DataTable dt = new DataTable();
        public SqlCommandBuilder bd = new SqlCommandBuilder();
        public DataRow ligne;

        //methode connecter 
        public void connecter()
        {
            if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.ConnectionString = @"Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True";
                cnx.Open();

            }
        }
        //methode deconnecter 
        public void deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}
