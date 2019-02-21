using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }


    // Gender enum underlying type is now short and the value starts at ONE
    public enum Gender1 : short
    {
        Unknown = 1,
        Male = 2,
        Female = 3
    }


    // Enum values need not be in sequential order. Any valid underlying type value is allowed 
    public enum Gender2 : short
    {
        Unknown = 10,
        Male = 22,
        Female = 35
    }


    // This enum will not compile, bcos the maximum value allowed for short data type is 32767. 
    public enum Gender3 : short
    {
        Unknown = 10,
        Male = 3276,
        Female = 35
    }

    public enum Season : int
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }


    class _47ENUMcs
    {
        public static void Main()
        {
            int[] Values = (int[])Enum.GetValues(typeof(Gender));
            Console.WriteLine("Gender Enum Values");
            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            string[] Names = Enum.GetNames(typeof(Gender));
            Console.WriteLine("Gender Enum Names");
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }

            Gender gender = (Gender)Season.Winter;
            Console.ReadLine();
        }
    }
}