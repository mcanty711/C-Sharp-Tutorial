using System;
using System.Collections.Generic;

namespace DictionaryOverList
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Camberra" };
            Country country2 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "United Kingdom", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);

            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter counry code: ");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;
                
                if (resultCountry == null)
                {
                    Console.WriteLine("Invalid Country code entered. Please try again.");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue? YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper(); 
                } while (strUserChoice != "YES" && strUserChoice != "NO");
            } 
            while (strUserChoice == "YES");
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
