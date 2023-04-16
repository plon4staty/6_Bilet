using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _6_Bilet
{
    internal class DataBase
    {
        SqlConnection db_con = new SqlConnection(@"Data Source=DESKTOP-BBAJL13\SQLEXPRESS;Initial Catalog = Bileti; Integrated Security=True"); // - для своего ПК
        // @"Server = db.edu.cchgeu.ru; DataBase = 193_Shelylin; User = 193_Shelylin; Password = 193_Shelylin;" - для базы теха
        public void openConnection()
        {
            if (db_con.State == System.Data.ConnectionState.Closed)
            {
                db_con.Open();
            }
        }

        public void closeConnection()
        {
            if (db_con.State == System.Data.ConnectionState.Open)
            {
                db_con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return db_con;
        }
    }
}
