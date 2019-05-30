using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TodoApi.Models
{
    public class Customer
    {
        [Key]
        public int CustomerKey { get; set; }
        public int GeographyKey { get; set; }
        public int CustomerAlternateKey { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameStyle { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Suffix { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public decimal YearlyIncome { get; set; }

        public int TotalChildren { get; set; }

        public int NumberChildrenAtHome { get; set; }

        public string EnglishEducation { get; set; }
        public string SpanishEducation { get; set; }
        public string FrenchEducation { get; set; }
        public string EnglishOccupation { get; set; }
        public string SpanishOccupation { get; set; }
        public string FrenchOccupation { get; set; }
        public char HouseOwnerFlag { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}