using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Converter.Modules.Banner;

namespace String_Converter.Modules.Utils
{
    class ConsoleUtils
    {
        /*
         * Data fields
         */
        

        // Default constructor, empty
        public ConsoleUtils()
        {
            // Empty
        }
        /**
         * The basics of this function is to return a single
         * banner of characters repeated as many times as the
         * user sets them to repeat.
         * 
         * <param name="char">The character to display.</param>
         * <param name="times">How many times to display that character.</param>
         */
        public void PrintCharBanner(char c, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(c);
            }
            Console.Write("\n");
        }
        /**
         * This is the "scaled-down" version of Console.WriteLine(), instead
         * using Print() and sending the string to print to Console.WriteLine().
         * 
         * <param name="message">The string to print.</param>
         */
        public void Print(string message)
        {
            if (message != null || message.Length != 0)
            {
                Console.WriteLine(message);
            }
            else
            {
                return;
            }
        }
        /**
         * This functions purpose is, well, to print an error followed
         * by the error Q1 pattern. The user enters the string to pass
         * as the error and the function runs through the basic: is this
         * string null : not or does the length == 0, if so, don't print
         * anything.
         * 
         * <param name="error">The error to print out.</param>
         */
        public void PrintError(string error)
        {
            if (error != null || error.Length != 0)
            {
                Print("[Error]: " + error);
            }
            else
            {
                return;
            }
        }
        /**
         * This functions purpose is to print out a string of text using the
         * green foreground color, because if it was easier then then this, then
         * i haven't found a way...
         * 
         * <param name="str">The string to print using the green foreground color setting.</param>
         */
        public void PrintGreenString(string str)
        {
            if (ValidString(str))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print(str);
                ResetColor();
            }
        }
        /**
         * This functions purpose is the same as the PrintGreenString() function
         * except this time, the string color is gold instead of green. This
         * function uses the same method as the function above.
         * 
         * <param name="str">The string to print using the gold (yellow) foreground color setting.</param>
         */
        public void PrintGoldString(string str)
        {
            if (ValidString(str))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Print(str);
                ResetColor();
            }
        }
        /**
         * This functions purpose is to print the supplied string of text in
         * the cyan foreground color.
         * 
         * <param name="str">The string of text to print out in cyan.</param>
         */
        public void PrintCyanText(string str)
        {
            if (ValidString(str))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Print(str);
                ResetColor();
            }
        }

        /* Special */
        private static bool ValidString(string str)
        {
            if (str == null)
                return false;
            if (str.Length == 0)
                return false;
            return true;
        }

        private static void ResetColor()
        {
            Console.ResetColor();
        }
    }
}
