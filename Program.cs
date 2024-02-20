namespace Topic_4___Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 Random Integers
            int minNumber;
            int maxNumber;
            int randomNum1;
            double randomDecimal;
            Console.WriteLine("Enter a minimum number");
            minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum number");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            Random generator = new Random();
            randomNum1 = generator.Next(minNumber, maxNumber + 1);
            Console.WriteLine(randomNum1);

            //Part 2 Dice Roller
            int die1;
            int die2;

            die1 = generator.Next(1, 7);
            die2 = generator.Next(1, 7);
            Console.WriteLine(die1);

            if (die1 == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("-----");
            }
            else if (die1 == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die1 == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die1 == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die1 == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|ooo|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die1 == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|ooo|");
                Console.WriteLine("|ooo|");
                Console.WriteLine("-----");
            }
            Console.WriteLine(die2);
            if (die2 == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("-----");
            }
            else if (die2 == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die2 == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die2 == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die2 == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|ooo|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (die2 == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|ooo|");
                Console.WriteLine("|ooo|");
                Console.WriteLine("-----");
            }
            // Part 3 Random decimals


            double minNumber2;
            double maxNumber2;


            minNumber2 = minNumber;
            maxNumber2 = maxNumber;
            randomDecimal = generator.NextDouble();
            Console.WriteLine(randomNum1);
        }
    }
}
