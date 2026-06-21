using System;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class ClsCountryData
    {

        public static bool UpdateRateCountriesByCountryCode(string CountryCode, decimal NewRate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"UPDATE Countries 
                            SET
                            Rate = @NewRate
                            WHERE 
                            Code = @CountryCode";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryCode", CountryCode);
            command.Parameters.AddWithValue("@NewRate", NewRate);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        
        }
        public static bool GetCountriesByCountryID(int CountryID, ref string CountryName,
            ref string Code, ref string Currency, ref decimal Rate)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@CountryID", CountryID);
            
            try
            {
            
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                
                    isFound = true;
                    
                    CountryName = (string)reader["CountryName"];
                    Code = (string)reader["Code"];
                    Currency = (string)reader["Currency"];
                    Rate = (decimal)reader["Rate"];
                
                }
                else
                {
                
                    isFound = false;
                }
                
                reader.Close();
            
            }
            catch (Exception ex)
            {
            
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        
        }

        public static bool GetCountriesByCountryName(ref int CountryID, string CountryName,
            ref string Code, ref string Currency, ref decimal Rate)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    CountryID = (int)reader["CountryID"];
                    Code = (string)reader["Code"];
                    Currency = (string)reader["Currency"];
                    Rate = (decimal)reader["Rate"];

                }
                else
                {

                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool GetCountriesByCountryCode(ref int CountryID, ref string CountryName,
             string Code, ref string Currency, ref decimal Rate)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE Code = @Code";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Code", Code);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    CountryID = (int)reader["CountryID"];
                    CountryName = (string)reader["CountryName"];
                    Currency = (string)reader["Currency"];
                    Rate = (decimal)reader["Rate"];

                }
                else
                {

                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static DataTable GetAllCountries()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"Select * From Countries";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static DataTable GetAllCountryCode()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"select distinct Code from Countries";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

    }
}
