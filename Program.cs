using System;
using System.Collections.Generic;

namespace ProblemsetQ1
{

    class Program
    {
        //The first line has two space-separated integers, n and k,
        static int n, k;
        //Non-positive arrival time
        static int arrival;
        static List<string> res = new List<string>();

        static void Main(string[] args)
        {
            //First Constraint
            Console.WriteLine("Enter the Number of Test Cases:");
            // The first line of input contains t, the number of test cases.
            int t = Convert.ToInt32(Console.ReadLine());
            
            if (t >= 1 && t <= 10)
            {

                for (int i = 0; i < t; i++)
                {
                    //Second Constraint
                    Console.WriteLine("Enter n( the number of students) and k(the threshold number of students) values:");
                    string[] n_k = Console.ReadLine().Split(' ');
                    //the number of students
                    n = Convert.ToInt32(n_k[0]);
                    //the threshold number of students
                    k = Convert.ToInt32(n_k[1]);
                    if (n >= 1 && n <= 1000)
                    {
                        if (k >= 1 && k <= n)
                        {
                            Console.WriteLine("Enter the Arrival Time of Students:");
                            string[] temp = Console.ReadLine().Split(' ');
                            int[] a = Array.ConvertAll(temp, Int32.Parse);

                            if (a.Length == n)
                            {
                                angryProfessor(k, a);
                            }
                            // Condition that states if a != n
                            else
                            {
                                Console.WriteLine("Number of Students not equal to N");
                            }
                        }
                        //For invalid value of k
                        else 
                        {
                            Console.WriteLine("Invalid Threshold Number. The value should be in range " + n);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number of Students not in range");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("the given value, Number of Test cases, should be between 1 and 10");
            }

            Console.WriteLine("Class status?");
            foreach (string i in res)
            {
                Console.WriteLine(i);
            }
        }
        //angryProfessor function It must return YES if class is cancelled, or NO otherwise
        static void angryProfessor(int threshold, int[] std)
        {

           
            for (int i = 0; i < n; i++)
            {
                if (std[i] <= 0 && std[i] > -100)
                {
                    arrival += 1;
                }

                else if (std[i] > 0 && std[i] <= 100)
                {
                    arrival += 0;
                }
                else
                {
                    Console.WriteLine("Arrival Time should be in the range of -100 or more than 100");
                }
            }
            if (arrival <= k)
            {

                res.Add("Yes");
            }
            else
            {
                res.Add("No");
            }
        }


    }
}