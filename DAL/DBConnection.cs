using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBConnection
    {
        private static string connectionStr = "server=localhost;database=test_students;uid=root;pwd=root";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionStr);
        }

    }
}
