using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    public static bool isPrime(double p_Number)
    {
        if(p_Number == 1)
        {
            return false;
        }
        
        for(int i = 2 ; i < Math.Sqrt(p_Number); i++) // Primality test : simple method from Wikipedia
        {
            if(p_Number % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
    
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0 ; i < n ; i++)
        {
            double m = Convert.ToDouble(Console.ReadLine());
            
            if(isPrime(m))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}