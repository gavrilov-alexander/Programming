using ProgrammingAppInformationSystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingAppInformationSystem.Model.Classes
{
    public class Organization
    {
        private string _name;
        private string _address;
        private string _category;
        private double _rating;
        public string Name
        {
            get { return _name; }
            set
            {
                int min = 1;
                int max = 200;
                Validator.AssertValueLengthInRange(value, min, max);
                _name = value;
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                int min = 1;
                int max = 100;
                Validator.AssertValueLengthInRange(value, min, max);
                _address = value;
            }
        }
        public string Category
        {
            get { return _category; }
            set
            {
                Validator.AssertValueInCategoryEnum(value);
                _category = value;
            }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                double min = 0;
                double max = 5;
                Validator.AssertValueInRange(value, min, max);
                _rating = value;
            }
        }
        public string Info => $"{Category} - {Name}";
        public static int Compare(Organization organization1, Organization organization2)
        {
            if (String.Compare(organization1.Category, organization2.Category) == 0)
            {
                return String.Compare(organization1.Name, organization2.Name);
            }
            else
            {
                return String.Compare(organization1.Category, organization2.Category);
            }
        }
        public Organization()
        {
        }
        public Organization(string name, string address, string category, double rating)
        {
            Name = name;
            Address = address;
            Category = category;
            Rating = rating;
        }
        public Organization(Organization organization)
        {
            Name = organization.Name;
            Address = organization.Address;
            Category = organization.Category;
            Rating = organization.Rating;
        }
    }
}
