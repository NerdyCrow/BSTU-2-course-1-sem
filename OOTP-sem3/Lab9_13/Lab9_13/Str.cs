using System.Text.RegularExpressions;


namespace Lab9_13
{
    class Str
    {
        public static string RemovePunctuation(string str)
        {
            return Regex.Replace(str, "[.,;:]", string.Empty);
        }

        public static string AddSymbol(string str)
        {
            return str += "END";
        }

        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string ToLower(string str)
        {
            return str.ToLower();
        }

        public static string RemoveSpace(string str)
        {
            return str.Replace(" ", string.Empty);
        }
    }
}
