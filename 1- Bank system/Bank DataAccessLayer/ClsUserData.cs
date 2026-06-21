using System;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class ClsUserData
    {

        public static int AddNewUsers(int ClientAccountNumber, string UserName,
            string Password, int Permissons, bool IsActive)
        {

            int UserID = -1;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"INSERT INTO Users 
                            (ClientAccountNumber, UserName, Password, Permissons, IsActive)
                            VALUES 
                            (@ClientAccountNumber, @UserName, @Password, @Permissons, @IsActive);

                            SELECT SCOPE_IDENTITY();";
           
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@ClientAccountNumber", ClientAccountNumber);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissons", Permissons);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            
            try
            {
            
                connection.Open();
                object result = command.ExecuteScalar();
                
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Handle error
            
            }
            finally
            {
                connection.Close();
            }
            
            return UserID;
        
        }

        public static bool GetUsersByUserID(int UserID, ref int ClientAccountNumber,
            ref string UserName, ref string Password, ref int Permissons, ref bool IsActive)
        {

            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@UserID", UserID);
            
            try
            {
            
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                
                    isFound = true;
                    
                    ClientAccountNumber = (int)reader["ClientAccountNumber"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permissons = (int)reader["Permissons"];
                    IsActive = (bool)reader["IsActive"];
                
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
        public static bool GetUsersByUserName(ref int UserID, ref int ClientAccountNumber,
             string UserName, string Password, ref int Permissons, ref bool IsActive)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName And Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    UserID = (int)reader["UserID"];
                    ClientAccountNumber = (int)reader["ClientAccountNumber"];
                    Permissons = (int)reader["Permissons"];
                    IsActive = (bool)reader["IsActive"];

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
        public static bool UpdateUsers(int UserID, int ClientAccountNumber,
            string UserName, string Password, int Permissons, bool IsActive)
        {

            int rowsAffected = 0;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"UPDATE Users 
                             SET
                             ClientAccountNumber = @ClientAccountNumber,
                             UserName = @UserName,
                             Password = @Password,
                             Permissons = @Permissons,
                             IsActive = @IsActive

                             WHERE
                             UserID = @UserID";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ClientAccountNumber", ClientAccountNumber);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissons", Permissons);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            
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

        public static bool IsUsersExist(string Username)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found=1 FROM Users 
                                WHERE Username = @Username ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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
        public static bool IsUsersExist(int AccountNumber)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found=1 FROM Users 
                                WHERE ClientAccountNumber = @AccountNumber ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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
        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"SELECT Users.UserID,
                            dbo.Clients.FirstName + ' ' + ISNULL(dbo.Clients.SecondName, '') + ' ' + dbo.Clients.LastName AS PersonFullName,
                            Users.UserName, CASE WHEN Clients.Gender = 0 THEN 'Male' WHEN Clients.Gender = 1 THEN 'Female' END AS Gender,
                            Clients.Phone, Users.Permissons, 
                            CASE WHEN Users.IsActive = 0 THEN 'False' WHEN Users.IsActive = 1 THEN 'True' END AS IsActive
                            FROM     Users 
                            INNER JOIN
                            Clients 
                            ON Users.ClientAccountNumber = Clients.AccountNumber

				            Order by Users.UserID desc";


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
