using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        
        int firstSum = 0;
        //first sum
        for(int i=0; i<n; i++){
            firstSum = firstSum + a[i][i];
        }
        
        int secondSum = 0;
        //second sum
        int f = 0;
        int s = n-1;
        for(int i=0; i<n; i++){
            secondSum = secondSum + a[f][s];
            f++;
            s--;
        }
        
        Console.Write(Math.Abs(firstSum - secondSum));
    }
    
}
