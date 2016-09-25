using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    
    private static bool searching(string p_Data, string p_Query)
    {
        return p_Data == p_Query;
    }
    
    static void Main(String[] args) 
    {
        
        string aa = Console.ReadLine();
        int a = Int32.Parse(aa);
            
        string[] data = new string[1000];
        
        for (int i = 0 ; i < a ; i​++​  )
        {
            data[i] = Console.ReadLine();
        }
        string bb = Console.ReadLine();
        int b = Int32.Parse(bb);
        
        string[] query = new string[1000];
        
        for(int i = 0 ; i < b ; i​++​  )
        {
            query[i] = Console.ReadLine();
        }
                
        for(int i = 0 ; i < b ; i​++​  )
        {
            int howMuch = 0;
            
            for(int j = 0 ; j < a ; j​++  )
            {
                if(searching(data[j], query[i]))
                {
                    howMuch  ;
                }
            }
           Console.WriteLine(howMuch);
        }
    }
}