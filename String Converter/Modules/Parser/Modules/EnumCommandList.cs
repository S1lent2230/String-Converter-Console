using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Converter.Modules.Parser.Modules
{
    enum EnumCommandEncode
    {
        conv,
        convert,
        conv_str,
        convert_str,
        conv_string,
        convert_string,
        encode,
        ec,
        encode_str,
        ec_str,
        encode_string,
        ec_string
    }

    enum EnumCommandDecode
    {
        conv,
        convert,
        conv_str,
        convert_str,
        conv_string,
        convert_string,
        decode,
        dc,
        decode_str,
        dc_str,
        decode_string,
        dc_string
    }

    enum SQ2HexCommand
    {
        hex,
        hexadecimal,
        h2x,
        HEX,
        HEXADECIMAL,
        H2X
    }

    enum SQ2BinaryCommand
    {
        bin,
        binary,
        BIN,
        BINARY,
        Bin,
        Binary
    }

    enum SQ2Base64Command
    {
        b64,
        base64,
        B64,
        BASE64,
        Base64
    }
}
