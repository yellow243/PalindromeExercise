using System;

namespace PalindromeExercise
{
    public class WordSmith
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsAPalindrome(string word)
        {
            {
                //reverse the word!!   
                var reversed = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i]; //reversed = reversed + word[i]
                }

                if (reversed == word)
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
}
