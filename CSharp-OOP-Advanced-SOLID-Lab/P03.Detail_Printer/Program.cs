using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            List<string> documents = new List<string>();
            documents.Add("kuche");
            documents.Add("kotka");

            Manager manager = new Manager("Pesho", documents);
            employees.Add(manager);

            Employee employee = new Employee("Gosho");
            employees.Add(employee);

            DetailsPrinter detailPrinter = new DetailsPrinter(employees);

            detailPrinter.PrintDetails();
        }
    }
}
