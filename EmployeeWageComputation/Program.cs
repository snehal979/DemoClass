namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome the Employee Wage Computation program");
            //UC1 employee attaindance
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHour = 0;
            int empRatePerHour = 20;
            Random random = new Random();
            int empAttaindance = random.Next(0,3); //0 or 1
           switch(empAttaindance)
           {
                case FULL_TIME:
                    Console.WriteLine("Employee is Full Time Present");
                    empHour = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Employee is Present Part_Time");
                    empHour = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
           }
            int dailyWage = empHour * empRatePerHour;
            Console.WriteLine("Daily Wage for employee is "+dailyWage);
            Console.ReadLine();
        }
           
    }
} 