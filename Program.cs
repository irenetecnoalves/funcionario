using System;
using System.Collections.Generic;
using Funcionario.Entities;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            
            Console.Write("Enter the number of Employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                Char ch = Char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hours: ");
                double valueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(ch =='y')
                {
                    
                    Console.Write("Additional Charge:");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name,hours,valueHour,additionalCharge));

                }else
                { list.Add(new Employee(name,hours,valueHour));}

            }

                  Console.WriteLine();
                  Console.WriteLine("Payments: ");
                  foreach (Employee emp in list)
                  {
                      Console.WriteLine(emp.Name + " - R$ "+ emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
                  }

        }

       
    }
}
