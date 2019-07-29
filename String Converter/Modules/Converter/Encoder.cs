using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Converter.Modules.Utils;

namespace String_Converter.Modules.Converter
{
    class Encoder
    {
        /*
         * This module functions like this: get the
         * string to encode...Simple. It's like the
         * SimpleParser.cs module, this module requires
         * a source string to parse and encode.
         */
        private string source;
        private string modStr;
        private StringBuilder sb;
        private byte[] bytes;

        // Classes
        private ConsoleUtils utils = new ConsoleUtils();

        /*
         * Unlike the parser module, this default constructor contains a set
         * default value. This value is what i like to call as test string.
         * In this case, this is valid since I can run a default test string
         * to make sure everything works.
         */
        public Encoder()
        {
            source = "This is a test string to encode.";
        }
        /**
         * The OLC of the Encoder module. As with all of OLC's within my programs
         * and other programs, sets the source string to encode to global value
         * thus giving access to the string throughout the module.
         * 
         * <param name="source">The source string to encode.</param>
         */
        public Encoder(string source)
        {
            this.source = source.Trim();
        }
        /**
         * This constructor is meant to set the source string to encode thus also
         * overriding the default source string set by the default constructor.
         * Whatever string is passed through this setter will override the default
         * value of the default constructor.
         * 
         * <param name="source">The source string to encode.</param>
         */
        public void SetSourceString(string source)
        {
            this.source = source;
        }
        /*
         * This functions purpose is to take the source string and convert it
         * to hexadecimal format. The source string will be output to the string
         * print function.
         */
        public void EncodeToHex()
        {
            // Initialize string builder
            sb = new StringBuilder();

            // Get the strings byte stream
            bytes = Encoding.Unicode.GetBytes(source);

            // For each byte in the stream, append that value into the builder using the X2 format
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            // Output the result
            utils.PrintGoldString("\n\"" + source + "\"\nString in hexadecimal is:\n" + sb.ToString() + "\n");
        }
        /*
         * This functions purpose is to take the source string and convert it
         * to binary format.
         */
        public void EncodeToBinary()
        {
            // Initialize string builder
            sb = new StringBuilder();

            // For each data byte stream [2] in the source string, append that data using [2][x] method
            foreach (char c in source.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }

            // Output the result
            utils.PrintGoldString("\n\"" + source + "\"\nString in binary is:\n" + sb.ToString() + "\n");
        }
        /*
         * This functions purpose is to take the source string and comvert it
         * to base64 format.
         */
        public void EncodeToBase64()
        {
            // Simple object structure initializer
            bytes = Encoding.UTF8.GetBytes(source);

            // Set the encoded bytes to string variable as string value
            modStr = Convert.ToBase64String(bytes);

            // Output the resulting encoded string
            utils.PrintGoldString("\n\"" + source + "\"\nString in base64 is:\n" + modStr + "\n");
        }
    }
}
