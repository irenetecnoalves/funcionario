namespace Funcionario.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValueHour { get; set; }
        
        public Employee(){}

        public Employee(string name,int hours, double valueHour)
        {
            Name = name;
            Hours = hours;
            ValueHour = valueHour;
        }

        public virtual double Payment()
        {
            return Hours * ValueHour;
        }

    }
}