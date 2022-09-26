using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{

    //resource used: https://www.youtube.com/watch?v=ioi__WRETk4
    //8:37 mark
    internal class Program
    {
        private static string count;
        private static int number;

        //private static object newCandidate;

        static void Main(string[] args)
        {
            EasyAlgo(count);
            MediumAlgo(number);

            int EasyAlgo(string candidate)
            {

                int count = 0;

                //Add your code here.
                candidate = "rewind eageR dealeR reuse";
                char letterR = 'R';

                //organise sentence to individual characters
                //then count the number of occurences of character 'R'

                for (int i = 0; i < candidate.Length; i++)
                {
                    Console.WriteLine(candidate[i]);
                    char newCandidate = Convert.ToChar(candidate[i]);

                    if (newCandidate == letterR)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"there are {count} appearances of R");

                return count;
            }

            string MediumAlgo(int candidate)
            {
                //reference used: Murach's C#, page 291

                //Add your code here.

                string number = "";

                //Add your code here.
                Console.WriteLine("enter a random number");
                string randomNumber = Console.ReadLine();

                //get number from user then format below
               
                number = string.Format("{0:#,###,###}", randomNumber);
                Console.WriteLine(number);

                return number;

            }

        }
    }
}
