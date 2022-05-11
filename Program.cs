
using System.Collections.Generic;
namespace ProblemSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            p3();
        }

        // Problem set,  problem 3
        
        public static void p3() {
        // String str = Console.ReadLine();
        int test =  int.Parse(Console.ReadLine());
        HashSet<int> hs = new HashSet<int>();
        
        for(int t = 0; t < test; t++) {
             String str = Console.ReadLine();
             String[] strArr = str.Split(" ");
             int[] arr = new int[strArr.Length];
             for(int i = 0; i < strArr.Length; i++) {
                 arr[i] = int.Parse(strArr[i]);
             }

             // implementation

              int n = arr.Length;

             for(int i = 1; i < arr.Length; i++) {
                 hs.Add(Math.Abs(arr[i] - arr[i-1]));
             }

             Boolean isJolly = true;

             for(int i = 1; i <= n-1; i++) {
                if(!hs.Contains(i)) {
                    isJolly = false;
                }
             }

             if(isJolly) {
                System.Console.WriteLine("Jolly");
             } else {
                System.Console.WriteLine("Not Jolly");
             }
            

        }
    }
    }
}