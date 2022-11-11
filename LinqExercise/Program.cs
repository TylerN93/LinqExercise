using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine($"The sum is {numbers.Sum()}");

            //TODO: Print the Average of numbers

            Console.WriteLine($" The average is {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console

            var asc = numbers.OrderBy(num => num);

            Console.WriteLine($"Ascending:");

            foreach (var item in asc)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("-----------");

            //TODO: Order numbers in decsending order and print to the console
            var desc = numbers.OrderByDescending(num => num);

            Console.WriteLine($"Descending:");


            foreach (var item in desc)
            {
                Console.WriteLine($"{item}");
            }

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine($"Greater than 6:");

            var greater = numbers.Where(num => num > 6);

            foreach(var item in greater)
            {
                Console.WriteLine($"{item}");
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Take 4");

            foreach (var num in asc.Take(4))
            {
                Console.WriteLine($"{num}");
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            numbers[4] = 29;

            Console.WriteLine($"-------");

            foreach (var item in numbers.OrderByDescending(num=> num))
            {
                Console.WriteLine($"{item}");
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            
            var filtered = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName);

            Console.WriteLine(" C or S employees");

            foreach (var item in filtered)
            {
                Console.WriteLine($"{item.FullName}");
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("--------");
            Console.WriteLine("Over 26");

            var overTwentySix = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);

            foreach(var item in overTwentySix)
            {
                Console.WriteLine($"{item.FullName} {item.Age}");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("--------");

            var years = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            var sum = years.Sum(x => x.YearsOfExperience);

            var avg = years.Average(x => x.YearsOfExperience);

            Console.WriteLine($" Sum: {sum} Average: {avg}");

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Tyler", "Newton", 29, 1)).ToList();

            foreach (var item in employees)
            {
                Console.WriteLine($" {item.FirstName}, {item.Age}");
            }


            Console.WriteLine();

            Console.ReadLine();
            {}
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
