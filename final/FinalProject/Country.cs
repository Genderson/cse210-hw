using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Country
    {
        private int _code;
        private string _name;
        private double _tax;

        public Country(){}
        public Country(int code, string name, double tax)
        {
            _code = code;
            _name = name;
            _tax = tax;
        }

        public double GetTax() => _tax;
        public int GetCode() => _code;
        public string GetName() => _name;
        public string Display() => $"Code: {_code} - City: {_name}";
    }
}