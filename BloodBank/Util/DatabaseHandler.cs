using BloodBank.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BloodBank.Util
{
    public class DatabaseHandler
    {
        private const string connectionString = "Data Source=DESKTOP-4VDDSDR\\SERVER;Initial Catalog=BloodBank;Integrated Security=True";

        private bool TryConnect(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                return true;
            }
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool TryCreateDonor(Donor donor)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (!TryConnect(conn)) return false;

                string commandText = "INSERT INTO [dbo].[DONOR]([ID],[FIRST_NAME],[LAST_NAME],[EMAIL],[BLOOD_TYPE])" +
                                       $" VALUES ({donor.Id},'{donor.FirstName}','{donor.LastName}','{donor.Email}',{(int)donor.BloodType});";
                using (SqlCommand command = new SqlCommand(commandText, conn))
                {
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Database Error : " + e.Message);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
