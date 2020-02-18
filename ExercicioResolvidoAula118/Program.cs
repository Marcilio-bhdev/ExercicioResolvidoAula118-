using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioResolvidoAula118.Entities;
using ExercicioResolvidoAula118.Entities.Enums;

namespace ExercicioResolvidoAula118
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's Name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker Date: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (0- Junior/1 -Midlevel/2 - Senior): ");
            string enumValor = Console.ReadLine();
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), enumValor);// Aqui eu fiz uma conversão do tipo WorkLevel para string
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Aqui logo abaixo eu instanciei os dois objetos relacionados a classe Worker
            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this Worker?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hour): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hour);// aqui fiz a intanciação da classe contrato
                worker.AddContract(contract);//aqui eu adicionei os contratos por trabalhador

            }
            Console.WriteLine();
            Console.Write("Enter month and year to alculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));//Aqui Usei o substring para recortar o mes
            int year = int.Parse(monthAndYear.Substring(3));//Aqui Usei o substring para recortar o ano
            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for"+month+year+": "+ worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));








        }
    }
}
