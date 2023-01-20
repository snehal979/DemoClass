namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome the Employee Wage Computation program");
            //UC1 employee attaindance
            int isPresent = 1;
            Random random = new Random();
            int empAttaindance = random.Next(0,2); //0 or 1
            if(empAttaindance == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
           
    }
}