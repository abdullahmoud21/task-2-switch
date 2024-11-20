namespace task_2_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char action = default;
            List<int> values = new List<int>();
            int userInput = default;
            double sum = default;
            double mean = default;
            int indexNo = default;

            

            do
            {
                Console.WriteLine("P - print numbers");
                Console.WriteLine("A - add a number");
                Console.WriteLine("M - display mean of the numbers");
                Console.WriteLine("< - to display ascendingly");
                Console.WriteLine("> - to display descendingly");
                Console.WriteLine("S - display the smallest number");
                Console.WriteLine("L - display the largest number");
                Console.WriteLine("F - To find a value inserted in the list");
                Console.WriteLine("R - To remove all the values inserted in the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("Enter a letter to perform a task:");
                action = Convert.ToChar(Console.ReadLine());
                switch (char.ToUpper (action))
                {
                    case 'A':
                        Console.WriteLine("Enter a value you wish to add: ");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        if (values.Contains(userInput))
                        {
                            Console.WriteLine("Number already exists");
                        }
                        else
                        {
                            values.Add(userInput);
                            Console.WriteLine($"/'{userInput}/'has been added");
                        }
                        break;

                    case 'P':
                        if (values.Count == 0)
                        {
                            Console.WriteLine("Add numbers to the list to use this function");
                        }
                        else
                        {
                            {
                                Console.Write("The values in the list are:[ ");
                                for (int i = 0; i < values.Count; i++)
                                {
                                    Console.Write(values[i] + " ");
                                }
                                Console.WriteLine("]");
                            }
                        }
                        break;

                    case 'M':
                        if (values.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            for (int i = 0; i < values.Count; i++)
                            {
                                sum += values[i];
                                mean = sum / values.Count;
                            }
                            Console.WriteLine("The mean of the values in the list are:");
                            Console.WriteLine(mean);
                        }
                        break;

                    case 'S':
                        int smallest = values[0];
                        for (int i = 0; i < values.Count; i++)
                        {
                            if (values[i] < smallest)
                                smallest = values[i];
                        }
                        Console.WriteLine($"The smallest number is: {smallest}");
                        break;

                    case '<':
                        if (values.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest numbers - list is empty");
                        }
                        else
                        {
                            for (int i = 0; i < values.Count; i++)
                            {
                                for (int j = 0; j < values.Count - 1 - i; j++)
                                {
                                    if (values[j] > values[j + 1])
                                    {
                                        int asc = values[j];
                                        values[j] = values[j + 1];
                                        values[j + 1] = asc;
                                    }
                                }
                            }
                            Console.WriteLine("Items in the list in ascending order: ");
                            for (int i = 0; i < values.Count; i++)
                            {
                                Console.WriteLine(values[i]);
                            }
                        }
                        break;

                    case 'L':
                        int largest = values[0];
                        for (int i = 0; i < values.Count; i++)
                        {
                            if (values[i] > largest)
                                largest = values[i];
                        }
                        Console.WriteLine($"The largest number is: {largest}");
                        break;

                    case '>':

                        if (values.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest numbers - list is empty");
                        }
                        else
                        {
                            for (int i = 0; i < values.Count; i++)
                            {
                                for (int j = 0; j < values.Count - 1 - i; j++)
                                {
                                    if (values[j] < values[j + 1])
                                    {
                                        int asc = values[j];
                                        values[j] = values[j + 1];
                                        values[j + 1] = asc;
                                    }
                                }
                            }
                            Console.WriteLine("Items in the list in descending order: ");
                            for (int i = 0; i < values.Count; i++)
                            {
                                Console.WriteLine(values[i]);
                            }
                        }
                        break;

                    case 'F':
                        if (values.Count == 0)
                        {
                            Console.WriteLine("Add numbers to the list to use this function");
                        }
                        else
                        {
                            Console.WriteLine("Enter the value you wish to search for");
                            int find = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < values.Count; i++)
                            {
                                if (find == values[i])
                                {
                                    indexNo = values.IndexOf(values[i]);
                                    Console.WriteLine(true);
                                }
                            }
                            Console.WriteLine($"The number {find} is found and lays in the {indexNo}");
                        }
                        break;

                    case 'R':
                        if (values.Count == 0)
                        {
                            Console.WriteLine("The list is already empty");
                        }
                        else
                        {
                            Console.WriteLine("All values have been removed");
                            values.Clear();
                        }
                        break;

                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Unknown Character - Please enter a valid character to proceed");
                        break;
                           }
                }
                while (action != 'Q') ;
            }
    }
    
}
