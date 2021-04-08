using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine(
                 $"{row} x {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(
                    ReadLine(), out byte number);

                if(isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while(isNumber);
        }

        // static void RunTimesTable()
        // {
        //     Write("Enter an amount: ");
        //     string amountInText = ReadLine();
        //     Write("Enter a two-letter region code: ");
        //     string region = ReadLine();

        //     if (decimal.TryParse(amountInText, out decimal amount))
        //     {
        //         decimal taxToPay = CalculateTax(amount, region);
        //         WriteLine($"You must pay {taxToPay} in sales tax.");
        //     }
        //     else
        //     {
        //         WriteLine("You did not enter a valid amount!");
        //     }
        // }
        static decimal CalculateTax (decimal amount, 
        string twoLetterRegionCode){
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08M;
                    break;
                case "DK":
                case "NO":
                    rate = 0.25M;
                    break;
                case "GB":
                case "FR":
                    rate = 0.2M;
                    break;
                case "HU":
                    rate = 0.27M;
                    break;
                // ...etc
                default:
                    rate = 0.06M;
                    break;

            }
            return amount * rate;
        }

        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }
        static void Main(string[] args)
        {
            // RunTimesTable();
            RunCalculateTax();
        }
    }
}
