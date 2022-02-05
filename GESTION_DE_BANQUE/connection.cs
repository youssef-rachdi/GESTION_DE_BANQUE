using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GESTION_DE_BANQUE
{
    public class connection
    {
        SqlConnection connectionstring;

        public connection()
        {
            connectionstring = new SqlConnection(@"Data Source=DESKTOP-6R21DPP;Initial Catalog=GESTION__DE__BANQUE1;Integrated Security=True");

        }

    }
}
