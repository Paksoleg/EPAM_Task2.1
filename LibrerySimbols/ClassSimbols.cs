namespace LibrerySimbols
{
    public class StringIsCollectionChars
    {
        public char[] MassChars;
        public StringIsCollectionChars(char[] myString) => MassChars = myString;
        public bool IsDifferentOrEquals(char[] firstString, char[] otherString)
        {
            if (firstString.Length != otherString.Length)
                return false;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] != otherString[i])
                return false;
            }
            return true;
        }
        public char[] ConcatStrings(StringIsCollectionChars secondString)
        {
            var res = new char[MassChars.Length + secondString.MassChars.Length];
            MassChars.CopyTo(res, 0);
            secondString.MassChars.CopyTo(res, MassChars.Length);
            return res;
        }
        public int LookingForSymbol(char c)
        {
            for (int i = 0; i < MassChars.Length; i++)
            {
                if (c == MassChars[i])
                    return i;
            }
            return -1;
        }
        public char[] ToCharMass()
        {
            char[] arr = new char[MassChars.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = MassChars[i];
            }
            return arr;
        }
        public override string ToString() => new string(MassChars);
        public static double ToDouble(StringIsCollectionChars convertString)
        {
            double result = Convert.ToDouble(convertString.ToString());
            return result;
        }
        public char this[int index]
        {
            get
            {
                return MassChars[index];
            }
            set
            {
                MassChars[index] = value;
            }
        }
    }
}
