using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalidrome(string input) 
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray) == input;
        }
    }
}
