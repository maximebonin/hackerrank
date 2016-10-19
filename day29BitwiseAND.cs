// very basic answer ...


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    
    public static void print(int p_N, int p_K)
    {
        int answer = 0;
        int result = 0;
        
        for(int i = 1 ; i < p_N * 2 ; i++)
        {
            for(int j = 1 ; i < p_N -1 ; j++)
            {
                int variable = i+j;
                
                if(!(variable > p_N))
                {
                    result = i & variable;
                    
                    if((result > answer) && (result < p_K))
                    {
                        answer = result;
                    }
                }
                else
                {
                    break;
                }
            }
        }
                       
           Console.WriteLine(answer);
    }
    
    static void Main(String[] args) 
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            
            print(n,k);
        }
    }
}