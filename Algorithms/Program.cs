internal class Program
{
    private static void Main(string[] args)
    {
        Header();

        while(true)
        {
            Console.Write(@"
1. Bubble Sort
2. Linear Search
3. Caesar Cipher
Q. Quit. . .
-> ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RunBubbleSort();
                    break;
                case "2":
                    RunLinearSearch();
                    break;
                case "3":
                    RunCaesarCipher();
                    break;
                case "Q": case "q":
                    return;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
    public static void RunBubbleSort()
    {
        Console.Clear();
        Console.WriteLine(@"
 ____  __  __  ____  ____  __    ____  ___  _____  ____  ____ 
(  _ \(  )(  )(  _ \(  _ \(  )  ( ___)/ __)(  _  )(  _ \(_  _)
 ) _ < )(__)(  ) _ < ) _ < )(__  )__) \__ \ )(_)(  )   /  )(  
(____/(______)(____/(____/(____)(____)(___/(_____)(_)\_) (__) 
");     
        Console.Write("Enter list of numbers, separate with ',': ");
        var input = Console.ReadLine();

        int[] numbers;

        try
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSplitting . . .\n");
            Thread.Sleep(1000);
            numbers = input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s.Trim()))
                .ToArray();

            
            Console.WriteLine("Done!");
            foreach (int c in numbers)
            {
                Console.WriteLine(c);
            }
            Console.ResetColor();
        } 
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"Invalid input! Make sure you only enter numbers separated by commas.
Press any key to try again . . .");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nSorting . . .\n");
        Thread.Sleep(1000);

        numbers = BubbleSort(numbers);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nSorted!");

        foreach(int n in numbers)
        {
            Console.WriteLine(n);
        }
        Console.ResetColor();
    }

    public static int[] BubbleSort(int[] numbers)
    {
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = 0; j < numbers.Length - i - 1; j++)
            {
                if(numbers[j] > numbers[j+1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = temp;
                }
            }
        }

        return numbers;
    }

    public static void RunLinearSearch()
    {
        Console.WriteLine(@"
 _      ____  ____     ___   ____  ____    _____   ___   ____  ____      __  __ __ 
| |    |    ||    \   /  _] /    ||    \  / ___/  /  _] /    ||    \    /  ]|  |  |
| |     |  | |  _  | /  [_ |  o  ||  D  )(   \_  /  [_ |  o  ||  D  )  /  / |  |  |
| |___  |  | |  |  ||    _]|     ||    /  \__  ||    _]|     ||    /  /  /  |  _  |
|     | |  | |  |  ||   [_ |  _  ||    \  /  \ ||   [_ |  _  ||    \ /   \_ |  |  |
|     | |  | |  |  ||     ||  |  ||  .  \ \    ||     ||  |  ||  .  \\     ||  |  |
|_____||____||__|__||_____||__|__||__|\_|  \___||_____||__|__||__|\_| \____||__|__|
                                                                                   
");
        Console.Write("Enter list of numbers, separate with ',': ");
        var input = Console.ReadLine();
    }

    public static void RunCaesarCipher()
    {
        Console.WriteLine(@"
.------..------..------..------..------..------.     .------..------..------..------..------..------.
|C.--. ||A.--. ||E.--. ||S.--. ||A.--. ||R.--. |.-.  |C.--. ||I.--. ||P.--. ||H.--. ||E.--. ||R.--. |
| :/\: || (\/) || (\/) || :/\: || (\/) || :(): ((5)) | :/\: || (\/) || :/\: || :/\: || (\/) || :(): |
| :\/: || :\/: || :\/: || :\/: || :\/: || ()() |'-.-.| :\/: || :\/: || (__) || (__) || :\/: || ()() |
| '--'C|| '--'A|| '--'E|| '--'S|| '--'A|| '--'R| ((1)) '--'C|| '--'I|| '--'P|| '--'H|| '--'E|| '--'R|
`------'`------'`------'`------'`------'`------'  '-'`------'`------'`------'`------'`------'`------'
");
        Console.Write("Enter text to encrypt: ");
        var input = Console.ReadLine();

        Console.Write("Enter value of indentation: ");
        var input2 = Console.ReadLine();


    }
    private static void Header()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
 █████  ██       ██████   ██████  ██████  ██ ████████ ██   ██ ███    ███ ███████ 
██   ██ ██      ██       ██    ██ ██   ██ ██    ██    ██   ██ ████  ████ ██      
███████ ██      ██   ███ ██    ██ ██████  ██    ██    ███████ ██ ████ ██ ███████ 
██   ██ ██      ██    ██ ██    ██ ██   ██ ██    ██    ██   ██ ██  ██  ██      ██ 
██   ██ ███████  ██████   ██████  ██   ██ ██    ██    ██   ██ ██      ██ ███████ 
                                                                                 
A collection of algorithms to sort text, numbers,
objects and the likes into your desired output.
Bubble Sort, Linear Search, Caesar Crypt, you
name it.
");
        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        Console.WriteLine(@"
 █████  ██       ██████   ██████  ██████  ██ ████████ ██   ██ ███    ███ ███████ 
██   ██ ██      ██       ██    ██ ██   ██ ██    ██    ██   ██ ████  ████ ██      
███████ ██      ██   ███ ██    ██ ██████  ██    ██    ███████ ██ ████ ██ ███████ 
██   ██ ██      ██    ██ ██    ██ ██   ██ ██    ██    ██   ██ ██  ██  ██      ██ 
██   ██ ███████  ██████   ██████  ██   ██ ██    ██    ██   ██ ██      ██ ███████ 

Choose algorithm to use: ");
        // in main, we list all the algorithms we have
    }
}
