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
            vegetableList();
            Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Thank you for using the Number Line TM");
		}
        static void DisplayNumberLine()
        {
            bool exit = false;
            Console.Clear();
            int numberTotal = 25;
            int userNumber = 0;
            Random random = new Random();
            List<int> numberLine = new List<int>();
            for (int i = 0; i <= 25; i++)
            {
                numberLine.Add(i);
                numberLine[i] = random.Next(0, 101);
            }

            //Console.WriteLine(numberLine.Count - 1 );
            while (exit != true)
            {

               foreach (int number in numberLine.Skip(1).Take(numberLine.Count - 2))
               {
                    Console.Write(number + ", ");
               }
                Console.WriteLine("");
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
                    Console.Clear();
                    numberLine.Sort();
                    Console.WriteLine("Sorted list:");
                    
                    
                }
                else if (userNumber == 2)
                {
                    Console.Clear();
                    DisplayNumberLine();
                }
                else if (userNumber == 3)
                {
                    Console.WriteLine("Enter the number you want to remove:");
                    int numberToRemove = 0;
                    while (!int.TryParse(Console.ReadLine(), out numberToRemove) || numberToRemove < 1 || numberToRemove > numberTotal)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Clear();
                    numberLine.RemoveAt(numberToRemove);
                    Console.WriteLine(numberLine.Count);
                    if (numberLine.Count == 0)
                    {
                        Console.WriteLine("The list is now empty.");
                    }
                    else if (numberToRemove % 2 == 0)
                    {
                        Console.WriteLine($"Removed {numberToRemove}nd from the list.");
                    }
                    else
                    {
                        Console.WriteLine($"Removed {numberToRemove}th from the list.");
                    }
                    
                }
                else if (userNumber == 4)
                {
                    Console.WriteLine("Enter the number you want to add:");
                    int numberToAdd = 25;
                    while (!int.TryParse(Console.ReadLine(), out numberToAdd) || numberToAdd < numberLine.Count || numberToAdd > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Clear();
                    numberLine.Add(numberToAdd);
                    numberLine.Sort();
                    
                    Console.WriteLine($"Added {numberToAdd} to the list.");


                }
                else if (userNumber == 5)
                {
                    Console.WriteLine("Enter the number you want to find:");
                    int numberToFind = 0;
                    while (!int.TryParse(Console.ReadLine(), out numberToFind) || numberToFind < 1 || numberToFind > numberTotal)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (numberLine.Contains(numberToFind))
                    {
                        Console.Clear();
                        Console.WriteLine($"The number {numberToFind} is in the list.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"The number {numberToFind} is not in the list.");
                    }
                }
                else if (userNumber == 6)
                {
                    Console.Clear();
                    int largestNumber = numberLine.Max();
                    Console.WriteLine($"The largest number in the list is: {largestNumber}");
                }
                else if (userNumber == 7)
                {
                    Console.Clear();
                    int smallestNumber = numberLine.Min();
                    Console.WriteLine($"The smallest number in the list is: {smallestNumber}");
                }
                else if (userNumber == 8)
                {
                    Console.Clear();
                    double average = numberLine.Average();
                    Console.WriteLine($"The average of the numbers in the list is: {average}");
                }
                else if (userNumber == 9)
                {
                    var sortedList = numberLine.OrderBy(n => n).ToList();
                    double median;
                    int count = sortedList.Count;
                    if (count % 2 == 0)
                    {
                        median = (sortedList[count / 2 - 1] + sortedList[count / 2]) / 2.0;
                    }
                    else
                    {
                        median = sortedList[count / 2];
                    }
                    Console.Clear();
                    Console.WriteLine($"The median of the numbers in the list is: {median}");
                }
                else if (userNumber == 10)
                {
					Console.Clear();
					exit = true;

                }
            }
        }
        public static void vegetableList()
		{
			int userNumber = 0;
			List<string> vegetables = new List<string> { "Carrot", "Broccoli", "Spinach", "Cauliflower", "Kale" };
            List<int> vegetableNumbers = new List<int> { 1, 2, 3, 4, 5 };
            bool exit = false;
			while (exit != true)
            {
                Console.WriteLine("Vegetable List:");
                foreach (string vegetable in vegetables)
                {
                    Console.WriteLine($"{vegetableNumbers[vegetables.IndexOf(vegetable)]}. {vegetable}");

                }
                Console.WriteLine("");
                Console.WriteLine("Please enter the number of the vegetable you want to select:");
                Console.WriteLine(":.:.:.:.:.:.:.:.:.:.:.:.:.:.:.:");
                Console.WriteLine("1) Remove number");
                Console.WriteLine("2) Add number");
                Console.WriteLine("3) Find Vegetable");
                Console.WriteLine("4) Sort the list");
				Console.WriteLine("5) Clear the list");
				Console.WriteLine("6) Exit");
                while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (userNumber == 1)
                {
                    if (vegetables.Count == 0)
					{
						Console.Clear();
						Console.WriteLine("The vegetable list is empty. There are no vegetables to remove.");
						continue;
					}
                    else
                    {
						Console.WriteLine("Which do you want to use to remove the vegetable? (1) by number (2) by name?");
						while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 2)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Invalid input. Please enter a number between 1 and 2.");
							Console.ForegroundColor = ConsoleColor.Green;
						}
						if (userNumber == 1)
						{
							Console.WriteLine("Enter the number of the vegetable you want to remove:");
							int vegetableToRemove = 0;
							while (!int.TryParse(Console.ReadLine(), out vegetableToRemove) || vegetableToRemove < 1 || vegetableToRemove > vegetables.Count)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Invalid input. Please enter a valid integer.");
								Console.ForegroundColor = ConsoleColor.Green;
							}
							vegetables.RemoveAt(vegetableToRemove - 1);
							Console.Clear();
							Console.WriteLine("Vegetable removed from the list.");
						}
						else if (userNumber == 2)
						{
							Console.WriteLine("Enter the name of the vegetable you want to remove: (Warning: Type the exact name, or the vegetable will not be removed)");
							string vegetableToRemoveByName = Console.ReadLine();
							if (vegetables.Contains(vegetableToRemoveByName))
							{
								vegetables.Remove(vegetableToRemoveByName);
								Console.Clear();
								Console.WriteLine("Vegetable removed from the list.");
							}
							else
							{
								Console.Clear();
								Console.WriteLine("Vegetable not found in the list.");
							}
						}
					}
					


					
                    
                }
                else if (userNumber == 2)
                {
                    Console.WriteLine("Enter the name of the vegetable you want to add:");
                    string vegetableToAdd = Console.ReadLine();
                    vegetables.Add(vegetableToAdd);
                    int newNumber = vegetables.Count;
                    vegetableNumbers.Add(newNumber);

                    Console.Clear();
                    Console.WriteLine("Vegetable added to the list.");
                }
                else if (userNumber == 3)
				{
					Console.WriteLine("Enter the name of the vegetable you want to find:");
					string vegetableToFind = Console.ReadLine();
                    Thread.Sleep(1000);
					if (vegetables.Contains(vegetableToFind))
					{

						Console.Clear();
						Console.WriteLine($"The vegetable {vegetableToFind} is in the list.");
                        Console.WriteLine($"");
						Console.WriteLine($"The vegetable {vegetableToFind} is number {vegetableNumbers[vegetables.IndexOf(vegetableToFind)]} in the list.");
						Console.WriteLine($"");
					}
					else
					{
						Console.Clear();
						Console.WriteLine($"The vegetable {vegetableToFind} is not in the list.");
					}
				}
				else if (userNumber == 4)
				{
					Console.Clear();
					vegetables.Sort();
					Console.WriteLine("Sorted list:");
				}
                else if (userNumber == 5)
                {
                    Console.Clear();
					vegetables.Clear();
                    vegetableNumbers.Clear();
                    Console.WriteLine("The vegetable list has been cleared.");

				}
				else if (userNumber == 6)
                {
                    Console.Clear();
					exit = true;
					return;
                }
            }
		}

	}
}
