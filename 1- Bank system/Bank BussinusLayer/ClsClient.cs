using System;
using System.Data;
using Bank_DataAccessLayer;

public class ClsClient
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int AccountNumber { get; set; }
    public string PinCode { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string LastName { get; set; }
    public int Gender { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int CountryID { get; set; }

    public ClsCountry CountryInfo;
    public decimal Balance { get; set; }
    public ClsClient()
    {

        this.AccountNumber = -1;
        this.CountryID = -1;
        this.Balance = 0;

        this.PinCode = "";
        this.FirstName = "";
        this.SecondName = "";
        this.LastName = "";
        this.Phone = "";
        this.Email = "";

        Mode = enMode.AddNew;

    }

    private ClsClient(int AccountNumber, string PinCode,
        string FirstName, string SecondName, string LastName,
        int Gender, string Phone, string Email, int CountryID, decimal Balance)
    {

        this.AccountNumber = AccountNumber;
        this.PinCode = PinCode;
        this.FirstName = FirstName;
        this.SecondName = SecondName;
        this.LastName = LastName;
        this.Gender = Gender;
        this.Phone = Phone;
        this.Email = Email;
        this.CountryID = CountryID;
        this.Balance = Balance;

        this.CountryInfo = ClsCountry.FindByCountryID(CountryID);
        
        Mode = enMode.Update;
    
    }

    public bool Save()
    {

        switch (Mode)
        {
            case enMode.AddNew:

                if (_AddNew())
                {
                    Mode = enMode.Update;

                    return true;
                }
                else return false;

            case enMode.Update:

                return _Update();
        }

        return false;

    }
    private bool _AddNew()
    {

        this.AccountNumber = ClsClientData.AddNewClients(this.PinCode, this.FirstName,
            this.SecondName, this.LastName, this.Gender, this.Phone, this.Email, this.CountryID, this.Balance);
        
        return this.AccountNumber != -1;
    }
    private bool _Update()
    {

        return ClsClientData.UpdateClients(this.AccountNumber, this.PinCode,
            this.FirstName, this.SecondName, this.LastName, this.Gender,
            this.Phone, this.Email, this.CountryID, this.Balance);
    }
    public static ClsClient FindByAccountNumber(int AccountNumber)
    {

        string PinCode = "";
        string FirstName = "";
        string SecondName = "";
        string LastName = "";
        int Gender = 0;
        string Phone = "";
        string Email = "";
        int CountryID = -1;
        decimal Balance = 0;

        bool IsFound = ClsClientData.GetClientsByAccountNumber(AccountNumber, ref PinCode,
            ref FirstName, ref SecondName, ref LastName, ref Gender, ref Phone, ref Email, ref CountryID, ref Balance);
         
        if (IsFound)
            return new ClsClient(AccountNumber, PinCode, FirstName, SecondName,
                LastName, Gender, Phone, Email, CountryID, Balance);

        else
            return null;

    }
    public static DataTable GetAllClsClients()
    {

        return ClsClientData.GetAllClients();
    }
    public bool DeleteClsClient()
    {

        return ClsClientData.DeleteClients(this.AccountNumber);
    }
    public static decimal GetTotalBalance()
    {

        return ClsClientData.TotalBalance();
    }
    public bool DepositOrWithdrawBalance(decimal Amount, bool IsDeposit)
    {

        return ClsClientData.DepositOrWithdrawBalance(this.AccountNumber, Amount, IsDeposit);
    }
    public bool TransferBalanceTo(int DestinationAccountNumber, decimal Amount)
    {

        return ClsClientData.TransferBalance(this.AccountNumber, DestinationAccountNumber, Amount);
    }
    public static DataTable GetAllTransferLogin()
    {

        return ClstransferLogData.GetAllTransferLogin();
    }
    public bool AddNewTransferLog(int DestinationAccountNumber,int OperationType,
        decimal Amount, int CreatedByUserID)
    {

        int TransferLogID = -1;
        TransferLogID = ClstransferLogData.AddNewTransferLog(this.AccountNumber, DestinationAccountNumber,
            OperationType, Amount, CreatedByUserID);

        return TransferLogID != -1;

    }

}