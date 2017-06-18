using System;
using System.Collections.Generic;
using System.IO;



class Solution {
  
    static void displayPathtoPrincess(int n, String [] grid){
        int[] PrincessPosition = new int[2];
        int[] MyPosition = new int[2];
        
       MyPosition[0] = (n - 1) / 2;
       MyPosition[1] = (n - 1) / 2;
        
       if ( grid[0][0] == 'p'){
           PrincessPosition[0] = 0;
           PrincessPosition[1] = 0;
       } else if (grid[0][n-1] == 'p'){
           PrincessPosition[0] = 0;
           PrincessPosition[1] = n - 1;
       } else if (grid[n-1][0] == 'p'){
           PrincessPosition[0] = n - 1;
           PrincessPosition[1] = 0;
       } else{
           PrincessPosition[0] = n - 1;
           PrincessPosition[1] = n - 1;
       }
        
        while (MyPosition[0] != PrincessPosition[0]){
            if(MyPosition[0] < PrincessPosition[0]){
                MyPosition[0] = MyPosition[0] + 1;
                Console.WriteLine("DOWN");
            }else{
                MyPosition[0] = MyPosition[0] - 1;
                Console.WriteLine("UP");
            }
        }
        
        while (MyPosition[1] != PrincessPosition[1]){
            if(MyPosition[1] < PrincessPosition[1]){
                MyPosition[1] = MyPosition[1] + 1;
                Console.WriteLine("RIGHT");
            }else{
                MyPosition[1] = MyPosition[1] - 1;
                Console.WriteLine("LEFT");
            }    
        }
     
    }
    
    static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}
​