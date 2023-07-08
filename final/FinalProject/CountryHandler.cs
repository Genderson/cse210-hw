using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CountryHandler
    {
        private readonly List<Country> _countries = new List<Country>();

        public CountryHandler()
        {
            PopulateCountries();
        }
        private void PopulateCountries()
        {
            _countries.AddRange(new Country[] 
            { 
                new Country(1, "Dallas", 2), 
                new Country(2, "Houston", 1.5),
                new Country(3, "Las Vegas", 2.3), 
                new Country(4, "Los Angeles", 1.8), 
                new Country(5, "Nashville", 3.2), 
                new Country(6, "New York City", 4.3), 
                new Country(7, "New Orleans", 1.9), 
                new Country(8, "San Francisco", 5), 
                new Country(9, "Seattle", 4), 
                new Country(10, "Austin", 3), 
            });
        }

        public Country GetCountry(int code)
        {
            foreach (var country in _countries)
            {
                if (country.GetCode() == code)
                return country;
            }

            return null;
        }

        public void DisplayCountries()
        {
            foreach (var country in _countries)
            {
                Console.WriteLine(country.Display());
            }
        }
    }
}