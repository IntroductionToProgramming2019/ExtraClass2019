/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : bool method validation
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuggets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of nuggets: ");
            int numNuggets = int.Parse(Console.ReadLine());
            bool buyNuggets = CanBuyMcNuggets(numNuggets);
            if (buyNuggets == true)
            {
                Console.WriteLine("Valid order");
            }
            else
                Console.WriteLine("Invalid order");
        }
        static bool CanBuyMcNuggets(int numNuggets)
        {

            if ((numNuggets == 6) || (numNuggets == 9) || (numNuggets == 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
