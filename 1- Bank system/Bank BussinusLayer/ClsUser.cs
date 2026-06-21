using System;
using System.Data;
using Bank_DataAccessLayer;

public class ClsUser
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int UserID { get; set; }
    public int ClientAccountNumber { get; set; }

    public ClsClient ClientInfo;
    public string UserName { get; set; }
    public string Password { get; set; }
    public int Permissons { get; set; }
    public bool IsActive { get; set; }
    public ClsUser()
    {

        this.UserID = -1;
        this.UserName = "";
        this.Password = "";
        this.Permissons = 0;

        this.IsActive = true;
        
        Mode = enMode.AddNew;
    
    }

    private ClsUser(int UserID, int ClientAccountNumber, string UserName,
        string Password, int Permissons, bool IsActive)
    {

        this.UserID = UserID;
        this.ClientAccountNumber = ClientAccountNumber;
        this.UserName = UserName;
        this.Password = Password;
        this.Permissons = Permissons;
        this.IsActive = IsActive;

        this.ClientInfo = ClsClient.FindByAccountNumber(ClientAccountNumber);

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

        this.UserID = ClsUserData.AddNewUsers(this.ClientAccountNumber,
            this.UserName, this.Password, this.Permissons, this.IsActive);

        return this.UserID != -1;
    }
    private bool _Update()
    {

        return ClsUserData.UpdateUsers(this.UserID, this.ClientAccountNumber,
            this.UserName, this.Password, this.Permissons, this.IsActive);
    }
    public static ClsUser FindByUserID(int UserID)
    {

        int ClientAccountNumber = -1;
        string UserName = "";
        string Password = "";
        int Permissons = 0;
        bool IsActive = true;

        bool IsFound = ClsUserData.GetUsersByUserID(UserID, ref ClientAccountNumber,
            ref UserName, ref Password, ref Permissons, ref IsActive);

        if (IsFound)
            return new ClsUser(UserID, ClientAccountNumber, UserName,
                Password, Permissons, IsActive);

        else
            return null;

    }
    public static ClsUser FindByUserNameAndPassword(string UserName, string Password)
    {

        int UserID = -1;
        int ClientAccountNumber = -1;
        int Permissons = 0;
        bool IsActive = true;

        bool IsFound = ClsUserData.GetUsersByUserName(ref UserID, ref ClientAccountNumber,
            UserName, Password, ref Permissons, ref IsActive);

        if (IsFound)
            return new ClsUser(UserID, ClientAccountNumber, UserName,
                Password, Permissons, IsActive);

        else
            return null;

    }
    public static DataTable GetAllUsers()
    {

        return ClsUserData.GetAllUsers();
    }
    public static bool IsUserExist(string UserName)
    {

        return ClsUserData.IsUsersExist(UserName);
    }
    public static bool AccountNumberIsUser(int AccountNumber)
    {

        return ClsUserData.IsUsersExist(AccountNumber);
    }
    public bool AddNewLogin()
    {

        int LoginUserID = -1;

        LoginUserID = ClsLoginUsersData.AddNewLoginUsers(this.UserID);
        return LoginUserID != -1;
    }
    public static DataTable GetAllLoginUsers()
    {

        return ClsLoginUsersData.GetAllLoginUsers();
    }

}