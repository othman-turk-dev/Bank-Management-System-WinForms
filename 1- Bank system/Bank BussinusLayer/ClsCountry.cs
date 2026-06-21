using System;
using System.Data;
using Bank_DataAccessLayer;

public class ClsCountry
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int CountryID { get; set; }
    public string CountryName { get; set; }
    public string Code { get; set; }
    public string Currency { get; set; }
    public decimal Rate { get; set; }
    public ClsCountry()
    {

        this.CountryID = -1;
        this.CountryName = "";
        this.Code = "";
        this.Currency = "";
        this.Rate = 0;

        Mode = enMode.AddNew;
    
    }
    private ClsCountry(int CountryID, string CountryName, string Code, 
        string Currency, decimal Rate)
    {

        this.CountryID = CountryID;
        this.CountryName = CountryName;
        this.Code = Code;
        this.Currency = Currency;
        this.Rate = Rate;
        
        Mode = enMode.Update;
    
    }
    public bool UpdateRateByCountryCode(decimal NewRate)
    {
        
        return ClsCountryData.UpdateRateCountriesByCountryCode(this.Code, NewRate);
    }
    public static ClsCountry FindByCountryID(int CountryID)
    {

        string CountryName = "";
        string Code = "";
        string Currency = "";
        decimal Rate = 0;

        bool IsFound = ClsCountryData.GetCountriesByCountryID(CountryID, ref CountryName,
            ref Code, ref Currency, ref Rate);

        if (IsFound)
            return new ClsCountry(CountryID, CountryName,
                Code, Currency, Rate);

        else
            return null;

    }
    public static ClsCountry FindByCountryName(string CountryName)
    {

        int CountryID = -1;
        string Code = "";
        string Currency = "";
        decimal Rate = 0;

        bool IsFound = ClsCountryData.GetCountriesByCountryName(ref CountryID, CountryName,
            ref Code, ref Currency, ref Rate);

        if (IsFound)
            return new ClsCountry(CountryID, CountryName,
                Code, Currency, Rate);

        else
            return null;

    }
    public static ClsCountry FindByCountryCode(string Code)
    {

        int CountryID = -1;
        string CountryName = "";
        string Currency = "";
        decimal Rate = 0;

        bool IsFound = ClsCountryData.GetCountriesByCountryCode(ref CountryID,ref CountryName,
             Code, ref Currency, ref Rate);

        if (IsFound)
            return new ClsCountry(CountryID, CountryName,
                Code, Currency, Rate);

        else
            return null;

    }
    public static DataTable GetAllCountries()
    {

        return ClsCountryData.GetAllCountries();
    }
    public static DataTable GetAllCountryCode()
    {

        return ClsCountryData.GetAllCountryCode();
    }

}