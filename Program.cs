using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int counter = 0;
        for(int i = 0; i < ar.Length; i++)
        {
            for(int j = 0; j < ar.Length; j++)
            {
                if(i < j)
                {
                    //Console.Write("array instance: " + i + ", array instance: " + j + " = ");
                    //Console.WriteLine(ar[i] + ar[j]);
                    int result = ar[i] + ar[j];
                    if(result % k == 0)
                    {
                        counter++;
                        //Console.WriteLine("\n\nTHIS INSTANCE IS DIVISIBLE BY " + k + "\n\n");
                    }
                }

            }
        }


        return counter;

    }

    static void Main(string[] args)
    {
        //convert the readline into string array
        string[] nk = Console.ReadLine().Split(' ');
        //the integer length of array
        int n = Convert.ToInt32(nk[0]);
        //the integer to divide the pair sum by
        int k = Convert.ToInt32(nk[1]);

        //the array of integers
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

        //the result is the number of valid pairs in which the sum of the pair can be divided by the value of k
        int result = divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);
        Console.WriteLine("\n\nPress any key to exit");
        Console.ReadLine();

    }
}
