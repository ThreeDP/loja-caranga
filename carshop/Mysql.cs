using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carshop
{
    public class Mysql
    {
        private static MySqlConnection? _mySqlConnection;
        public static MySqlConnection? GetMySqlConnection()
        {
            if (_mySqlConnection == null)
            {
                string connectionString = "Server=localhost;Port=3306;Database=loja_de_carros;Uid=root;";
                _mySqlConnection = new MySqlConnection(connectionString);
            }
            return _mySqlConnection;
        }
    }
}
