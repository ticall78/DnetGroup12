using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch11CardLib; //Will change to our card library in later use. usin
using LogandStats;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Just a test for how we'll later send a name and result for the game...D is draw, W is win, L is lost. 
            Stats.StoreStat("Jay", "D");
            
            //Calls the readstat method in stats that will read from the stats file and stores in array
            string[] statsPlayer=  Stats.ReadStat();

            //Goes through the string of lines and displays.
            foreach (string line in statsPlayer)
            {
               
                Console.WriteLine("\t" + line);
                
            }

        
            System.Console.ReadKey();
      
            
        }
    }
}
