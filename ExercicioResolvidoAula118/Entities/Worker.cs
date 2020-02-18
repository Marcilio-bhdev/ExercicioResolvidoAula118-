using System;
using ExercicioResolvidoAula118.Entities.Enums;

namespace ExercicioResolvidoAula118.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel  Level { get; set; }//esta propriedade e exclusiva criada da classe "enums"
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }//aqui criei uma Associação de classes (composição de objetos) chamando o objeto Departament no objeto Worker
    }
}
