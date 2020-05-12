using _07_RepoPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_StreamingContent_UI_Refactor
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly StreamingContentRepository _repo = new StreamingContentRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

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
                _console.WriteLine(
                    "Enter the number of your selection:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit"
                );

                string selection = _console.ReadLine();

                switch (selection)
                {
                    case "1":
                    case "#1":
                    case "One":
                    case "one":
                    case "show all":
                        // Show all
                        ShowAllContents();
                        _console.ReadKey();
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
                        _console.WriteLine("Goodbye!");

                        Thread.Sleep(2500);

                        break;
                    default:
                        // Invalid input
                        _console.WriteLine("Please enter a valid option.\n");
                        // Read a key press from the user - this is just to pause
                        // the program and allow the user to read the screen
                        _console.ReadKey();
                        break;
                } // Ctrl + K + D   - this will make your code look nice
            }
        }

        private void AddNewContent()
        {
            _console.Clear();
            _console.WriteLine("Enter a title:");
            string title = _console.ReadLine();

            _console.WriteLine("Enter a description:");
            string description = _console.ReadLine();

            _console.WriteLine("Enter the star rating: (0.0 - 5.0)");
            double starRating = Convert.ToDouble(_console.ReadLine());

            _console.WriteLine("Select a maturity rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n");
            string maturityRatingChoice = _console.ReadLine();

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

            _console.WriteLine("Select a Genre:\n" +
                "1. Horror\n" +
                "2. Comedy\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Drama\n" +
                "6. Action");
            string genreInput = _console.ReadLine();
            
            int genreId = Convert.ToInt32(genreInput);

            GenreType genre = (GenreType) genreId;

            StreamingContent newContent = new StreamingContent(title, description, starRating, maturityRating, genre);

            _repo.AddContentToDirectory(newContent);

            _console.WriteLine("New content added!");
            _console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Enter a title");
            string title = _console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                _console.WriteLine("No content found");
            }
            else
            {
                DisplayContent(content);
            }

            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

        private void ShowAllContents()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
        }

        private void DisplayContent(StreamingContent item)
        {
            _console.WriteLine($"{item.Title} ({item.StarRating} stars, {item.Genre}) - {item.Description}");
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
