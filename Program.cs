public class Program
{
    public static void Main(string[] args)
    {
        bool loop = true;

        while (loop == true)
        {
            Console.WriteLine("Type SHOW for show character, RETAIL for retail price,TEMP for temperature, PRIME for prime number: ");
            string input = Console.ReadLine();

            Console.Clear();
            switch (input.Trim().ToUpper())
            {
                case "SHOW":
                    ShowCharacter();
                    loop = false;
                    break;
                case "RETAIL":
                    CalculateRetail();
                    loop = false;
                    break;
                case "TEMP":
                    Celsius();
                    loop = false;
                    break;
                case "PRIME":
                    IsPrime();
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid entry, try again");
                    break;
            }
        }

        static void ShowCharacter()
        {
            Console.Write("What is the word?: ");
            string word = Console.ReadLine();
            Console.Write("What character position would you like to find?: ");
            int position = Convert.ToInt32(Console.ReadLine());

            int csPostion = position - 1;
            char character = (word[csPostion]);

            Console.WriteLine($"Your word was {word} and the character position you chose was {character}.");
        }

        static void CalculateRetail()
        {
            Console.Write("What is the whole sale cost?: ");
            double wholeSale = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the markup percentage?: ");
            double markup = Convert.ToDouble(Console.ReadLine());

            double retailPrice = wholeSale + wholeSale * markup / 100;

            Console.WriteLine($"Items retail price is: {retailPrice}.");
        }

        static void Celsius()
        {
            Console.WriteLine("Fahrenheit     Celsius");
            for(int i = 80; i <= 100; i++)
            {
                double fahrenheit = i;
                double celsius = (5.0 / 9.0) * (fahrenheit - 32);
                Console.WriteLine($" {i}        {celsius}");

            }


        }

        static void IsPrime()
        {
            Console.Write("What is your number?: ");
            double number = Convert.ToDouble(Console.ReadLine());
            for (int i = 2; i < number / 2; i++) ;
            
        }
    }
}