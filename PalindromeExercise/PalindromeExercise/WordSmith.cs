using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string thisWord)
        {
            if (string.IsNullOrWhiteSpace(thisWord))
                return false;
            else
            {                
                int halflength = thisWord.Length / 2;       //Note that we're ignoring the middle letter if there are an odd number of characters.
                var myCopy = thisWord.ToLower();            //Also note that we're ignoring case.

                for (int i = 0; i < halflength; i++)
                    if (myCopy[i] != myCopy[myCopy.Length-i-1]) return false;
                return true;
            }
        }
    }
}
