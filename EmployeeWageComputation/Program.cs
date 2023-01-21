namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome the Employee Wage Computation program");
            //UC1 employee attaindance
            int isPresent = 1;
            int fullTimeHour = 0;
            int empRatePerHour = 20;
            Random random = new Random();
            int empAttaindance = random.Next(0,2); //0 or 1
            if(empAttaindance == isPresent)
            {
                Console.WriteLine("Employee is Present");
                fullTimeHour = 8;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            int dailyWage = fullTimeHour*empRatePerHour;
            Console.WriteLine("Daily Wage for employee is "+dailyWage);
            Console.ReadLine();
        }
           
    }
} 