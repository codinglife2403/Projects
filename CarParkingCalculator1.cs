using System;

namespace ConsoleApp4
{
    class CarParkingCalculator1
    {
        static void Main(string[] args)
        {
            Employee employeeSalary = new Employee();
            Engineer engineerSalary = new Engineer();
            Analyst analystSalary = new Analyst();
            Manager managerSalary = new Manager();
            Console.WriteLine("Enter your designation:");
            string desig = Console.ReadLine();
            Console.WriteLine("Your gross salary=");
            if (desig == employeeSalary.designation)
            {
                employeeSalary.CalculateSalary();
            }
            if (desig == engineerSalary.designation)
            {
                engineerSalary.CalculateSalary();
            }
            if (desig == managerSalary.designation)
            {
                managerSalary.CalculateSalary();
            }
            if (desig == analystSalary.designation)
            {
                analystSalary.CalculateSalary();
            }

        }
        class SalarySlip
        {
            public string designation;
            public int fuelCost;
            public int medicalAllowance;
            protected static int baseSalary = 1500;
            public void CalculateSalary()
            {

            }
        }
        class Employee : SalarySlip
        {
            public string designation = "Employee";
            public void CalculateSalary()
            {
                int salary = 0; ;
                salary = baseSalary;
                Console.WriteLine(salary);
            }
        }
        class Engineer : SalarySlip
        {
            public string designation = "Engineer";
            static int fuelCost = 100;
            static int medicalAllowance =500;
            public void CalculateSalary()
            {
                int salary = 0; ;
                salary = baseSalary + fuelCost + medicalAllowance;
                Console.WriteLine(salary);
            }
        }
        class Analyst : SalarySlip
        {
            public string designation = "Analyst";
            static int fuelCost = 150;
            static int medicalAllowance = 800;
            public void CalculateSalary()
            {
                int salary=0;
                salary = baseSalary + fuelCost + medicalAllowance;
                Console.WriteLine(salary);
            }
        }
                    class Manager : SalarySlip
                    {
                        public string designation = "Manager";
                        public int fuelCost = 250;
                        public int medicalAllowance = 1000;
                        public void CalculateSalary()
                        {
                            int salary=0;
                            salary = baseSalary + fuelCost + medicalAllowance;
                            Console.WriteLine(salary);
                        }

                    }

                }
            }
       