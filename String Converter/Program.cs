using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Converter.Modules.Banner;
using String_Converter.Modules.Parser;

/*
 * Primary Module - Central Command
 * Version: 1.0
 * Author: S1lent
 * RVS: 002-A
 */
namespace String_Converter
{ 
    class Program
    {
        /*
         * Data fields, i.e: variables
         * classes, and others.
         */
        private static string CONSOLE_PROMPT = "converter:";
        private static int CONSOLE_LEVEL = 1;
        private static string PROMPT_CHAR = "> ";

        // Classes
        private static Banner banner = new Banner();
        private static SimpleParser sp;

        static void Main(string[] args)
        {
            // Print out a banner
            banner.PrintBanner();

            // Primary while loop for the console prompt
            while (true)
            {
                Console.Write(CONSOLE_PROMPT + CONSOLE_LEVEL + PROMPT_CHAR);
                string input = Convert.ToString(Console.ReadLine());

                // Initialize simple parser here
                sp = new SimpleParser(input);
                sp.ParseSource();
            }
        }
    }
}
