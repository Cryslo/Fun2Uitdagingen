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
            conString.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conString.Close();
        }

        public static void SetLevelCharacter(int level, int charID)
        {
            string query = "UPDATE[dbo].[Progress] SET[Level] = " + level + " where CharacterID = " + charID;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conString;
            conString.Open();
            cmd.ExecuteNonQuery();
            conString.Close();
        }

        public static void ExecuteDamageToItem(int ItemID)
        {
            SqlCommand cmd = new SqlCommand("DamageDurability", conString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));
            conString.Open();
            cmd.ExecuteNonQuery();
            conString.Close();
        }

        public static void ExecuteRepairDurability(int ItemID)
        {
            SqlCommand cmd = new SqlCommand("RepairDurability", conString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));
            conString.Open();
            cmd.ExecuteNonQuery();
            conString.Close();
        }

        public static DataTable GetCharactersDataTable(string query)
        {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conString;

                conString.Open();
                DataTable t1 = new DataTable();
                using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                {
                    a.Fill(t1);
                }
                conString.Close();
                return t1;
        }
    }
}
