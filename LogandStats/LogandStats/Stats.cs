using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ch11CardLib; //Will change to our card library in later use. 

namespace LogandStats
{
    public class Stats
    {  

        //Resets the stats and asks for new username
        public static void Reset()
        {
            string playerName;

           
            do 
            {
                Console.WriteLine("Enter new name: ");
                playerName = Console.ReadLine();
            } 
            while (playerName.Trim() == "");   
            string[] lines = { "Name: " + playerName, "Wins: " + "0", "Draws " + "0", "Losses: " + "0" };
              
            System.IO.File.WriteAllLines(@"C:\Users\Public\cardstats.txt", lines);
        }



        //reads stats from text file and returns them in an array of strings
        public static string[] ReadStat()
        {

            string[] readLines = System.IO.File.ReadAllLines(@"C:\Users\Public\cardstats.txt");

            return readLines;
        }

        //Stores stats by either updating an already created stats file, or creating a new one.
        public static void StoreStat(String playerName, String gameResult)
        {

            DateTime saveNow = DateTime.Now;
            Console.WriteLine(saveNow);
            System.Console.ReadKey();
            string name;
            int wins;
            int draws;
            int losses;
            if (File.Exists(@"C:\Users\Public\cardstats.txt") == true)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\cardstats.txt", true))
                {
                    file.Close();
                    string[] readLines = System.IO.File.ReadAllLines(@"C:\Users\Public\cardstats.txt");
                    name = readLines[0].Substring(readLines[0].LastIndexOf(" ") + 1);
                    wins = Convert.ToInt32(readLines[1].Substring(readLines[1].LastIndexOf(" ") + 1));
                    draws = Convert.ToInt32(readLines[2].Substring(readLines[2].LastIndexOf(" ") + 1));
                    losses= Convert.ToInt32(readLines[3].Substring(readLines[3].LastIndexOf(" ") + 1));


                    if (gameResult == "W")
                    {
                        wins = wins + 1;
                        string[] lines = { "Name: " + name, "Wins: " + wins.ToString(), "Draws: " + draws.ToString(), "Losses " + losses.ToString()};
                        System.IO.File.WriteAllLines(@"C:\Users\Public\cardstats.txt", lines);

                    }
                    else if (gameResult == "D")
                    {
                        draws = draws + 1;
                        string[] lines = { "Name: " + name, "Wins: " + wins.ToString(), "Draws: " + draws.ToString(), "Losses " + losses.ToString() };
                        System.IO.File.WriteAllLines(@"C:\Users\Public\cardstats.txt", lines);

                    }

                    else if (gameResult == "L")
                    {
                        losses = losses + 1;
                        string[] lines = { "Name: " + name, "Wins: " + wins.ToString(), "Draws: " + draws.ToString(), "Losses " + losses.ToString() };
                        System.IO.File.WriteAllLines(@"C:\Users\Public\cardstats.txt", lines);

                    }


                }
            }

            else
            {

                if (gameResult == "W")
                {
                    string[] lines = {"Name: " + playerName, "Wins: " + "1", "Draws: " + "0", "Losses " + "0"};
                    System.IO.File.WriteAllLines(@"C:\Users\Public\cardstats.txt", lines);

                }
                else if(gameResult =="D")
                {
                    string[] lines = { "Name: " + playerName, "Wins: " + "0", "Draws " + "1", "Losses: " + "0" };
                    System.IO.File.WriteAllLines(@"C:\Users\Public\cardstats.txt", lines);

                }

                else if (gameResult == "L")
                {
                    string[] lines = { "Name: " + playerName, "Wins: " + "0", "Draws " + "0", "Losses: " + "1" };
                    System.IO.File.WriteAllLines(@"C:\Users\Public\cardstats.txt", lines);

                }

             

               
            }
        }
    }

}

