using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        private static List<Movie> liMovies = new List<Movie>();
        static void Main(string[] args)
        {
            liMovies.Add(new Movie("Star Wars 2001: A Space Odyssey E.T.", "scifi"));
            liMovies.Add(new Movie("The Extra-terrestrial", "scifi"));
            liMovies.Add(new Movie("A Clockwork Orange", "scifi"));
            liMovies.Add(new Movie("Close Encounters of the Third Kind", "scifi"));

            liMovies.Add(new Movie("Frozen", "animated"));
            liMovies.Add(new Movie("The Lion King", "animated"));

            liMovies.Add(new Movie("Titanic", "drama"));
            liMovies.Add(new Movie("Cast Away", "drama"));

            liMovies.Add(new Movie("The Grudge", "horror"));
            liMovies.Add(new Movie("The Conjuring", "horror"));

            liMovies.Sort((x, y) => string.Compare(x.title, y.title));

            string UserEnteredCategoryValue;
            char RetryAgain;
            Console.WriteLine("Welcome to the Movie List Application! There are 100 movies in this list.");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("***********");
                Console.WriteLine("1. scifi");
                Console.WriteLine("2. animated");
                Console.WriteLine("3. drama");
                Console.WriteLine("4. horror");
                Console.WriteLine();
                Console.WriteLine("What category are you interested in? You can ENTER either category number or category name");
                UserEnteredCategoryValue = Console.ReadLine();


                switch (UserEnteredCategoryValue)
                {
                    case "1":
                    case "scifi":
                        DisplayListOfMovies("scifi");
                        break;

                    case "2":
                    case "animated":
                        DisplayListOfMovies("animated");
                        break;

                    case "3":
                    case "drama":
                        DisplayListOfMovies("drama");
                        break;


                    case "4":
                    case "horror":
                        DisplayListOfMovies("horror");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Try again");
                        continue;
                }

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                RetryAgain = Console.ReadKey(false).KeyChar;
                if ((RetryAgain == 'y') || (RetryAgain == 'Y'))
                {
                    continue;
                }
                else if ((RetryAgain == 'n') || (RetryAgain == 'N'))
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program has exited. Press ENTER to close.");
            Console.ReadLine();

        }

        private static void DisplayListOfMovies(string category)
        {
            for (int i = 0; i < liMovies.Count; i++)
            {
                if (liMovies[i].category == category)
                {
                    Console.WriteLine(liMovies[i].title);
                }
            }
        }
    }
}
