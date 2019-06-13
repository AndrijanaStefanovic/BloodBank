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

        public bool TryCreateDonor(Donor donor)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commandText = "INSERT INTO [dbo].[DONOR]([FIRST_NAME],[LAST_NAME],[EMAIL],[PASSWORD],[BLOOD_TYPE])" +
                                       $" VALUES ('{donor.FirstName}','{donor.LastName}','{donor.Email}','{donor.Password}',{(int)donor.BloodType});";
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
