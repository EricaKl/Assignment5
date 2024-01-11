using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment5
{
    public  class StringFunctions
    {
        public int NoOfCharInSentence(string sentence)
        {
           
            return sentence.Length;
            
        }

        public bool CheckForPallindrome(string sentence)
        {
            //
            //string result= (string)sentence.Reverse();
            string result ="";
            bool flag = false;
            try
            {
                
                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    result += sentence[i];
                }

                if (sentence.ToUpper() == result.ToUpper())
                {
                    flag = true;
                   // return true;
                }
                else
                {
                    flag = false;
                    //return false;
                }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }
        public string ReverseSentence(string sentence)
        {
            string result = "";
            try
            {
                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    result += sentence[i];
                }
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
           
            return result;

        }

        public void FindAllTypesChar(string sentence/*out int vowels, out int consonants , out int integers, out int special*/)
        {
           
            //char[] arr = sentence.ToCharArray();
            int consonants = 0;
            int vowels = 0;
            int integers = 0;
            int special = 0;
            try
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] >= 'A' && sentence[i] <= 'Z' || sentence[i] >= 'a' && sentence[i] <= 'z')
                    {
                        if (sentence[i] == 'A' || sentence[i] == 'a' || sentence[i] == 'E' || sentence[i] == 'e'
                            || sentence[i] == 'I' || sentence[i] == 'i' || sentence[i] == 'O' || sentence[i] == 'o' ||
                            sentence[i] == 'U' || sentence[i] == 'u')
                        {
                            vowels++;
                        }
                        else
                        {
                            consonants++;
                        }

                    }
                    if (sentence[i] >= '1' && sentence[i] <= '9')
                    {
                        integers++;
                    }
                    if (sentence[i] == '@' || sentence[i] == ' ' || sentence[i] == '#' || sentence[i] == '$')
                    {
                        special++;
                    }

                }
                Console.WriteLine("No of integers : " + integers);
                Console.WriteLine("No of Vowels : " + vowels);
                Console.WriteLine("No of Consonants : " + consonants);
                Console.WriteLine("No of Special Characters : " + special);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
        }

        public string StringToUpper(string sentence)
        {
            return sentence.ToUpper();

        }
        public string StringToProper(string sentence)
        {
            var textinfo = CultureInfo.CurrentCulture.TextInfo;
            return textinfo.ToTitleCase(sentence);

        }

        public string CombineTwoSentences(string sentence1 , string sentence2)
        {
           

            return sentence1 = sentence1 + " " +sentence2;

        }

        public string RemoveExtraSpaces(string sentence)
        {
            return Regex.Replace(sentence, @"\s+", " ").Trim();
        }

        public int CountNoOfWords(string sentence)
        {
           // char[] arr = sentence.ToCharArray();
            int count = 0;
            try
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i].Equals(' '))
                    {
                        count++;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;
        }

        public bool FindSubstring(string sentence, string key)
        {
            bool flag = false;
            try
            {
                if (sentence.Contains(key))
                {
                    flag = true;
                    //return true;
                }
                else
                {
                    flag = false;
                    //return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return flag;
        }

        public int OccurrenceSubString(string sentence, string Key)
        {
            int count = 0;
            try
            {
                for (int i = 0; i < sentence.Length - Key.Length + 1; i++)
                {
                    if (sentence.Substring(i, Key.Length) == Key)
                    {
                        count++;
                    }
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
           
            return count;
        }



    }
}
