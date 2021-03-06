using _07_repositoryPattern_repository;
using _08_streamingContent_inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


        private void SeedContent()
        {
            Console.WriteLine("Seeding contents...");

            StreamingContent sc1 = new StreamingContent("All Dogs Go To Heaven", "Title says it all. Duh.", 4.5, MaturityRating.G, GenreType.Comedy);
            StreamingContent sc2 = new StreamingContent("My Dog Skip", "Terribly sad movie - the last time we see this dog, and Frankie Munez.", 3.5, MaturityRating.PG, GenreType.RomCom);
            StreamingContent sc3 = new StreamingContent("Bolt", "Adorable animated dog saves the world and his human. Makes me cry every time.", 4.5, MaturityRating.PG13, GenreType.Action);

            _repo.AddContentToDirectory(sc1);
            _repo.AddContentToDirectory(sc2);
            _repo.AddContentToDirectory(sc3);
        }



        private void Menu()
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
                    "4. Remove streaming content\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        // Show all content
                        DisplayAllContents();
                        break;
                    case "2":
                        // Find by title
                        GetContentByTitle();
                        break;
                    case "3":
                        // Add new content
                        AddNewContent();
                        break;
                    case "4":
                        // Remove content
                        RemoveContent();
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
            Thread.Sleep(2000); // force console to 'sleep; for 2 seconds before closing



            //below codekeeps the program open until user inputs to close it
            //Console.WriteLine("Press any key to exit the program my dude...");
            //Console.ReadKey();
        }




        // DISPLAY ALL CONTENTS
        private void DisplayAllContents()
        {
            Console.Clear();

            List<StreamingContent> contents = _repo.GetContents();

                        // type     // name  in  // list name
            foreach(StreamingContent content in contents)
            {
                DisplayContent(content);
            }

            ContinueMessage();
        }



        // GET CONTENT BY TITLE
        private void GetContentByTitle()
        {
            Console.Clear();
            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                Console.WriteLine("Content not found :(");
            }
            else
            {
                DisplayContent(content);
            }

            ContinueMessage();
        }



        // Great example of DRY code below - can be used everywhere to display contents and is simple to modify!
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"{content.Title} ({content.MaturityRating}) - {content.Description}. Rated {content.StarRating} {(content.StarRating == 1.0 ? "star" : "stars")} out of 5 stars.");
        }

        public void ContinueMessage()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }




        // ADD CONTENT
        private void AddNewContent()
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
            Console.Write("Maturity rating (#): ");
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


        private void RemoveContent()
        {
            Console.Clear();
            Console.WriteLine("Enter title of item to remove: ");

            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                Console.WriteLine("Content not found :(");
            }
            else
            {
                DisplayContent(content);
                Console.WriteLine("Are you sure you want to delete this? (y/n)");

                string answer = Console.ReadLine();
                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    _repo.DeleteExistingContent(content);
                    Console.WriteLine("Content removed!");
                }
                else
                {
                    Console.WriteLine("Nevermind then...");
                }
            }

            ContinueMessage();
        }
    }
}
