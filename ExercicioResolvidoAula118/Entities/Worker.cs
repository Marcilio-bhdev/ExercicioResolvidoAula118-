using System;
using System.Collections.Generic;
using ExercicioResolvidoAula118.Entities.Enums;

namespace ExercicioResolvidoAula118.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel  Level { get; set; }//esta propriedade e exclusiva criada da classe "enums"
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }//aqui criei uma Associação de classes (composição de objetos) chamando o objeto Departament no objeto Worker
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        /*Aqui foi criado uma lista como propriedade associando a classe contratos a classe worker*/

        public Worker() 
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)// criei este construtor sem a lista
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract) /*Aqui criei um metodo para adicionar contratos pegando por referencia a variável contract*/
        {
            Contracts.Add(contract);//aqui coloquei a variavel contract como referencia
            
        
        }
        public void RemoveContract(HourContract contract)
        {

            Contracts.Remove(contract);
        
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) //aqui usei um foreach para percorrer todos os contratos
            {
                if (contract.Date.Year == year && contract.Date.Month == month)//aqui determinei que se ele os contratos estiveram com mesmo mes e ano que os registrados na lista
                {
                    sum += contract.TotalValue();
                
                }
            }
            return sum;
        }
    }

}
