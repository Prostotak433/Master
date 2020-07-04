using System;

namespace Class.Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine(employee.GetBenefitCost());
            BenefitPackage benefitPackage = new BenefitPackage();
            benefitPackage.setValue(100);
            Console.WriteLine(employee.Benefits.ComputerPayReduction());
            employee.Benefits = benefitPackage;
            Console.WriteLine(employee.Benefits.ComputerPayReduction());
            Console.ReadLine();
        }
    }
    class BenefitPackage
    {
        private double value = 125.0;
        public void setValue(double value)
        {
            this.value = value;
        }
        public double ComputerPayReduction()
        {
            return value;
        }
    }
    class Employee
    {
        protected BenefitPackage empBenefist = new BenefitPackage();
        public double GetBenefitCost()
        {
            return empBenefist.ComputerPayReduction();
        }
        public BenefitPackage Benefits
        {
            get { return empBenefist; }
            set { empBenefist = value; }
        }
    }
}