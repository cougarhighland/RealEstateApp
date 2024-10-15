namespace UtilitiesLib
{
    public class StringConverter
    {
        public static bool StringToInt(string str)
        {
            return int.TryParse(str, out var result);
        }
    }
}
