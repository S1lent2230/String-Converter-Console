using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Converter.Modules.Utils;

namespace String_Converter.Modules.Banner
{
    class Banner
    {
        /*
         * The banner module will consist of 3 different
         * string values: the program name, the program
         * version, and the program author, all of which
         * can be set and edited.
         */
        private string PROGRAM_NAME;
        private string PROGRAM_VERSION;
        private string PROGRAM_AUTHOR;
        private string AUTHOR_EMAIL;

        private string[] exit_msg = new string[] { "Shutting down components", "Exiting..." };

        // Classes
        private ConsoleUtils utils = new ConsoleUtils();

        /*
         * The default constructor sets the default banner
         * values. When the default constructor is initialized
         * the default values are the ones displayed.
         */
        public Banner()
        {
            PROGRAM_NAME = "String Converter";
            PROGRAM_VERSION = "1.0";
            PROGRAM_AUTHOR = "S1lent";
            AUTHOR_EMAIL = "s12290x@gmail.com";
        }
        /**
         * This is the OLC of the banner program. The values can be set using
         * this constructor and they will be what will be displayed. These values
         * will also be made global accessible to the functions and methods.
         * 
         * <param name="name">The name of this program.</param>
         * <param name="version">The version of this program.</param>
         * <param name="author">Who wrote this program?</param>
         * <param name="email">The authors email address.</param>
         */
        public Banner(string name, string version, string author, string email)
        {
            PROGRAM_NAME = name;
            PROGRAM_VERSION = version;
            PROGRAM_AUTHOR = author;
            AUTHOR_EMAIL = email;
        }
        /**
         * This function sets the name of the program, thus overriding the name
         * value of the default constructor, this will be the name that will be
         * displayed on the banner.
         * 
         * <param name="name">The name of this program.</param>
         */
        public void SetProgramName(string name)
        {
            PROGRAM_NAME = name;
        }
        /**
         * This function sets the version of the program, thus overriding the
         * version value of the default constructor, this will be the version
         * that will be displayed on the banner
         * 
         * <param name="version">The version of this program.</param>
         */
        public void SetProgramVersion(string version)
        {
            PROGRAM_VERSION = version;
        }
        /**
         * This function sets the programs author, this will override the author
         * value in the default constructor, this is what will be displayed in
         * the banner.
         * 
         * <param name="author">Who is it, that wrote this program?</param>
         */
        public void SetProgramAuthor(string author)
        {
            PROGRAM_AUTHOR = author;
        }
        /**
         * Finally, this program sets the authors email address, thus, overriding
         * the email value set by the default constructor, this is the email that
         * will be displayed in the banner.
         * 
         * <param name="email">The email of the author.</param>
         */
        public void SetAuthorEmail(string email)
        {
            AUTHOR_EMAIL = email;
        }
        /*
         * Gets the name of the program, returns the
         * name string.
         */
        public string GetProgramName()
        {
            return PROGRAM_NAME;
        }
        /*
         * Gets the programs version, returns the
         * version string.
         */
        public string GetProgramVersion()
        {
            return PROGRAM_VERSION;
        }
        /*
         * Who is the programs author? This method
         * returns the author string.
         */
        public string GetProgramAuthor()
        {
            return PROGRAM_AUTHOR;
        }
        /*
         * Gets the email of the author, returns
         * the email string.
         */
        public string GetAuthorEmail()
        {
            return AUTHOR_EMAIL;
        }
        /*
         * The primary banner component. Nevermind that there are at least 4 functions
         * and methods to return the banners main string contents, but, this is the
         * primary function. It will use the PrintChar() function to print the first and
         * last quadrant of the banner meanwhile printing the programs info.
         */
        public void PrintBanner()
        {
            utils.PrintCharBanner('*', 90);
            utils.Print("**\tProgram Name: " + PROGRAM_NAME + "\t\t\t\t\t\t\t**");
            utils.Print("**\tProgram Version: " + PROGRAM_VERSION + "\t\t\t\t\t\t\t\t**");
            utils.Print("**\tProgram Author: " + PROGRAM_AUTHOR + "\t\t\t\t\t\t\t\t**");
            utils.Print("**\tAuthor Email: " + AUTHOR_EMAIL + "\t\t\t\t\t\t\t**");
            utils.PrintCharBanner('*', 90);
            utils.Print("\n");
        }
        /*
         * An extra exit banner function.
         */
        public void PrintExitBanner()
        {
            foreach (string s in exit_msg)
            {
                utils.Print("[*] " + s);
            }
            utils.Print("\n");
        }
    }
}
