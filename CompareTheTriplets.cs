using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
        // Complete this function
        int [] scores = new int [2];
        
        //first comparison
        if(a0 > b0){
            //alice 1 point
            scores[0] = scores[0] + 1;
        }else if(b0 > a0){
            //bob 1 point
            scores[1] = scores[1] + 1;
        }
        
        //second comparison
        if(a1 > b1){
            //alice 1 point
            scores[0] = scores[0] + 1;
        }else if(b1 > a1){
            //bob 1 point
            scores[1] = scores[1] + 1;
        }
        
        if(a2 > b2){
            //alice 1 point
            scores[0] = scores[0] + 1;
        }else if(b2 > a2){
            //bob 1 point
            scores[1] = scores[1] + 1;
        }
        
        return scores;
    }

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));
        

    }
}
