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
            Console.WriteLine("This is the Pig Latin Translator");

            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Enter a word: ");
                string word = Console.ReadLine();
                //word = word.ToLower();

                Console.WriteLine("word is " + word);

                //check if first letter is a vowel
                string firstletter = word;
                bool v = IsVowel(firstletter);

                if (v == true)
                {
                    string vowelWord = word + "way";
                    Console.WriteLine(vowelWord + " ");
                }
                else
                {
                    int beginEnd = 0;
                    char[] letters = word.ToCharArray();
                    foreach (char l in letters)
                    {
                        bool b = IsVowel(l);

                        if (b == true)
                        {
                            string var = PigLatin(word, beginEnd);
                            break;
                        }
                        else
                        {
                            beginEnd++;

                            //// Use ToCharArray to convert string to array.
                            //char[] array = word.ToCharArray();

                            //// Loop through array.
                            //for (int i = 0; i < array.Length; i++)
                            //{
                            //    // Get character from array.
                            //    char letter = array[i];
                            //    // Display each letter.
                            //    Console.Write("Letter: ");
                            //    Console.WriteLine(letter);
                            //}
                        }
                    }
                }

                run = Continue();

                public static string PigLatin(string s, int i)
                {
                    string wordFirstPart = s.Substring(0, i);
                    string wordRemaining = s.Substring(i, s.length - 1);
                    string translation = wordFirstPart + wordRemaining + "ay";
                    Console.WriteLine(translation);
                    return translation;
                }
            }
        }

            //Identify vowels and consonants

            //Find index of first vowel and use it to put the consonants
            //from the beginning of the word onto the end of the word,
            //along with "ay"


            //if (vowels.Contains("" + word.charAt(i)))
            //{
            //    String prefix = word.substring(0, i);
            //    String suffix = word.substring(i);
            //    word = suffix + prefix + "ay";
            //    break;
            //}
            //return word;???



            //Determine first vowel location
            {
                public static bool IsVowel(char c)
                {
                    string vowels = "aeiouAEIOU";
                    char[] vowelList = vowels.ToCharArray();

                    if (vowelList.Contains(c))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public static bool Continue()
                {
                    Console.WriteLine("Do you wish to Continue? y/n");
                    string input = Console.ReadLine();
                    input = input.ToLower();
                    bool goOn;
                    if (input == "y")
                    {
                        goOn = true;
                    }
                    else if (input == "n")
                    {
                        Console.WriteLine("Goodbye...");
                        goOn = false;
                    }
                    else
                    {
                        Console.WriteLine("I don't understand that, let's try again");
                        goOn = Continue();
                    }
                    return goOn;
                }
            }
        }

        //private static bool Continue()
        //{
        //    throw new NotImplementedException();
        //}

        //private static bool IsVowel(char l)
        //{
        //    throw new NotImplementedException();
        //}

        //private static bool IsVowel(string firstletter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

}
