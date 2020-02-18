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




        }
    }
}
