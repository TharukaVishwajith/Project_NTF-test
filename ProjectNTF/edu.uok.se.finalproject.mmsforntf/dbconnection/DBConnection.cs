using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.dbconnection
{
    class DBConnection
    {
        private MySqlConnection connection;
        private static DBConnection dbConnection;

        private DBConnection()
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "mysql";
            builder.Database = "teakwondo_db";

            connection = new MySqlConnection(builder.ToString());


        }

        public static DBConnection getDbConnection()
        {
            if (DBConnection.dbConnection == null)
            {
                dbConnection = new DBConnection();
            }

            return dbConnection;

        }

        public MySqlConnection getConnection()
        {

            return connection;
        }


    }
}
