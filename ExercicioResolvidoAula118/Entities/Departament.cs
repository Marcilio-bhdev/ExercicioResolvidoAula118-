

namespace ExercicioResolvidoAula118.Entities
{
    class Departament
    {
        public string Name { get; set; } // aqui são as propriedades da classe

        public Departament() // aqui foi criado um construtor padrão 
        {
        
        }

        public Departament(string name) //Aqui foi criado um construtor passando uma variável de parametro
        {
            Name = name; // aqui a variavel da propriedade vai receber o que foi digitado na variável de parâmetro
        }
    }
}
