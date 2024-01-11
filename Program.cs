using Assignment5;
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main()
    {
        int choice = 0;
        char ch;
       
        do
        {
            Console.WriteLine("********** Wish To Perform :) ************");
            int initialcoice;
            Console.WriteLine("1.Numeric Functions");
            Console.WriteLine("2.StringFunctions");

            initialcoice= int.Parse(Console.ReadLine());
            switch(initialcoice)
            {


            
                case 1:
                    {
                        NumericFunctions c = new NumericFunctions();
                        Program p = new Program();  
                        Console.WriteLine(".........Menu...........");
                        Console.WriteLine("1.Addition");
                        Console.WriteLine("2.Subtraction");
                        Console.WriteLine("3.Multiply");
                        Console.WriteLine("4.Divison");
                        Console.WriteLine("5.Max Number");
                        Console.WriteLine("6.Min Number");
                        Console.WriteLine("7.Number is Even?");
                        Console.WriteLine("8.Number is Odd?");
                        Console.WriteLine("9.Number is Prime");
                        Console.WriteLine("10.Display all even number within a given range");
                        Console.WriteLine("11.Display all odd number within a given range");
                        Console.WriteLine("12.Display all prime number within a given range");
                        Console.WriteLine("13.Display table of an entered no");
                        Console.WriteLine("14.Display tables 1 to 10 of all no.s within a given range");
                        Console.WriteLine("15.Display tables from a given range of all no.s within a given range ");
                        Console.WriteLine("16.Reverse a number");


                        Console.WriteLine("Mention your choice");
                        choice = int.Parse(Console.ReadLine());
                        switch(choice)
                        {
                            case 1:
                                {
                                    
                                    Console.WriteLine("How many numbers you want to add");
                                    int size = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter numbers you want to add");
                                    int[] list = new int[size];
                                    for (int i = 0; i < size; i++)
                                    {
                                        list[i] = int.Parse(Console.ReadLine());
                                    }
                                    var result = c.Add(list);
                                    Console.WriteLine($"Result is {result}");
                                    break;
                                }

                                case 2:
                                {
                                    Console.WriteLine("How many numbers you want to subtract");
                                    int size = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter numbers you want to subtract");
                                    int[] list = new int[size];
                                    for (int i = 0; i < size; i++)
                                    {
                                        list[i] = int.Parse(Console.ReadLine());
                                    }
                                    var result = c.Sub(list);
                                    Console.WriteLine($"Result is {result}");
                                    break;


                                }
                                case 3:
                                {
                                    Console.WriteLine("How many numbers you want to multiply");
                                    int size = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter numbers you want to multiply");
                                    int[] list = new int[size];
                                    for (int i = 0; i < size; i++)
                                    {
                                        list[i] = int.Parse(Console.ReadLine());
                                    }
                                    var result = c.Mul(list);
                                    Console.WriteLine($"Result is {result}");
                                    break;

                                }

                                 case 4:
                                {
                                    Console.WriteLine("Enter Dividend");
                                    int dividend = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Divisor");
                                    int divisor = int.Parse(Console.ReadLine());
                                    var result = c.Div(dividend, divisor);
                                    Console.WriteLine($"Result is {result}");
                                    break;
                                }

                                case 5:
                                {
                                    Console.WriteLine("How many numbers you want to insert");
                                    int size = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter numbers");
                                    double[] list = new double[size];
                                    for (int i = 0; i < size; i++)
                                    {
                                        list[i] = int.Parse(Console.ReadLine());
                                    }
                                    var result = c.Max(list);
                                    Console.WriteLine($"Result is {result}");
                                    break;
                                }

                                case 6:
                                {
                                    Console.WriteLine("How many numbers you want to insert");
                                    int size = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter numbers");
                                    double[] list = new double[size];
                                    for (int i = 0; i < size; i++)
                                    {
                                        list[i] = double.Parse(Console.ReadLine());
                                    }
                                    var result = c.Min(list);
                                    Console.WriteLine($"Result is {result}");
                                    break;

                                }

                                case 7:
                                {
                                    Console.WriteLine("Enter a number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    var result = c.IsEven(n1);
                                    Console.WriteLine($"Result is {result}");
                                    break;
                                }

                                case 8:
                                {
                                    Console.WriteLine("Enter a number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    var result = c.IsOdd(n1);
                                    Console.WriteLine($"Result is {result}");
                                    break;
                                }

                                case 9:
                                {
                                    Console.WriteLine("Enter a number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    var result = c.IsPrime(n1);
                                    Console.WriteLine($"Result is {result}");
                                    break;

                                }
                            case 10:
                                {
                                    Console.WriteLine("Enter start number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter end number");
                                    int n2 = int.Parse(Console.ReadLine());
                                    p.FinddEven(n1, n2);
                                    break;

                                }
                            case 11:
                                {
                                    Console.WriteLine("Enter start number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter end number");
                                    int n2 = int.Parse(Console.ReadLine());
                                    p.FindOdd(n1, n2);
                                    break;

                                }
                            case 12:
                                {
                                    Console.WriteLine("Enter start number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter end number");
                                    int n2 = int.Parse(Console.ReadLine());
                                    p.FindPrime(n1, n2);
                                    break;

                                }
                            case 13:
                                {
                                    Console.WriteLine("Enter  number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    p.DisplayTable(n1);
                                    break;

                                }
                            case 14:
                                {
                                    Console.WriteLine("Enter  range");
                                    int n1 = int.Parse(Console.ReadLine());
                                    p.DisplayTable1To10(n1);
                                    break;

                                }
                            case 15:
                                {
                                    Console.WriteLine("Enter start number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter end number");
                                    int n2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter range");
                                    int range = int.Parse(Console.ReadLine());
                                    p.DisplayTableRange(n1, n2, range);
                                    break;

                                }
                            case 16:
                                {
                                    Console.WriteLine("Enter start number");
                                    int n1 = int.Parse(Console.ReadLine());
                                    p.ReverseNumber(n1);
                                    break;

                                }
                        }
                        break;
                    }
                    case 2:
                    {
                        StringFunctions s = new StringFunctions();
                        Console.WriteLine(".........Menu...........");
                        Console.WriteLine("1.Find no of Characters in a sentence");
                        Console.WriteLine("2.Check sentence is Pallindrome?");
                        Console.WriteLine("3.Reverse a Sentence");
                        Console.WriteLine("4.Find no of Vowels, Conosnants, Integers, Special char");
                        Console.WriteLine("5.Change to upper case");
                        Console.WriteLine("6.Chnage to Proper case");
                        Console.WriteLine("7.Combine two sentences");
                        Console.WriteLine("8.Remove Extra spaces in Sentence");
                        Console.WriteLine("9.Count no of words in a sentence");
                        Console.WriteLine("10.Search a Substring in a sentence");
                        Console.WriteLine("11.Ocurrences of a Substring in a sentence");


                        Console.WriteLine("Mention your choice");
                        choice = int.Parse(Console.ReadLine());

                        switch(choice)
                        {
                            case 1:
                            {
                                Console.WriteLine("Enter Sentence");
                                string sentence = Console.ReadLine();
                                var result = s.NoOfCharInSentence(sentence);
                                Console.WriteLine("No of character in string is " + result);
                                break;
                            }
                            case 2:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    string sentence = Console.ReadLine();
                                    var result = s.CheckForPallindrome(sentence);
                                    Console.WriteLine("Sentence is Pallindrome " + result);
                                    break;
                            }
                            case 3:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    var result = s.ReverseSentence(sentence);
                                    Console.WriteLine("Reverse of string " + result);
                                    break;
                            }
                            case 4:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    s.FindAllTypesChar(sentence);
                                    break;
                            }
                            case 5:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    var result = s.StringToUpper(sentence);
                                    Console.WriteLine("Changed to Upper case " + result);
                                    break;
                            }
                            case 6:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    var result = s.StringToProper(sentence);
                                    Console.WriteLine("Changed to Proper case " + result);
                                    break;
                            }
                            case 7:
                            {
                                    Console.WriteLine("Enter Sentence1");
                                    var sentence1 = Console.ReadLine();
                                    Console.WriteLine("Enter Sentence2");
                                    var sentence2 = Console.ReadLine();
                                    var result = s.CombineTwoSentences(sentence1, sentence2);
                                    Console.WriteLine("String is " + result);
                                    break;
                            }
                            case 8:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    var result = s.RemoveExtraSpaces(sentence);
                                    Console.WriteLine("After Removing extra spaces from string " + result);   
                                    break;
                            }
                            case 9:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    var result = s.CountNoOfWords(sentence);
                                    Console.WriteLine("No of words in a string " + (result+1));
                                    break;
                            }
                            case 10:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    Console.WriteLine("Enter string you want to search in sentence");
                                    var key = Console.ReadLine();
                                    var result = s.FindSubstring(sentence, key);
                                    Console.WriteLine("Substring present in string " + result);
                                    break;
                            }
                            case 11:
                            {
                                    Console.WriteLine("Enter Sentence");
                                    var sentence = Console.ReadLine();
                                    Console.WriteLine("Enter string whose occurrence you want to know");
                                    var key = Console.ReadLine();
                                    var result = s.OccurrenceSubString(sentence, key);
                                    Console.WriteLine("No of Ocurrences of a string "+ result);
                                    break;
                            }
                            
                        }
                        break;

                    }
            }
            Console.WriteLine("Do you wish to choose again (y/n)");
            ch = char.Parse(Console.ReadLine());
        } while (ch == 'y' || ch == 'Y');



    }
}

    public static class ExtendClass
    {
        public static void FinddEven(this Program p , int startnumber, int endnumber)
        {
        Console.WriteLine("Even numbers within a given range");
            for(int i = startnumber; i < endnumber; i++)
            {
            if (i%2==0)
                {
                Console.WriteLine(i);
                }
            }
        
        }

        public static void FindOdd(this Program p , int startnumber, int endnumber)
        {
            Console.WriteLine("Odd numbers within a given range");
            for(int i =startnumber;i<endnumber;i++)
            {
            if (i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void FindPrime(this Program p , int startno , int endno)
        {

            int prime = 0;
        for (int i = startno; i < endno; i++)
        {
            prime = 0;
            if (i > 1)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = 1; 
                            break;
                    }
                }
                if (prime == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        }

        public static void DisplayTable(this Program p , int number )
        {
            Console.WriteLine("Table of Entered no is ");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }



        public static void DisplayTable1To10(this Program p, int range)
        {
            Console.WriteLine($"Display table 1 to of your specified range");
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= range; i++)
                {
                    Console.WriteLine($"{j} X {i} = {j * i}");
                }
            }
        }
        public static void DisplayTableRange(this Program p ,int startnumber , int endnumber,  int range)
            {
                Console.WriteLine($"Display table 1 to of your specified range");
                for (int j = startnumber; j <= endnumber; j++)
                {
                    for (int i = 1; i <= range; i++)
                    {
                     Console.WriteLine($"{j} X {i} = {j * i}");
                    }
                }
            }

            public static void ReverseNumber(this Program p, int number)
            {

                int rem = 0;
                int sum = 0;
                while(number > 0)
                {
                    rem = number % 10;
                    sum = (sum * 10) + rem ;
                    number = number / 10;
                }
                Console.WriteLine("Reverse of given number is " + sum);
            }
}

