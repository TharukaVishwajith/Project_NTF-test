using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.dbconnection;
using System.Windows.Forms;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller
{

    class MemberController
    {

    
    public static Member SearchMemberByAthleticId(String id)
    {
        MySqlConnection connection = DBConnection.getDbConnection().getConnection();
        Member member = null;

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
            
            string s = "select * from MEMBER where athleticId='" + id + "'";
            mcd = new MySqlCommand(s, connection);
            mdr = mcd.ExecuteReader();
            if (mdr.Read())
            {
                member = new Member(mdr.GetString("athleticId"),
                   mdr.GetString("fullName"),
                   mdr.GetString("nameWithInitials"),
                   mdr.GetString("dob"),
                   mdr.GetString("NICNo"),
                   mdr.GetString("address"),
                   mdr.GetInt32("telNo"),
                   mdr.GetInt32("mobileNo"),
                   mdr.GetString("occupation"),
                   mdr.GetString("email"),
                   mdr.GetString("DANorGUP"),
                   mdr.GetString("kukkiwonNo"),
                   mdr.GetString("belt"),
                   mdr.GetString("club"),
                   mdr.GetString("coacher"));
            }
            else
            {
                //  MessageBox.Show("NO DATA");
            }
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
        }
        finally
        {
            // mdr.Close();
            connection.Close();
        }

        return member;

    }

        public static int AddMember(Member member)
        {
            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            try
            {
                MySqlCommand command;
               
                connection.Open();

                String newMemberSql = "INSERT INTO MEMBER (athleticId,fullName,nameWithInitials,dob,NICno,address,telNo,mobileNo,occupation,email,DANorGUP,kukkiwonNo,belt,club,coacher) VALUES (@athleticId,@fullName,@nameWithInitials,@dob,@NICno,@address,@telNo,@mobileNo,@occupation,@email,@DANorGUP,@kukkiwonNo,@belt,@club,@coacher)";
                command = connection.CreateCommand();
                command.CommandText = newMemberSql;
                command.Parameters.AddWithValue("@athleticId", member.AthleticId);
                command.Parameters.AddWithValue("@fullName", member.FullName);
                command.Parameters.AddWithValue("@nameWithInitials", member.NamewithInitials);
                command.Parameters.AddWithValue("@dob", member.Dob);
                command.Parameters.AddWithValue("@NICno", member.NICNo1);
                command.Parameters.AddWithValue("@address", member.Address);
                command.Parameters.AddWithValue("@telNo", member.TelNo);
                command.Parameters.AddWithValue("@mobileNo", member.MobileNo);
                command.Parameters.AddWithValue("@occupation", member.Occupation);
                command.Parameters.AddWithValue("@email", member.Email);
                command.Parameters.AddWithValue("@DANorGUP", member.DANorGUP1);
                command.Parameters.AddWithValue("@kukkiwonNo", member.KukkiwonNo);
                command.Parameters.AddWithValue("@belt", member.Belt);
                command.Parameters.AddWithValue("@club", member.Club);
                command.Parameters.AddWithValue("@coacher", member.Coacher);

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
        public static int UpdateMember(Member member)
        {
            MySqlConnection conn = null;
            try
            {
                conn = DBConnection.getDbConnection().getConnection();
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE MEMBER SET fullName = '" + member.FullName + "' ,nameWithInitials = '" + member.NamewithInitials +
                    "',dob = '" + member.Dob + "',dob = '" + member.Dob + "',NICno = '" + member.NICNo1 + "',occupation = '" +
                    member.Occupation + "',email = '" + member.Email + "',DANorGUP = '" + member.DANorGUP1 + "',kukkiwonNo = '" +
                    member.KukkiwonNo + "',belt = '" + member.Belt + "',club = '" + member.Club + "',coacher = '" + member.Coacher + "' WHERE athleticId = '" + member.AthleticId + "'";

                return command.ExecuteNonQuery();
            } catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        public static int DeleteMember(String id)
        {
            MySqlConnection conn = null;
            try
            {
                conn = DBConnection.getDbConnection().getConnection();
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "DELETE FROM MEMBER WHERE athleticId = '" + id + "'";
                
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
