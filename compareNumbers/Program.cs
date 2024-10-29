namespace compareNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // welcome to user 
            Console.WriteLine("welcome to  Compare Numbers app");

            // ask  user to enter numbers
            Console.WriteLine("please enter 3 numbers");
            Console.WriteLine("\n");
            // read numbers
            double dFirstNumber = 0, dSecondNumber = 0, dThirdNumber = 0;
            //FirstNumber
            Console.WriteLine("please enter First Number ");
            bool convertedFirstNumber = double.TryParse(Console.ReadLine(), out dFirstNumber);
            // second number
            Console.WriteLine("please enter second number");
            bool convertedSecondNumber = double.TryParse(Console.ReadLine(), out dSecondNumber);
            //ThirdNumber
            Console.WriteLine("please enter Third Number ");
            bool convertedThirdNumber = double.TryParse(Console.ReadLine(), out dThirdNumber);
            // if 
            if (dFirstNumber > dSecondNumber && dFirstNumber > dThirdNumber)
            {
                Console.WriteLine($"First Number is the greatest{dFirstNumber} ");
            }
            if (dSecondNumber > dFirstNumber && dSecondNumber > dThirdNumber)
            {
                Console.WriteLine($"second number is the greatest{dSecondNumber} ");
            }
            if (dThirdNumber > dFirstNumber && dThirdNumber > dSecondNumber)
            {
                Console.WriteLine($"Third Number is the greatest {dThirdNumber} ");
            }

        }
    }
}
