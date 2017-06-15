using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun2Uitdagingen.Logic
{
    public class DBO
    {
        private static SqlConnection conString = new SqlConnection(
            "Server=mssql.fhict.local;Database=dbi348991;User Id = dbi348991; Password=banaan;");

        public static void AddCharacter(int classid, int raceid, string name)
        {
            SqlCommand cmd = new SqlCommand("CreateCharacter", conString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ClassID", classid));
            cmd.Parameters.Add(new SqlParameter("@RaceID", raceid));
            cmd.Parameters.Add(new SqlParameter("@Name", name));
            OpenConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnection();
        }

        public static void SetLevelCharacter(int level, int charID)
        {
            string query = "UPDATE[dbo].[Progress] SET[Level] = " + level + " where CharacterID = " + charID;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conString;
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();

            query = "UPDATE [dbo].[Character] SET[Level] = " + level + " where CharacterID = " + charID;
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conString;
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public static void ExecuteDamageToItem(int ItemID)
        {
            SqlCommand cmd = new SqlCommand("DamageDurability", conString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public static int GetItemDrop(int CharID)
        {
            SqlCommand cmd = new SqlCommand("GetItemDropProc", conString);
            cmd.CommandType = CommandType.StoredProcedure;

            var sendparameter = cmd.Parameters.Add(new SqlParameter("@CharacterID", CharID));
            sendparameter.Direction = ParameterDirection.Input;

            var returnParameter = cmd.Parameters.Add("@ItemName", SqlDbType.VarChar, 255);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            OpenConnection();

            cmd.ExecuteNonQuery();
            var result = returnParameter.Value;
            CloseConnection();

            return Convert.ToInt32(result);
        }

        public static void ExecuteRepairDurability(int ItemID)
        {
            SqlCommand cmd = new SqlCommand("RepairDurability", conString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public static DataTable GetCharactersDataTable(string query)
        {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conString;
                OpenConnection();
                DataTable t1 = new DataTable();
                using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                {
                    a.Fill(t1);
                }
                CloseConnection();
                return t1;
        }

        public static DataTable GetItemFromDB(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conString;

            OpenConnection();
            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            CloseConnection();
            return t1;

        }

        public static DataTable GetItemsAboveLevel(int i)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from GetItemsAboveLevel(@id)";
            cmd.Parameters.AddWithValue("@id", i);
            cmd.Connection = conString;

            OpenConnection();
            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }

            CloseConnection();
            return t1;
        }
        public static DataTable SelectView()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from char_view";
            cmd.Connection = conString;

            OpenConnection();
            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }

            CloseConnection();
            return t1;
        }
        public static DataTable SelectFunction()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select dbo.AddTitleToChar(name) as Name from character";
            cmd.Connection = conString;

            OpenConnection();
            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }

            CloseConnection();
            return t1;
        }


        public static bool OpenConnection()
        {
            var success = true;
            try
            {
                conString.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(@"Error while connecting to database: " + e.Message);
                success = false;
            }

            return success;
        }


        public static bool CloseConnection()
        {
            var success = true;
            try
            {
                conString.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(@"Error while disconnecting from database: " + e.Message);
                success = false;
            }

            return success;
        }
    }
}
