using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        Int64[] arr = Array.ConvertAll(arr_temp,Int64.Parse);
        
        Int64 sum = arr.Sum();
        Console.WriteLine((sum - arr.Max()).ToString() + " " + (sum - arr.Min()).ToString() );
        
    }
}
