using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    private static void printReverse(int[] p_Array)
    {
       for(int j = p_Array.Length-1 ; j >=0;j--)
        {
            Console.Write(p_Array[j]+" ");
        }
    }
    
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        printReverse(arr);
    }
}