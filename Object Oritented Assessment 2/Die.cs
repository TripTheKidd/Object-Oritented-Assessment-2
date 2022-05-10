using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oritented_Assessment_2
{
    internal class Die
    {
        int Die1;
        int Die2;
        int Die3;
        int Die4;
        int Die5;
        static void Main(string[] args)
        {
            int playerRandomNum;
            int playerPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);
            }

            Console.ReadKey();
        }

























    }
}
