using _07_repositoryPattern_repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_streamingContent_inheritance.Content
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>(); // create new property, Episodes, that is a list of episodes

        public int SeasonCount { get; set; }

        public int EpisodeCount 
        {
            get
            {
                return Episodes.Count;  // returns the count of episodes, cannot be set
            }
        }

        public double AverageRunTime
        {
            get
            {
                // double totalRuntime
                // for each epsiode
                //      add runTime to total
                //  divide totalRunTime/episode count

                double totalRunTime = 0;
                foreach (Episode episode in Episodes)
                {
                    totalRunTime += episode.RunTime;
                }
                return totalRunTime / EpisodeCount;

                // fancy way with LINQ - pulls all info in a show's Episode class, gets total runtime, then divides by the number of Episodes
                // return Episodes.Select(e => e.RunTime).Sum() / EpisodeCount;


                // ex - this goes through all Episodes, pulls the titles, and adds them to a new list called episodeNames
                // List<string> episodeNames = Episodes.Select(e => e.Title).ToList();


            }
        }

        
    }


    // we put Episode class inside this folder simply because the code is so small and simple to read
    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }

    }
}
