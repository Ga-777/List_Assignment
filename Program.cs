namespace List_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, Welcome to the Number Line TM");
            Console.WriteLine("{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}");
            Console.WriteLine("Please enter a number to contiune:");
            Console.ReadLine();
            DisplayNumberLine();
        }
        static void DisplayNumberLine()
        {
            int userNumber = 0;
            Random random = new Random();
            List<int> numberLine = new List<int>();
            for (int i = 0; i <= 25; i++)
            {
                numberLine.Add(i);
                numberLine[i] = random.Next(0, 100);
            }

            //Console.WriteLine(numberLine.Count - 1 );
            while (userNumber != 10)
            {

                Console.Write(numberLine[0] + ", ");
                Console.Write(numberLine[1] + ", ");
                Console.Write(numberLine[2] + ", ");
                Console.Write(numberLine[3] + ", ");
                Console.Write(numberLine[4] + ", ");
                Console.Write(numberLine[5] + ", ");
                Console.Write(numberLine[6] + ", ");
                Console.Write(numberLine[7] + ", ");
                Console.Write(numberLine[8] + ", ");
                Console.Write(numberLine[9] + ", ");
                Console.Write(numberLine[10] + ", ");
                Console.Write(numberLine[11] + ", ");
                Console.Write(numberLine[12] + ", ");
                Console.Write(numberLine[13] + ", ");
                Console.Write(numberLine[14] + ", ");
                Console.Write(numberLine[15] + ", ");
                Console.Write(numberLine[16] + ", ");
                Console.Write(numberLine[17] + ", ");
                Console.Write(numberLine[18] + ", ");
                Console.Write(numberLine[19] + ", ");
                Console.Write(numberLine[20] + ", ");
                Console.Write(numberLine[21] + ", ");
                Console.Write(numberLine[22] + ", ");
                Console.Write(numberLine[23] + ", ");
                Console.Write(numberLine[24] + ", ");
                Console.WriteLine(numberLine[25]);
                Console.WriteLine("");
                Console.WriteLine("Please pick a number from 1-10");
                Console.WriteLine(":.:.:.:.:.:.:.:.:.:.:.:.:.:.:.:");
                Console.WriteLine("1) Sort the list");
                Console.WriteLine("2) new list");
                Console.WriteLine("3) Remove number");
                Console.WriteLine("4) Add number");
                Console.WriteLine("5) Find numbers");
                Console.WriteLine("6) Find largest number");
                Console.WriteLine("7) Find smallest number");
                Console.WriteLine("8) Find average");
                Console.WriteLine("9) Find median");
                Console.WriteLine("10) Exit");

                while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (userNumber == 1)
                {
                    numberLine.Sort();
                    Console.WriteLine("Sorted list:");
                    foreach (int number in numberLine)
                    {
                        Console.Write(number + ", ");
                    }
                    Console.WriteLine();
                }
                else if (userNumber == 2)
                {
                    DisplayNumberLine();
                }
                else if (userNumber == 3)
                {
                    Console.WriteLine("Enter the number you want to remove:");
                    int numberToRemove;
                    while (!int.TryParse(Console.ReadLine(), out numberToRemove))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (numberLine.Remove(numberToRemove))
                    {
                        Console.WriteLine($"Removed {numberToRemove} from the list.");
                    }
                    else
                    {
                        Console.WriteLine($"{numberToRemove} was not found in the list.");
                    }
                }
                else if (userNumber == 4)
                {
                    Console.WriteLine("Enter the number you want to add:");
                    int numberToAdd;
                    while (!int.TryParse(Console.ReadLine(), out numberToAdd))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    numberLine.Add(numberToAdd);
                    Console.WriteLine($"Added {numberToAdd} to the list.");


                }
            }
        }
    }
}
