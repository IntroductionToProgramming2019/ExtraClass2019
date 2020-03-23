/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : printing to the console using arguements
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintMesageWithArguement("Happy Birthday", "Tommy");
            PrintMesageWithArguement("Enjoy the day", "I'll see you soon");
        }
        static void PrintMesageWithArguement(string message, string message_two)
        {
            Console.WriteLine("\t\t**********{0}************{1}************\t\t", message, message_two);
        }
    }
}
