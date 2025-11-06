using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBConnection
    {
        private static string connectionStr = "server=localhost;database=schoolmanagement;uid=root;pwd=root";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionStr);
        }

    }
}
