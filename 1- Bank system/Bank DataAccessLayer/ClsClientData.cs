using System;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class ClsClientData
    {
        public static int AddNewClients(string PinCode, string FirstName, string SecondName, string LastName,
                    int Gender, string Phone, string Email, int CountryID, decimal Balance)
        {

            int AccountNumber = -1;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"INSERT INTO Clients (PinCode, FirstName,
                                    SecondName, LastName, Gender, Phone, Email, CountryID, Balance)
        
                            VALUES (@PinCode, @FirstName,
                                    @SecondName, @LastName, @Gender, @Phone, @Email, @CountryID, @Balance)
    
                            SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            if (SecondName != "" && SecondName != null)
                command.Parameters.AddWithValue("@SecondName", SecondName);
            else
                command.Parameters.AddWithValue("@SecondName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@Balance", Balance);
            
            try
            {
            
                connection.Open();
                object result = command.ExecuteScalar();
                
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AccountNumber = insertedID;
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

            return AccountNumber;
        
        }

        public static bool UpdateClients(
        int AccountNumber, string PinCode, string FirstName, string SecondName,
        string LastName, int Gender, string Phone, string Email, int CountryID, decimal Balance)
        {

            int rowsAffected = 0;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"UPDATE Clients 
                            SET
                            PinCode = @PinCode,
                            FirstName = @FirstName,
                            SecondName = @SecondName,
                            LastName = @LastName,
                            Gender = @Gender,
                            Phone = @Phone,
                            Email = @Email,
                            CountryID = @CountryID,
                            Balance = @Balance

                            WHERE
                            AccountNumber = @AccountNumber";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            if (SecondName != "" && SecondName != null)
                command.Parameters.AddWithValue("@SecondName", SecondName);
            else
                command.Parameters.AddWithValue("@SecondName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@Balance", Balance);
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

        public static bool GetClientsByAccountNumber(int AccountNumber, ref string PinCode,
            ref string FirstName, ref string SecondName, ref string LastName, ref int Gender,
            ref string Phone, ref string Email, ref int CountryID, ref decimal Balance)
        {

            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Clients WHERE AccountNumber = @AccountNumber";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            
            try
            {
            
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                
                    isFound = true;
                    
                    PinCode = (string)reader["PinCode"];
                    FirstName = (string)reader["FirstName"];

                    if (reader["SecondName"] != DBNull.Value)
                        SecondName = (string)reader["SecondName"];
                    else
                        SecondName = "";

                    LastName = (string)reader["LastName"];
                    Gender = (byte)reader["Gender"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    CountryID = (int)reader["CountryID"];
                    Balance = (decimal)reader["Balance"];
                
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

        public static DataTable GetAllClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"SELECT Clients.AccountNumber,
                             dbo.Clients.FirstName + ' ' + ISNULL(dbo.Clients.SecondName, '') + ' ' + dbo.Clients.LastName AS PersonFullName,
                            CASE WHEN Clients.Gender = 0 THEN 'Male' WHEN Clients.Gender = 1 THEN 'Female' END AS Gender,
                            Clients.Phone, Countries.CountryName, Clients.Balance
                            FROM     Clients
                            INNER JOIN
                            Countries
                            ON Clients.CountryID = Countries.CountryID
                            order by AccountNumber desc";


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
        public static bool DeleteClients(int AccountNumber)
        {

            int rowsAffected = 0;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"DELETE FROM Clients WHERE AccountNumber = @AccountNumber";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            
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
        public static decimal TotalBalance()
        {

            decimal TotalBalance = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"Select Sum(Clients.Balance) From Clients;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal insertedID))
                {
                    TotalBalance = insertedID;
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

            return TotalBalance;

        }
        public static bool DepositOrWithdrawBalance(int AccountNumber, decimal Balance, bool deposit)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = "";

            if (deposit)
            {
                 query = @"Update Clients
                             set
                             Balance += @Balance
                             where 
                             Clients.AccountNumber = @AccountNumber";
            }
            else
            {
                query = @"Update Clients
                             set
                             Balance -= @Balance
                             where 
                             Clients.AccountNumber = @AccountNumber";
            }

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }
        public static bool TransferBalance(int SourseAccountNumber, int DestinationAccountNumber, decimal Amount)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"Update Clients
                            Set Balance -= @Amount
                            where Clients.AccountNumber = @SourseAccountNumber

                            Update Clients
                            Set Balance += @Amount
                            where Clients.AccountNumber = @DestinationAccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@SourseAccountNumber", SourseAccountNumber);
            command.Parameters.AddWithValue("@DestinationAccountNumber", DestinationAccountNumber);

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

            return rowsAffected == 2;

        }

    }
}
