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
    class AdminController
    {
        public static int AddNewAdmin(String adminLoginName, String password,String athleticId)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            try
            {
                connection.Open();
            }
            catch
            {

            }
            try
            {
                MySqlCommand command;

                String newMemberSql = "INSERT INTO Admin (adminId,password,member_athleticId) VALUES (@adminId,@password,@member_athleticId)";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;

                command.Parameters.AddWithValue("@adminId", adminLoginName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@member_athleticId", athleticId);

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static String SearchAdmin(String id)
        {

            MySqlConnection connection = null;
            String adminId = "";
            MySqlCommand mcd;
            MySqlDataReader mdr;
            connection = DBConnection.getDbConnection().getConnection();
            try
            {
                connection.Open();
            }
            catch { }
            try
            {   
                string s = "SELECT adminId FROM Admin WHERE member_athleticId='" + id + "'";
                mcd = new MySqlCommand(s, connection);
                mdr = mcd.ExecuteReader();
                if (mdr.Read())
                {
                    adminId = mdr.GetString("adminId");
                }
                else
                {
                    //  MessageBox.Show("NO DATA");
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

            return adminId;
        }
    }
}
