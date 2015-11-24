using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace VideoGameRentalSystem
{
    class RentalManagementSystem
    {
        private static SqlConnection con;
        private static SqlDataReader reader;
        private static Random rand;     
        private string sql;

        public RentalManagementSystem()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=ANDYS-COMPUTER;Database=RedBlocks;Trusted_Connection=true";
            con.Open();
        }

        private int generateUserID()
        {
            rand = new Random(DateTime.Now.Second);
            return rand.Next(1000,9999);
        }

        public DataTable fillDataTable(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public bool register(string firstName, string lastName, string email, string password, string address, string city, string state, string zip)
        {
            sql = "INSERT INTO Users VALUES (" +
                generateUserID() + "," +
                "'" + firstName + "'" + "," +
                "'" + lastName + "'" + "," +
                "'" + email + "'" + "," +
                "'" + password + "'" + "," +
                "'" + address + "'" + "," +
                "'" + city + "'" + "," +
                "'" + state + "'" + "," +
                "'" + zip + "'" + ");";

            return (excecuteData(sql)) ? true : false;
        }

        public bool excecuteData(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                try
                {
                    reader = cmd.ExecuteReader();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return false;
                }
                finally
                {
                    if (!reader.IsClosed)
                    {
                        reader.Close();
                    }
                }
                return true;
            }
        }

        public User logIn(string enteredEmail, string enteredPassword)
        {
            sql = "SELECT * FROM Users WHERE email = '" + enteredEmail + "'";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                try
                {
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader[4].ToString().Equals(enteredPassword))
                            {
                                User newWorkingUser = new User();
                                newWorkingUser.setProfile(
                                    reader[0].ToString(),
                                    reader[1].ToString(), 
                                    reader[2].ToString(), 
                                    reader[3].ToString(), 
                                    reader[4].ToString(), 
                                    reader[5].ToString(), 
                                    reader[6].ToString(), 
                                    reader[7].ToString(), 
                                    reader[8].ToString());
                                return newWorkingUser;
                            }
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    reader.Close();
                }
                return null;
            }
        }
    }
}
