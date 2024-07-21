using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max);

                while (guess != number)
                {
                    Console.WriteLine(min + " ile " + max + " arasında bir sayı tahmin edin: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tahmin: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " çok yüksek");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " çok düşük");
                    }
                    guesses++;
                }
                Console.WriteLine("Sayı: " + number);
                Console.WriteLine("Kazandınız!!");
                Console.WriteLine("Tahmin Sayısı: " + guesses);

                Console.WriteLine("Tekrar oynamak ister misiniz? (E/H)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "E")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Oynadığınız için teşekkürlerr");
        }
    }
}