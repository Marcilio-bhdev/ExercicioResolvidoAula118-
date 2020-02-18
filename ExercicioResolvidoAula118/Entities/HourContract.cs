using System;


namespace ExercicioResolvidoAula118.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours) //criei um construtor com parametro
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() //Aqui criei um metodo que me permite multiplicar as horas pelo valor por hora
        {
            return ValuePerHour * Hours;
        
        }
    }
}
