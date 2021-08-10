using _07_repositoryPattern_repository;
using _08_streamingContent_inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_streamingContent_console.UI
{
    public class ProgramUI
    {
        // inherits from StreamingContentRepository
        private readonly StreamingRepository _repo = new StreamingRepository();



        // method Run() starts UI
        public void Run()
        {
            SeedContent();
            Menu();
        }


        public void SeedContent()
        {
            Console.WriteLine("Seeding contents");
        }



        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear(); // will wipe info so we have clear console each time

                // \n = new line = CR + LF (CR and LF are from typewriter days)
                // CR: Carriage Return 
                // LF: Line Feed
                Console.WriteLine("Menu:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove stresming content\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        // Show all content
                        break;
                    case "2":
                        // Find by title
                        break;
                    case "3":
                        // Add new content
                        AddNewContent();
                        break;
                    case "4":
                        // Remove content
                        break;
                    case "exit":
                    case "EXIT":
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Ma salama!"); // goodbye message
            System.Threading.Thread.Sleep(2000); // force console to 'sleep; for 2 seconds before closing



            //below codekeeps the program open until user inputs to close it
            //Console.WriteLine("Press any key to exit the program my dude...");
            //Console.ReadKey();
        }


        public void AddNewContent()
        {
            Console.Clear();

            StreamingContent content = new StreamingContent();


            // Title
            bool isValidTitle = false;
            while (!isValidTitle)
            {
                Console.Write("Title: ");
                string title = Console.ReadLine();

                //content.Title = string.IsNullOrWhiteSpace(title) ? "Untitled" : title;

                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("Please enter a valid title (press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    content.Title = title;
                    isValidTitle = true;
                }
            }


            // Description
            Console.Write("Description: ");
            string description = Console.ReadLine();
            content.Description = string.IsNullOrWhiteSpace(description) ? "(No Description)" : description;



            // Star Rating
            Console.Write("Star Rating (1-5): ");
            double stars = double.Parse(Console.ReadLine()); // makes sure user inout is a valid double
            if (stars > 5)
            {
                content.StarRating = 5;
            }
            else if (stars < 0)
            {
                content.StarRating = 0;
            }
            else
            {
                content.StarRating = stars;
            }


            // Maturity Rating
            Console.WriteLine("1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. NC-17\n" +
                "6. TVG\n" +
                "7. TVY\n" +
                "8. TVMA\n");
            Console.Write("Maturity rating: ");
            string maturityInput = Console.ReadLine();
            int maturityId = int.Parse(maturityInput);
            content.MaturityRating = (MaturityRating)maturityId;

            // or in one line:
            // 


            // compile-time error gives red line, won't build or run
            // run-time error doesn't occur until the code builds and runs




            // Genre
            Console.WriteLine("1. Sci-Fi\n" +
                "2. Comedy\n" +
                "3. Horror\n" +
                "4. RomCom\n" +
                "5. Documentary\n" +
                "6. Western\n" +
                "7. Action");
            Console.Write("Genre: ");
            string genreInput = Console.ReadLine();

            switch (genreInput)
            {
                case "scifi":  // makes program seem much smarter if we code in all possible input cases for each GenreType
                case "SciFi":
                case "sci-fi":
                case "Sci-Fi":
                case "one":
                case "1":
                    content.GenreType = GenreType.SciFi;
                    break;
                case "2":
                    content.GenreType = GenreType.Comedy;
                    break;
                case "3":
                    content.GenreType = GenreType.Horror;
                    break;
                case "4":
                    content.GenreType = GenreType.RomCom;
                    break;
                case "5":
                    content.GenreType = GenreType.Documentary;
                    break;
                case "6":
                    content.GenreType = GenreType.Western;
                    break;
                case "7":
                    content.GenreType = GenreType.Action;
                    break;
                default:
                    content.GenreType = 0;
                    break;
            }

            _repo.AddContentToDirectory(content);
        }
    }
}
