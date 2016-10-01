using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    
    
    private static int firstNumber(int [] p_Array)
    {
        return p_Array[0];
    }
    private static int lastNumber(int[] p_Array)
    {
        return p_Array[p_Array.Length -1];
    }
    
    private static void swap(int[] p_Array, int p_A, int p_B) // I need the whole array !!
    {
        int temp = p_Array[p_A];
        p_Array[p_A] = p_Array[p_B];
        p_Array[p_B] = temp;
    }
    
    private static int sort(int[] p_Array)
    {
        int finalNumberSwaps=0;
        
        for(int i = 0 ; i < p_Array.Length ; i++)
        {
            int numberSwaps=0;
            
            
            for(int j = 0 ; j < p_Array.Length - 1 ; j++)
            {
               if(p_Array[j] > p_Array[j+1])
               {
                   Solution.swap(p_Array, j, j+1);
                   numberSwaps++;
               }
            }
            if(numberSwaps == 0)
            {
                break;
            }
            
            finalNumberSwaps += numberSwaps;
        }
        
        return finalNumberSwaps;
    }
    
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        int numberSwaps = Solution.sort(a);
        int firstNumber = Solution.firstNumber(a);
        int lastNumber = Solution.lastNumber(a);
        
        Console.WriteLine("Array is sorted in "+numberSwaps+" swaps.");
        Console.WriteLine("First Element: "+ firstNumber);
        Console.WriteLine("Last Element: "+ lastNumber);
    }
}