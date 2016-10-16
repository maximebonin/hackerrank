using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution {

   
    
    public static void printNames(string[] p_FirstName, string[] p_Email)
    {
        List<string> firstNamesThatMatches = new List<string>();
        
        Regex endsWith = new Regex (@"\b\w+(@gmail.com\b)");
        
        for(int i = 0 ; i < p_FirstName.Length ; i++)
        {
            Match match = endsWith.Match(p_Email[i]);
            
            if(match.Success)
            {
                firstNamesThatMatches.Add(p_FirstName[i]);
            }
        }
        
        firstNamesThatMatches.Sort();
        
        foreach(string name in firstNamesThatMatches)
        {
            Console.WriteLine(name);
        }
    }
    
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        
        string[] firstNames = new string[N];
        string[] emails = new string[N];
        
        for(int a0 = 0; a0 < N; a0++)
        {
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];
            
            firstNames[a0] = firstName;
            emails[a0] = emailID;
        }
        
        printNames(firstNames, emails);
    }
}