using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Converter.Modules.Banner;
using String_Converter.Modules.Parser.Modules;
using String_Converter.Modules.Utils;
using String_Converter.Modules.Converter;

namespace String_Converter.Modules.Parser
{
    class SimpleParser
    {
        /*
         * The premis behind the parser is to parse
         * the source string from the main prompt.
         * This will then allow me to divide the source
         * string into 3 (or 4) different quadrant
         * groups allowing for CSC, command stream
         * control for parameters.
         */
        private string source;
        private string[] sq1;
        private string[] sq2;
        private string[] sq3;

        // Classes
        private String_Converter.Modules.Banner.Banner banner = new Banner.Banner();
        private ConsoleUtils utils = new ConsoleUtils();
        private Converter.Encoder ec;

        /*
         * The default source string is set to null due to the prompt
         * object being non-existant. If the user uses this set source
         * without the correct prompt source, an error will be thrown.
         */
        public SimpleParser()
        {
            source = null;
        }
        /**
         * Now, this is the OLC of the simple parser. This is used to set the source string
         * for use throughout THIS object space. This means that all functions and methods
         * can access the source string parameter and utilize it for checks and parsing.
         * 
         * <param name="source">The command source string to set and parse.</param>
         */
        public SimpleParser(string source)
        {
            this.source = source;
        }
        /**
         * As with all of my programs, I like to include setters and getters. But this time
         * the setter is most important. As mentioned in one of my previous comments, if the
         * user attempts to use the default set source value, then an error is thrown due to
         * the source value being null and without a proper prompt value.
         * 
         * <param name="source">The source prompt string to set and parse.</param>
         */
        public void SetSourceString(string source)
        {
            this.source = source;
        }
        /*
         * The main "simple-parsing-function" function. The premis of this function is to take
         * the source command string and divide it up into 3 (or 4) different parameter quadrants.
         * This allows for the user to:
         *      - Exec custom commands based on the combinations of the 4 parameters.
         *      - Allows for solo encoding console loops.
         *      - Give the user more control on how the string is utilized.
         * -------------------------------------------------------------------------------------
         * How the conversion command will be given, using all parameter combinations:
         * 
         *      > conv: "<STRING>" | <ENCODING> ; protocol (OPTIONAL)
         *     
         * Where ':' is quadrant 1 and '|' is quadrant 2 and ';' is quadrant 3.
         */
        public void ParseSource()
        {
            // Divide the source string into quadrants
            sq1 = source.Split(':');
            sq2 = source.Split('|');
            sq3 = source.Split(';');

            // First command will be the exit command
            if (source.Contains("exit"))
            {
                utils.Print("\n");
                banner.PrintExitBanner();
                Environment.Exit(1);
            }
            // -----------------------------------------------------------------------------------------------
            // Next PQ1 will be the converter command (conv/encode)
            // Loop through the converter command enumerator
            foreach (string str in Enum.GetNames(typeof(EnumCommandEncode)))
            {
                // If the user inputs any value in the enumerator, continue
                if (source.Contains(str))
                {
                    // Hexadecimal command SQ2
                    foreach (string hx in Enum.GetNames(typeof(SQ2HexCommand)))
                    {
                        if (sq2[1].Contains(hx.Trim(' ')))
                        {
                            // Use the Hex Converter Parser to encode the string to hexadecimal format
                            // Replace all the whitespace characters with null space (no spacing)
                            // Split the SQ2 character '|' and only give the first position value.
                            ec = new Converter.Encoder(sq1[1].Trim().Split('|')[0]);
                            ec.EncodeToHex();
                        }
                    }
                    // Binary command SQ2
                    foreach (string bin in Enum.GetNames(typeof(SQ2BinaryCommand)))
                    {
                        if (sq2[1].Contains(bin.Trim(' ')))
                        {
                            // Same as the Hex Converter Parser, encode the string into binary this time
                            // Replace all white spaces in the beginning and end of the string
                            // Split the SQ2 character '|' and only give the first position value
                            ec = new Converter.Encoder(sq1[1].Trim().Split('|')[0]);
                            ec.EncodeToBinary();
                        }
                    }
                    // Base64 command SQ2
                    foreach (string b64 in Enum.GetNames(typeof(SQ2Base64Command)))
                    {
                        if (sq2[1].Contains(b64.Trim(' ')))
                        {
                            // Same as the Hex Converter Parser, encode the string into base64 this time
                            // Replace all white spaces in the beginning and end of the string
                            // Split the SQ2 character '|' and only give the first position value
                            ec = new Converter.Encoder(sq1[1].Trim().Split('|')[0]);
                            ec.EncodeToBase64();
                        }
                    }
                }
            }

            // ------------------------------------------------------------------------------------------------
        }
    }
}
