using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating some examples of employees
            Employee employee1 = new Employee("paul", "bath", 452.01m);
            Employee employee2 = new Employee("mike", "jones", 281.330m);

            //for use in the changeAn__ parts
            //creast a simple in that will be se foor the value Vs. reference
            int mynumber = 5;

            //Write the value of the int before the method,
            // call the method,
            // print after call
            Console.WriteLine(mynumber);
            changeAnInt(mynumber);
            Console.WriteLine(mynumber);

            //Write the value of the employee before the method,
            // call the method,
            // print after call
            // not used anymore? Console.WriteLine( employee.GetFullName());
            Console.WriteLine(employee1.ToString());
            changeAnObject(employee1);
            Console.WriteLine(employee1.ToString());


            //Showing how to use an arrary with objects
            Employee[] employees = new Employee[10];

            //Instantiate some employees
            employees[0] = new Employee("wellp", "wellp", 3353m);
            employees[1] = new Employee("wellp", "wellp", 335m);
            employees[2] = new Employee("wellp", "wellp", 3778m);
            employees[3] = new Employee("wellp", "wellp", 3533m);
            employees[4] = new Employee("wellp", "wellp", 3353m);
            

            //A for each loop that will loop the through each element of the employeees array
            foreach (Employee employee in employees)
            {
                //Chekc to make sure that the current object is not null
                // we know that the firt 5 have values be cause we assigned them above
                // but the last 5 are null so we better put in a check
                if (employee != null)
                {
                    //output the information of the employee
                    Console.WriteLine(employee.ToString());
                }
            }




        }

        //this method takes in an integer, which is pased by value then 
        //and then changes the value of it
        static void changeAnInt(int myNumber)
        {
            myNumber = 458;            
        }

        //this method takes in and Employee class, which is passed by reference
        // and then changes the property of it.
        //class is inherently passed by reference
        static void changeAnObject(Employee employee)
        {
            employee.Firstname = "Thor";
        }
    }
}
