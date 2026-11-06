using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace skillpass_ismaya
{
    internal class koneksi
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(
            "Data Source=.\\SQLEXPRESS;" +
            "Initial Catalog=db_donasi_ismaya;" + // nama database
            "Integrated Security=True;" + // mode keamanan windows
            "TrustServerCertificate=True;" // validasi sertifikat
             );

            return conn;

        }
    }
}