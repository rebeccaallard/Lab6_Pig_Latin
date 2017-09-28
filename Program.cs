using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Pig_Latin_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            word = word.ToLower();
            Console.WriteLine("word is " + word);


            // Use ToCharArray to convert string to array.
            char[] array = word.ToCharArray();

            // Loop through array.
            for (int i = 0; i < array.Length; i++)
            {
                // Get character from array.
                char letter = array[i];
                // Display each letter.
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }
            
            //Identify vowels and consonants

            //Find index of first vowel and use it to put the consonants
            //from the beginning of the word onto the end of the word,
            //along with "ay"

            for (int i = 0; i < word.Length(); i++)

            
            //static String doStuff(String word)???
            {
                String vowels = "aeiouAEIOU";
                //for (int i = 0; i < word.length(); i++)
                {
                    //found this piece of code in an example in StackOverflow
                    //but don't really know what it's doing
                    if (vowels.contains("" + word.charAt(i)))
                    {
                        String prefix = word.substring(0, i);
                        String suffix = word.substring(i);
                        word = suffix + prefix + "ay";
                        break;
                    }
                }
                //return word;???
            }

        }
    }
}
