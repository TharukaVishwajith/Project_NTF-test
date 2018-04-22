using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.dbconnection;
using System.Data;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller
{
    public enum PlayerCourseType
    {
        Local,
        Forign,
        All
    }

    public enum PlayerMatchType
    {
        Local,
        Forign
    }
    class PlayerController
    {

        public static int AddCoueses(Course course)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            try
            {
                MySqlCommand command;

                connection.Open();

                String newMemberSql = "INSERT INTO player_courses (courseName,country,venue,date,discription,member_athleticId) VALUES (@courseName,@country,@venue,@date,@discription,@member_athleticId)";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;
             
                command.Parameters.AddWithValue("@courseName", course.CouseName);
                command.Parameters.AddWithValue("@country", course.Country);
                command.Parameters.AddWithValue("@venue", course.Venue);
                command.Parameters.AddWithValue("@date", course.Date);
                command.Parameters.AddWithValue("@discription", course.Discription);
                command.Parameters.AddWithValue("@member_athleticId", course.AthleticId);


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

        public static DataTable GetCourses(String id, PlayerCourseType type)
        {
            MySqlConnection connection = null;
            DataTable dataTable = new DataTable();
            try
            {
                 connection = DBConnection.getDbConnection().getConnection();
                connection.Open();

               
                MySqlCommand cmd = null;
                if (type == PlayerCourseType.Local)
                {
                    cmd = new MySqlCommand("SELECT courseName,country,venue,date,discription FROM player_courses WHERE member_athleticId ='" + id + "' AND Country = 'Sri Lanka'", connection);
                }else if (type == PlayerCourseType.Forign)
                {
                    cmd = new MySqlCommand("SELECT courseName,country,venue,date,discription FROM player_courses WHERE member_athleticId ='" + id + "' AND Country != 'Sri Lanka'", connection);
                }
                else if(type == PlayerCourseType.All){
                    cmd = new MySqlCommand("SELECT courseName,country,venue,date,discription FROM player_courses WHERE member_athleticId ='" + id + "'", connection);
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            
            return dataTable;
        }

        public static int AddMatches(Match match, PlayerMatchType type)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            try
            {
                MySqlCommand command;

                connection.Open();
                String newMatchSql = null;
                if (type == PlayerMatchType.Local)
                {
                    newMatchSql = "INSERT INTO player_local_matches (matchName,venue,date,medal,member_athleticId) VALUES (@matchName,@venue,@date,@medal,@member_athleticId)";
                    command = connection.CreateCommand();
                    command.CommandText = newMatchSql;

                    command.Parameters.AddWithValue("@matchName", match.MatchName);
                    command.Parameters.AddWithValue("@venue", match.Venue);
                    command.Parameters.AddWithValue("@date", match.Date);
                    command.Parameters.AddWithValue("@medal", match.Medal);
                    command.Parameters.AddWithValue("@member_athleticId", match.AthleticId);
                }
                else
                {
                    newMatchSql = "INSERT INTO player_international_matches (matchName,venue,date,medal,country,member_athleticId) VALUES (@matchName,@venue,@date,@medal,@country,@member_athleticId)";
                    command = connection.CreateCommand();
                    command.CommandText = newMatchSql;

                    command.Parameters.AddWithValue("@matchName", match.MatchName);
                    command.Parameters.AddWithValue("@venue", match.Venue);
                    command.Parameters.AddWithValue("@date", match.Date);
                    command.Parameters.AddWithValue("@medal", match.Medal);
                    command.Parameters.AddWithValue("@country", match.Country);
                    command.Parameters.AddWithValue("@member_athleticId", match.AthleticId);
                }
                
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


        public static DataTable GetMatches(String id, PlayerMatchType type)
        {
            MySqlConnection connection = null;
            DataTable dataTable = new DataTable();
            try
            {
                connection = DBConnection.getDbConnection().getConnection();
                if (!connection.Ping())
                {
                    connection.Open();
                }
               

           
            MySqlCommand cmd = null;
            if (type == PlayerMatchType.Local)
            {
                cmd = new MySqlCommand("SELECT matchName,venue,date,medal FROM player_local_matches WHERE member_athleticId ='" + id + "'", connection);
            }
            else if (type == PlayerMatchType.Forign)
            {
                cmd = new MySqlCommand("SELECT matchName,country,venue,date,medal FROM player_international_matches WHERE member_athleticId ='" + id + "'", connection);
            }
           

            
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
    }
}
