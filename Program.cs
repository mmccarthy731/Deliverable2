using System;

namespace PreWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOne, dateTwo;

            // Prompt user to enter a date in specified format
            Console.WriteLine("Please enter a date in the format of MM/DD/YYYY:");
            string inputOne = Console.ReadLine();

            // Ensure that date was entered in the correct format
            while(!DateTime.TryParse(inputOne, out dateOne))
            {
                Console.WriteLine("Invalid input: Date was not in the correct format\r\nPlease enter a date in the format of MM/DD/YYYY:");
                inputOne = Console.ReadLine();
            }

            // Prompt user to enter a second date
            Console.WriteLine("Please enter a second date in the fomat of MM/DD/YYYY:");
            string inputTwo = Console.ReadLine();

            // Ensure second date was entered in the correct format
            while(!DateTime.TryParse(inputTwo, out dateTwo))
            {
                Console.WriteLine("Invalid input: Date was not in the correct format\r\nPlease enter a second date in the format of MM/DD/YYYY:");
                inputTwo = Console.ReadLine();
            }

            // Calculate difference in dates using TimeSpan
            TimeSpan difference = dateTwo - dateOne;
            double days = Math.Abs(difference.TotalDays);
            double hours = Math.Abs(difference.TotalHours);
            double minutes = Math.Abs(difference.TotalMinutes);

            Console.WriteLine("The difference between the dates is:\r\n{0} days\r\n{1} hours\r\n{2} minutes", days, hours, minutes);
            Console.ReadLine();
        }
    }
}

