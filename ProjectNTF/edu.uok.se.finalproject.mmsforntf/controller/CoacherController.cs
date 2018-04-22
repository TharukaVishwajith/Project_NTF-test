using System;
using System.Windows.Forms;
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
    public enum CoacherCourseType
    {
        Local,
        Forign,
        All
    }
    public enum StudentSelectType
    {
        All,
        Under_Coacher
    }
    class CoacherController
    {
        public static int AddNewCoacher(String instructorLevel, String id)
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

                String newMemberSql = "INSERT INTO coacher (forignInstructorLevel,member_athleticId) VALUES (@forignInstructorLevel,@member_athleticId)";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;

                command.Parameters.AddWithValue("@forignInstructorLevel", instructorLevel);
                command.Parameters.AddWithValue("@member_athleticId", id);

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

        public static int UpdateCoacher(String instructorLevel, String id)
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

                

                String newMemberSql = "UPDATE coacher SET forignInstructorLevel = '" + instructorLevel + "' WHERE member_athleticId = '" + id + "'";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;


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

        public static int DeleteCoacher(String id)
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


                String newMemberSql = "DELETE FROM coacher WHERE member_athleticId = '" + id + "'";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;


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

        public static String SearchCoacher(String id)
        {

            MySqlConnection connection = DBConnection.getDbConnection().getConnection(); ;
            String forignInstructorLevel = "";
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
                string s = "SELECT forignInstructorLevel FROM coacher WHERE member_athleticId='" + id + "'";
                mcd = new MySqlCommand(s, connection);
                mdr = mcd.ExecuteReader();
                if (mdr.Read())
                {
                    forignInstructorLevel = mdr.GetString("forignInstructorLevel");
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

            return forignInstructorLevel;
        }

        public static DataTable GetAllCoachers()
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
             
                DataTable dataTable = new DataTable();
                MySqlCommand cmd = null;

                cmd = new MySqlCommand("SELECT * FROM coacher", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int AddCourses(Course course)
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

               
                String newMemberSql = "INSERT INTO coacher_courses (courseName,contry,venue,year,discription,Coacher_member_athleticId) VALUES (@courseName,@country,@venue,@date,@discription,@member_athleticId)";
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

        public static DataTable GetCourses(String id, CoacherCourseType type)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            try
            {
                connection.Open();
            }
            catch
            {

            }
           

            DataTable dataTable = new DataTable();
            MySqlCommand cmd = null;
            if (type == CoacherCourseType.Local)
            {
                cmd = new MySqlCommand("SELECT courseName,contry,venue,year,discription FROM coacher_courses WHERE Coacher_member_athleticId ='" + id + "' AND Contry = 'Sri Lanka'", connection);
            }
            else if (type == CoacherCourseType.Forign)
            {
                cmd = new MySqlCommand("SELECT courseName,contry,venue,year,discription FROM coacher_courses WHERE Coacher_member_athleticId ='" + id + "' AND Contry != 'Sri Lanka'", connection);
            }
            else if (type == CoacherCourseType.All)
            {
                cmd = new MySqlCommand("SELECT courseName,contry,venue,year,discription FROM coacher_courses WHERE Coacher_member_athleticId ='" + id + "'", connection);
            }

            try
            {
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

        public static int AddForignStudent(ForignStudent fs)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection(); ;
            try
            {
                connection.Open();
            }
            catch(Exception ex) { 
                }
           
            try
            {
              
               
                MySqlCommand command;

               

                String newMemberSql = "INSERT INTO internationalstudent (Name,Country,Belt,Coacher_member_athleticId) VALUES (@Name,@Country,@Belt,@Coacher_member_atheleticId)";

                command = connection.CreateCommand();
                command.CommandText = newMemberSql;
                command.Parameters.AddWithValue("@Name", fs.Name);
                command.Parameters.AddWithValue("@Country", fs.Country);
                command.Parameters.AddWithValue("@Belt", fs.Belt);
                command.Parameters.AddWithValue("@Coacher_member_atheleticId", fs.CoacherAtheleticId);


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

        public static DataTable GetForignStudents(String id, StudentSelectType type)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            try
            {
                connection.Open();
            }
            catch { }
            try
            {
               
                MySqlCommand cmd;
                if (type == StudentSelectType.Under_Coacher)
                {
                    cmd = new MySqlCommand("SELECT Name,Country,Belt FROM internationalstudent WHERE Coacher_member_athleticId ='" + id + "'", connection);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT Name,Country,Belt FROM internationalstudent", connection);
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

        public static int AddWorkedPlaces(WorkedPlace wp)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            try
            {
                connection.Open();
            }
            catch (Exception ex) { }

            try
            {
                MySqlCommand command;

               

                String newMemberSql = "INSERT INTO worked_places (Place,startedDate,endDate,Coacher_member_athleticId) VALUES (@Place,@startedDate,@endDate,@Coacher_member_atheleticId)";

                command = connection.CreateCommand();
                command.CommandText = newMemberSql;
                command.Parameters.AddWithValue("@Place", wp.Place);
                command.Parameters.AddWithValue("@startedDate", wp.StartedDate);
                command.Parameters.AddWithValue("@endDate", wp.EndDate);
                command.Parameters.AddWithValue("@Coacher_member_atheleticId", wp.AthleticId);


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

        public static DataTable GetWorkedPlaces(String id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = DBConnection.getDbConnection().getConnection(); ;

            try
            {
                connection.Open();
            }
            catch { }
            try
            {
                
              

                MySqlCommand cmd;

                cmd = new MySqlCommand("SELECT * FROM worked_places WHERE Coacher_member_athleticId ='" + id + "'", connection);

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


        public static int AddLocalStudent(String studentId, String coacherId)
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

                

                String newMemberSql = "INSERT INTO nationalLevelStudent (AthleticId,Coacher_member_athleticId) VALUES (@AthleticId,@Coacher_member_athleticId)";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;

                command.Parameters.AddWithValue("@AthleticId", studentId);
                command.Parameters.AddWithValue("@Coacher_member_athleticId", coacherId);

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

        public static DataTable GetLocalStudents(String id, StudentSelectType type)
        {
            DataTable dataTable = new DataTable();
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
               

                MySqlCommand cmd;
                if (type == StudentSelectType.Under_Coacher)
                {
                    cmd = new MySqlCommand("SELECT AthleticId FROM nationallevelstudent WHERE Coacher_member_athleticId ='" + id + "'", connection);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT AthleticId FROM nationalLevelStudent", connection);
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

        public static int DeleteLocalStudent(String studentId,String coacherId)
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

               

                String newMemberSql = "DELETE FROM nationalLevelStudent WHERE AthleticId = '" + studentId + "'AND Coacher_member_athleticId = '" + coacherId + "'";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;


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

        public static int DeleteForignStudent(ForignStudent fs)
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

               

                String newMemberSql = "DELETE FROM internationalstudent WHERE Name = '" + fs.Name + "' AND Country = '" + fs.Country + "' AND Coacher_member_athleticId = '" + fs.CoacherAtheleticId + "'";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;


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


        public static int DeleteWorkedPlace(WorkedPlace wp)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {

            }
            try
            {
                MySqlCommand command;

                string date="";
                string[] dateformat = wp.StartedDate.Split(' ');
                date =  dateformat[0];
                dateformat = date.Split('/');
                date = dateformat[2] + "-" + dateformat[0] + "-" + dateformat[1];
            

                String newMemberSql = "DELETE FROM worked_places WHERE Place = '" + wp.Place + "' AND StartedDate = '" + date + "' AND Coacher_member_athleticId = '" + wp.AthleticId + "'";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;


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

        public static int DeleteCourses(String name,String country,String year,String id)
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

                String newMemberSql = "DELETE FROM Coacher_courses WHERE courseName = '" + name + "' AND contry = '" + country + "' AND year = '" + year + "' AND Coacher_member_athleticId = '" + id + "'";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;
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

        public static int DeleteNationalLevelStudent(String coacherId, String studentId)
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

                String newMemberSql = "DELETE FROM nationallevelstudent WHERE AthlecId = '" + coacherId + "' AND Coacher_member_athleticId = '" + studentId + "'";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;
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
    }
}
