namespace UtilitiesLib
{
    public class StringConverter
    {
        // Convert a string to an integer
        public static bool StringToInt(string str, out int result)
        {
            return int.TryParse(str, out result);
        }

        // Convert a string to a decimal
        public static bool StringToDecimal(string str, out double result)
        {
            return double.TryParse(str, out result);
        }
        // Overloaded method: Convert a string to an integer and check if it's within the specified range otherwise return lowLimit
        public static bool StringToInt(string str, out int result, int lowLimit, int highLimit)
        {
            if(int.TryParse(str,out result) && result >= lowLimit && result <= highLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Overloaded method: Convert a string to an decimal and check if it's within the specified range otherwise return lowLimit
        public static bool StringToDecimal(string str, out double result, int lowLimit, int highLimit)
        {
            if (double.TryParse(str, out result) && result >= lowLimit && result <= highLimit)
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
