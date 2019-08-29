using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApplication.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }

        public enum Gender
        {
            Male,
            Female
        }
        public Gender MyGender { get; set; }

        public Address Residence { get; set; }

    }

    public class Address
    {
        public int PropertyNo { get; set; }
        public string HouseName { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }

    }
}