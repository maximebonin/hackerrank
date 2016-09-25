using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    
    static void Main(String[] args) 
    {
        
        string aa = Console.ReadLine();
        int a = Int32.Parse(aa);
            
        string[] data = new string[a];
        
        for (int i = 0 ; i < a ; i​++​  )
        {
            data[i] = Console.ReadLine();
        }
        string bb = Console.ReadLine();
        int b = Int32.Parse(bb);
        
        string[] query = new string[b];
        
        for(int i = 0 ; i < b ; i​++​  )
        {
            query[i] = Console.ReadLine();
        }
                
        for(int i = 0 ; i < b ; i​++​  )
        {
            int howMuch = 0;
            
            for(int j = 0 ; j < a ; j​++  )
            {
                if(data[i] == query[i])
                {
                    howMuch++;
                }
            }
           Console.WriteLine(howMuch);
        }
    }
}