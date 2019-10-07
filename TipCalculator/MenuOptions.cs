using System;

namespace TipCalculator
{
    class MenuOptions
    {
        public void Menu()
        {
            Console.Clear();
            DoMath doMath = new DoMath();
            bool exitIt = false;
            int goodChoice = 0;

            Console.WriteLine("Welcome to the Party tip calculator");
            Console.WriteLine("1) Split Check");
            Console.WriteLine("2) Calculate tip");
            Console.WriteLine("3) Exit");


            while (!exitIt)
            {
                string dinerChoice = Console.ReadLine();

                if (!int.TryParse(dinerChoice, out goodChoice))
                {
                    Console.WriteLine("That wasn't an option");
                }
                else if (goodChoice > 3 || goodChoice < 1)
                {
                    Console.WriteLine("That wasn't an option");
                }


                switch (goodChoice)
                {
                    case 1:
                        doMath.SplitCheck();
                        break;
                    case 2:
                        doMath.CalcTip();
                        break;
                    case 3:
                        doMath.Exit();
                        break;
                }
            }
        }
    }
}
