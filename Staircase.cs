using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        int l = n-1;
        int r = 1;
                
        //loop n times
        for(int i=0; i<n; i++){
            
            //loop l times
            for(int i2=l; i2>0; i2--){
                Console.Write(" ");
            }

            l = l - 1;
            
            //loop r times
            for(int i2=0; i2<r; i2++){
                Console.Write("#");
            }

            r = r + 1;
            
            Console.WriteLine("");
        }
    }
}
