using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    //is a type, thus capital first letter
    class Employee
    {
        // Backing Fields
        private string firstName;
        private string lastName;
        private decimal weeklySalary;

        // these are getters and setters
        // properties for the backing fields
        public string Firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //anything that is public should have a capital letter
        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        // One Methods
        // can be either public or private
        public string GetFullName()
        {
            // this.__ refers to the class we are currently in
            // then we can call variables within this class rather than typing them out again and again
            //this one is public and can be accessed by other classes
            string firstName = "Foo";
            return this.firstName + " " + this.lastName;
        }

        // this is to override the default method
        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.weeklySalary.ToString("C");
        }

        // is a Private method
        private string foo()
        {
            return "Foo";
        }

        //3 Parameter Constructor
        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            //Assign the 'passed by value' to the fields
            this.firstName = firstName;
            this.lastName = lastName;
            
            //Assign the 'passed by value' by the property
            this.weeklySalary = weeklySalary;
        }

        //Default constructor
        public Employee()
        {
            //Lets just leave this blank

        }

    }
}
