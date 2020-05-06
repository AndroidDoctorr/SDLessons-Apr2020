using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_RepoPattern_Repository
{
    public class ProgramUI
    {
        private readonly StreamingContentRepository _repo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the number of your selection:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit"
                );

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                    case "#1":
                    case "One":
                    case "one":
                    case "show all":
                        // Show all
                        ShowAllContents();
                        Console.ReadKey();
                        break;
                    case "2":
                        // Find by title
                        ShowContentByTitle();
                        break;
                    case "3":
                        // Add new
                        AddNewContent();
                        break;
                    case "4":
                        // Remove
                        // RemoveContentByTitle();
                        break;
                    case "5":
                        // Exit
                        continueToRun = false;
                        Console.WriteLine("Goodbye!");

                        Thread.Sleep(2500);

                        break;
                    default:
                        // Invalid input
                        Console.WriteLine("Please enter a valid option.\n");
                        // Read a key press from the user - this is just to pause
                        // the program and allow the user to read the screen
                        Console.ReadKey();
                        break;
                } // Ctrl + K + D   - this will make your code look nice
            }
        }

        private void AddNewContent()
        {
            Console.Clear();
            Console.WriteLine("Enter a title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter a description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter the star rating: (0.0 - 5.0)");
            double starRating = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select a maturity rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n");
            string maturityRatingChoice = Console.ReadLine();

            MaturityRating maturityRating;
            switch (maturityRatingChoice)
            {
                case "1":
                    maturityRating = MaturityRating.G;
                    break;
                case "2":
                    maturityRating = MaturityRating.PG;
                    break;
                default:
                    maturityRating = MaturityRating.U;
                    break;
            }

            Console.WriteLine("Select a Genre:\n" +
                "1. Horror\n" +
                "2. Comedy\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Drama\n" +
                "6. Action");
            string genreInput = Console.ReadLine();
            
            int genreId = Convert.ToInt32(genreInput);

            GenreType genre = (GenreType) genreId;

            StreamingContent newContent = new StreamingContent(title, description, starRating, maturityRating, genre);

            _repo.AddContentToDirectory(newContent);

            Console.WriteLine("New content added!");
            Console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                Console.WriteLine("No content found");
            }
            else
            {
                DisplayContent(content);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void ShowAllContents()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
        }

        private void DisplayContent(StreamingContent item)
        {
            Console.WriteLine($"{item.Title} ({item.StarRating} stars, {item.Genre}) - {item.Description}");
        }

        private void SeedContentList()
        {
            StreamingContent starwars = new StreamingContent("Star Wars", "Jar Jar saves the world", 5.0, MaturityRating.PG, GenreType.SciFi);
            StreamingContent rubber = new StreamingContent("Rubber", "A tire comes to life and kills people", 5.0, MaturityRating.R, GenreType.SciFi);
            StreamingContent doubleDown = new StreamingContent("Double Down", "A Neil Breen movie", 5.0, MaturityRating.PG, GenreType.SciFi);

            _repo.AddContentToDirectory(starwars);
            _repo.AddContentToDirectory(rubber);
            _repo.AddContentToDirectory(doubleDown);
        }
    }
}
