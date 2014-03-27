using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ch11CardLib; //Will change to our card library in later use. 
namespace LogandStats
{
    public class Log
    {
        
        //Just a demo for how the begin will be like, will be fixed when I see the classes for hand and stuff like that.
        public static void Begin(string playerHand, string computerHand, Suit trump)
        {
            DateTime saveNow = DateTime.Now;

            if (File.Exists(@"C:\Users\Public\loggings.txt") == true)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\timecontinual.txt", true))
                {
                    file.WriteLine(saveNow + "trump is:" + trump.ToString());
                }
            }

            else
            {
                System.IO.File.WriteAllText(@"C:\Users\Public\loggins.txt", saveNow.ToString() + "trump is:" + trump.ToString());
            }


        }


        //Just a demo for how the the recording of moves will go, will be polished later when I check out our class library stuff to go with it.
        public static void Move(string playerType, string cardsDrew, string cardsPlayed)
        {
            DateTime saveNow = DateTime.Now;

            if (File.Exists(@"C:\Users\Public\loggings.txt") == true)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\timecontinual.txt", true))
                {
                    file.WriteLine(saveNow + "Cards drew bla bla:" + cardsDrew.ToString());
                }
            }

            else
            {
                System.IO.File.WriteAllText(@"C:\Users\Public\loggins.txt", saveNow.ToString() + "Cards played bla bla:" + cardsPlayed.ToString());
            }

        }

    }
  
}

