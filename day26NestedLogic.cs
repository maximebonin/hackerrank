using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    const int DAILY_FINE = 15;
    const int MONTHLY_FINE = 500;
    const int YEARLY_FINE = 10000;
    
    public static int calculateLateFee(int[] p_DueDate, int[] p_ReturnedDate)
    {
        DateTime expected = new DateTime(p_DueDate[2], p_DueDate[1], p_DueDate[0]);
        DateTime returned = new DateTime(p_ReturnedDate[2], p_ReturnedDate[1], p_ReturnedDate[0]);
        
        int fine = 0;
        
        if(returned <= expected) // comparing DateTime is simpler ...
        {
            
        }
        else
        {
            if((p_ReturnedDate[1] <= p_DueDate[1]) && (p_ReturnedDate[2]<=p_DueDate[2]))
            {
                int days = p_ReturnedDate[0] - p_DueDate[0];
                
                fine = days * DAILY_FINE;
            }
            else
            {
                if(p_ReturnedDate[2] <= p_DueDate[2])
                {
                    int months = p_ReturnedDate[1] - p_DueDate[1];
                    
                    if(months > 0)
                    {
                            fine = months * MONTHLY_FINE;
                    }
                }
                else
                {
                    int years = p_ReturnedDate[2] - p_DueDate[2];
                    
                    fine = YEARLY_FINE;
                }
            }
        }
        
        return fine;
    }
    
    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] returnedDate = Array.ConvertAll(arr_temp,Int32.Parse);
        
        string[] arr_temp2 = Console.ReadLine().Split(' ');
        int[] dueDate = Array.ConvertAll(arr_temp2,Int32.Parse);
        
        Console.WriteLine(calculateLateFee(dueDate, returnedDate));
    }
}