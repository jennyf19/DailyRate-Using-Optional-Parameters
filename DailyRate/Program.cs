using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            //double fee = CalculateFee(4500, 3);
            double fee = CalculateFee(noOfDays: 5);
            Console.WriteLine($"Fee is {fee}");
            Console.ReadLine();
        }

        private double CalculateFee(double dailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("CalculateFee using two optional parameters");
            return dailyRate * noOfDays;
        }

        private double CalculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("CalculateFee using one optional parameter");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        private double CalculateFee()
        {
            Console.WriteLine("CalculateFee using hardcoded values");
            double defaultDailyRate = 400.0;
            int defaultNoOfdays = 1;
            return defaultDailyRate * defaultNoOfdays;
        }
    }
}
