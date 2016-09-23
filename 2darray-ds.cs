using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    private static int calculate(int[][] p_Array)
    {
        int highestTotal = -99999;
        
        for(int i = 0 ; i < 4 ; i++)
        {
            for(int j = 0 ; j < 4; j++)
            {
                int total = p_Array[i][j]+p_Array[i][j+1]+p_Array[i][j+2]+
                    p_Array[i+1][j+1]+p_Array[i+2][j]+p_Array[i+2][j+1]+
                    p_Array[i+2][j+2];
                
                if(total > highestTotal)
                {
                    highestTotal = total;
                }
             }
        }
        
        return highestTotal;
    }
    
    static void Main(String[] args) 
    {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++)
        {
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        
        Console.WriteLine(calculate(arr));
    }
}