namespace UtilitiesLib
{
    public class FromStringToInt
    {
        public static int ConvertStringToInteger(string Num, int lowLimit, int highLimit)
        {
            bool b = Int32.TryParse(Num, out int Value);
            if (Value > lowLimit && Value < highLimit && b) return Value;
            return 0;
        }

        public static float ConvertStringToFloat(string Num, int lowLimit, int highLimit)
        {
            bool b = float.TryParse(Num, out float Value);
            if (Value > lowLimit && Value < highLimit && b) return Value;
            return 0;
        }

    }
}