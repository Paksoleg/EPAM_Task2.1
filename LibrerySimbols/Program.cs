// See https://aka.ms/new-console-template for more information

namespace LibrerySimbols 
{
    class Program 
{
        static void Main(string[] args)
        {
            char[] newYourChars = new char[12] { 'H', 'E', 'L', 'L', 'O', ',', 'W', 'O', 'R', 'L', 'D', '!'};
            char[] otherYourChars = new char[2] { '!' , '!' };

            StringIsCollectionChars firstChars = new StringIsCollectionChars(newYourChars);
            StringIsCollectionChars secondChars = new StringIsCollectionChars(otherYourChars);
            StringIsCollectionChars concatChars = new StringIsCollectionChars(firstChars.ConcatStrings(secondChars));

            Console.WriteLine(concatChars.ToString());
            Console.WriteLine(firstChars[6]);
            Console.WriteLine(firstChars[7]);
            Console.WriteLine(firstChars[8]);
            Console.WriteLine(firstChars[9]);
            Console.WriteLine(firstChars[10]);
        }
    }
}