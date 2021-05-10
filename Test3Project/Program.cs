using System;
using System.Collections.Generic;

namespace Test3Project
{
    class Program
    {
        //1
        void DivisableBySeven()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Numbers divisible by 7 are");
            for (int j = 0; j  < arr.Length; j ++)
            {
                if(arr[j]%7 == 0)
                {
                    Console.WriteLine(arr[j]);
                }
            }
        }
        //2
        void MinAndMaxPrime()
        {
            Console.WriteLine("Please enter the minimum number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the maximum number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers between " + num1 + " and " + num2 + " are ");
            if (num1 > num2)
            {
                for (int i = num1; i < num2; i++)
                {
                    int count = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            count += 1;
                            break;
                        }
                    }
                    if (count == 0 & i != 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
        //3
        void RepetationOfNumbers()
        {
            int num1 = 0;
            List<int> list = new List<int>();
            while (num1 >= 0)
            {
                Console.WriteLine("Please enter the numbers:");
                num1 = Int32.Parse(Console.ReadLine());
                list.Add(num1);
            }
            Console.WriteLine("The Repeating numbers are");
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if(list[i] == list[j] && i != j)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
            }
        }
        //4
        void Sorting()
        {
            int num1 = 0;
            List<int> list = new List<int>();
            while (num1 != 0)
            {
                Console.WriteLine("Please enter the numbers:");
                num1 = Int32.Parse(Console.ReadLine());
                list.Add(num1);
            }
            Console.WriteLine("The sorting numbers are");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        //5
        void UserNameAndPassword()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the user name:");
                string Username = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                string password = Console.ReadLine();
                if (Username == "Admin" && password == "admin")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine("Login failed try again!!!!");
                    Console.WriteLine("Invalid username or password");
                    count += 1;
                }
            }
            if (count >= 3)
            {
                Console.WriteLine("Account closed");
                Console.WriteLine("Sorry you have already tried 3 times");
            }
            else
            {
                Console.WriteLine("Loged in successfully");
            }
        }
        //6
        void CowsAndBulls()
        {
            string[] arr = { "kite","four","neat","play","goal" };
            int cow = 0 , bulls = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Pleaes enter the guess word");
                string GuessWord = Console.ReadLine();
                string word = arr[i];
                for (i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[i])
                    {
                        cow += 1;
                    }
                    else
                    {
                        for (int j = 0; j < GuessWord.Length; j++)
                        {
                            if (word[i] == GuessWord[j] && i != j)
                            {
                                bulls += 1;
                            }
                        }
                    }
                }
                    
                Console.WriteLine("Cows score " + cow + " Bulls score " + bulls);
                if(cow == 4 && bulls == 0)
                {
                    Console.WriteLine("You won!!!!!!!");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            }
        }
        //7
        void CardValidation()
        {
            Console.WriteLine("Enter the credit card number");
            string num1 = Console.ReadLine();
            string RevrerseString = string.Empty;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                RevrerseString += num1[i];
            }

            Console.WriteLine(RevrerseString);

            int num;
            int num3;
            int sum = 0;
            int num4 = 0;
            int num5 = 0;
            for (int i = 0; i < RevrerseString.Length; i++)
            {
                char v = RevrerseString[i];
                num = (int)Char.GetNumericValue(v);
                if (i % 2 == 0)
                {
                    num3 = num * 2;
                    num5 += num3;
                }

                else
                {
                    num4 += num;
                }
                sum = num5 + num4;
            }
            if (num1.Length == 16 || (sum % 10 == 0))
            {
                Console.WriteLine("Valied Credit card");
            }
            else
            {
                Console.WriteLine("InValied Credit card");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.DivisableBySeven();
            //program.MinAndMaxPrime();
            //program.RepetationOfNumbers();
            //program.Sorting();
            //program.UserNameAndPassword();
            //program.CardValidation();
            program.CowsAndBulls();
        }
    }
}
