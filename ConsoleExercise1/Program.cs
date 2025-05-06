using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // This is a comment

        // The following line prints "Hello, World!" to the console

        // The method WriteHelloWorld is called to perform the action

        int number = 5; // This is a variable declaration and initialization
        float decimalNumber = 5.5f; // This is a float variable declaration and initialization
        double largeDecimalNumber = 5.555555555555; // This is a double variable declaration and initialization
        decimal preciseDecimalNumber = 5.555555555555m; // This is a decimal variable declaration and initialization

        string name = "Mannu!"; // This is a string variable declaration and initialization
        string greeting = $"Ciaone, {name}"; // This is another string variable declaration and initialization
        string verbatimString = @"This is a verbatim string literal. 
It can span multiple lines and escape 
sequences are not processed.";

        char letter = 'A'; // This is a character variable declaration and initialization

        var isTrue = true; // This is a variable declaration with type inference    
        var number2 = 10; // This is a variable declaration with type inference
        var number3 = 10.5f; // This is a variable declaration with type inference



        bool isTrue1 = true; // This is a boolean variable declaration and initialization    


        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }

        // Exercise1();
        GuessTheNumber();



    private static void WriteHelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    public static void Exercise1()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 7 == 0 && CheckPerfectSquare(i))
            {
                Console.WriteLine(i + " Paperone");
            }

            else if (i % 7 == 0)
            {
                Console.WriteLine(i + " Pippo");
            }

            else if (CheckPerfectSquare(i))
            {
                Console.WriteLine(i + " Pluto");
            }

            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static bool CheckPerfectSquare(int number)
    {
        double result = Math.Sqrt(number);
        return result % 1 == 0;


    }


    public static void GuessTheNumber()

    {
        bool isInt;
        int number;
        Random random = new Random();
        int guessNumber = random.Next(1, 11);
        Console.WriteLine("Ciao, indovina il numero");
        Console.WriteLine("Inserisci un numero intero da 1 a 10:");

        do
        {
            string input = Console.ReadLine();
            isInt = int.TryParse(input, out number);
            if (guessNumber != number)
            {
                if (guessNumber < number)
                {
                    Console.WriteLine("metti un numero piu basso");
                }
                else
                {
                    Console.WriteLine("metti un numero piu alto");
                }
            }

        }
        while (guessNumber != number);
        Console.WriteLine("bravo hai indovinato il numero era " + guessNumber);
    }





}


// args  cambiare applciation che conta occorrenze, invece che testo prenderà un url di un file (vedere come si leggono i file da c#), se do file e parola conta, se do solo il file mi riporta stats testo, conteggio parole, caratteri, vocali e consonanti.
// csv to json da tradurre





