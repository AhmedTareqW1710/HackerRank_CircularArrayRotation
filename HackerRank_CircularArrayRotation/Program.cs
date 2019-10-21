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

    // Complete the circularArrayRotation function below.
    static int[] circularArrayRotation(int[] a, int k, int[] queries)
    {
        int tempValue = 0;
        List<int> arr = new List<int>();
        arr = a.ToList();        
        List<int> result = new List<int>();

        for (int i = 0; i < k; i++)
        {
            tempValue = arr.Last();
            arr.Insert(0,tempValue);
            arr.RemoveAt(arr.Count - 1);
        }

        for (int j = 0; j < queries.Length; j++)
        {

            result.Add(arr[queries[j]]);
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {

        string[] nkq = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nkq[0]);

        int k = Convert.ToInt32(nkq[1]);

        int q = Convert.ToInt32(nkq[2]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] queries = new int[q];

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        int[] result = circularArrayRotation(a, k, queries);

        Console.WriteLine(string.Join("\n", result));
        Console.ReadKey();


    }
}
