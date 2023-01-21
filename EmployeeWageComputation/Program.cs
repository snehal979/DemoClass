namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome the Employee Wage Computation program");
            //UC1 employee attaindance
            int fullTime_isPresent = 1;
            int partTime_isPresent = 2;
            int empHour = 0;
            int empRatePerHour = 20;
            Random random = new Random();
            int empAttaindance = random.Next(0,3); //0 or 1
            if(empAttaindance == fullTime_isPresent)
            {
                Console.WriteLine("Employee is Full Time Present");
                empHour = 8;

            } else if (empAttaindance == partTime_isPresent)
            {
                Console.WriteLine("Employee is Present Part_Time");
                empHour = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            int dailyWage = empHour * empRatePerHour;
            Console.WriteLine("Daily Wage for employee is "+dailyWage);
            Console.ReadLine();
        }
           
    }
} 