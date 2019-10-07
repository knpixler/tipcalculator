using System;
using System.Threading;

namespace TipCalculator
{
    class DoMath
    {
        MenuOptions goBack = new MenuOptions();

        public void SplitCheck()
        {
            Console.Clear();

            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Split Check"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "~~~~~~~~~~~"));
            Console.WriteLine("How many people are splitting the check?");
            int numInParty = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the total bill");
            double totalBill = double.Parse(Console.ReadLine());
            double splitAmount = totalBill / numInParty;
            Console.WriteLine($"The total split per person is {splitAmount}");
            Thread.Sleep(1000);
            goBack.Menu();
        }

        public void CalcTip()
        {
            Console.Clear();

            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Calculate Tip"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "~~~~~~~~~~~~~"));
            Console.WriteLine("What is the total bill (before tax)");
            double totalBill = double.Parse(Console.ReadLine());
            Console.WriteLine("What percent do you want to tip?");
            double tipPercent = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the tax amount on the bill?");
            double taxAmount = double.Parse(Console.ReadLine());
            double tipAmount = totalBill * (tipPercent / 100);
            double newBill = tipAmount + taxAmount + totalBill;
            Console.WriteLine($"The tip amount is {tipAmount} and your new total is {newBill}");
            Thread.Sleep(3000);
            goBack.Menu();
        }

        public void Exit()
        {
            string greeting = "";
            int timeCheck = DateTime.Now.Hour;
            if (timeCheck > 17)
            {
                greeting = "evening";
            }
            else if (timeCheck > 12)
            {
                greeting = "afternoon";
            }
            else
            {
                greeting = "morning";
            }
            Console.WriteLine($"Thank you for dining with us! Have a good {greeting}!");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
