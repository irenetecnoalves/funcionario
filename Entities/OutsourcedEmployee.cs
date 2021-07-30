namespace Funcionario.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalChance { get; set; }

        public OutsourcedEmployee(){}

        public OutsourcedEmployee(string name,int hours,double valueHour,double additionalChance): base(name,hours,valueHour)
        { AdditionalChance = additionalChance; } 

        public override double Payment()
        {
            return base.Payment() +1.1 * AdditionalChance;
        }
        
}
}