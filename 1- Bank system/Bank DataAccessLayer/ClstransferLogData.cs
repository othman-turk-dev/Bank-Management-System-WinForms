using System;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class ClstransferLogData
    {

        public static int AddNewTransferLog(int SourseAccountNumber, int DestinationAccountNumber,
            int OperationType, decimal Amount, int CreatedByUserID)
        {

            int TransferLogID = -1;
            
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"INSERT INTO TransferLog 
                            (SourseAccountNumber, DestinationAccountNumber,
                            OperationType, Amount, TransferDate, CreatedByUserID)

                            VALUES 
                            (@SourseAccountNumber, @DestinationAccountNumber,
                            @OperationType, @Amount, @TransferDate, @CreatedByUserID);

                            SELECT SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@SourseAccountNumber", SourseAccountNumber);
            command.Parameters.AddWithValue("@DestinationAccountNumber", DestinationAccountNumber);
            command.Parameters.AddWithValue("@OperationType", OperationType);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TransferDate", DateTime.Now);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
            try
            {
                
                connection.Open();
                object result = command.ExecuteScalar();
                
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TransferLogID = insertedID;
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

            return TransferLogID;
        
        }

        public static DataTable GetAllTransferLogin()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"SELECT TransferLog.TransferLogID,
                            TransferLog.SourseAccountNumber, TransferLog.DestinationAccountNumber,
                            CASE WHEN TransferLog.OperationType = 0 THEN 'Deposit' WHEN TransferLog.OperationType = 1 THEN 'Withdraw' END AS OperationType,
                            TransferLog.Amount, TransferLog.TransferDate, Users.UserName
                            FROM     Users 
                            INNER JOIN
                            TransferLog 
                            ON Users.UserID = TransferLog.CreatedByUserID
                            
                            Order by TransferLog.TransferLogID Desc";


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
