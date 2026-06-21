using System;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class ClsLoginUsersData
    {

        public static int AddNewLoginUsers(int UserID)
        {

            int LoginUserID = -1;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"INSERT INTO LoginUsers 
                            (UserID, LoginDate)
                            VALUES
                            (@UserID, @LoginDate);

                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@LoginDate", DateTime.Now);

            try
            {
            
                connection.Open();
                object result = command.ExecuteScalar();
                
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LoginUserID = insertedID;
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
            
            return LoginUserID;
        
        }
        public static DataTable GetAllLoginUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"SELECT LoginUsers.LoginUserID,
                            LoginUsers.UserID, Users.UserName, Clients.Phone,
                            Users.Permissons, LoginUsers.LoginDate
                            FROM     LoginUsers INNER JOIN
                            Users
                            ON LoginUsers.UserID = Users.UserID INNER JOIN
                            Clients
                            ON Users.ClientAccountNumber = Clients.AccountNumber

				            Order by LoginUsers.LoginUserID Desc";


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
