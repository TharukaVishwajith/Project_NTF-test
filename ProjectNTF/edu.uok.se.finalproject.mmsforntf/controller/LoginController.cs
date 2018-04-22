using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.dbconnection;
using System.Data;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller
{
   
    class LoginController
    {
        public static string RequestForAdminLogin(String id,String passsword)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection(); ;
            String member_athleticId = "";
            MySqlCommand mcd;
            MySqlDataReader mdr;
            try
            {
                connection.Open();
            }
            catch
            {

            }

            try
            {
                string s = "SELECT member_athleticId FROM admin WHERE adminId='" + id + "'AND password='" + passsword + "'";
                mcd = new MySqlCommand(s, connection);
                mdr = mcd.ExecuteReader();
                if (mdr.Read())
                {
                    member_athleticId = mdr.GetString("member_athleticId");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // mdr.Close();
                connection.Close();
            }


            return member_athleticId;
        }
    }
}
