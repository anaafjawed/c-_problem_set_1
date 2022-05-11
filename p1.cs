
using System.Collections.Generic;
namespace ProblemSet1
{
    class P1
    {
        static void Main(string[] args)
        {
            solve();
        }
        
        public static void solve() {
       
        int test =  int.Parse(Console.ReadLine());
        
        for(int t = 0; t < test; t++) {

            String str = Console.ReadLine();
            String[] strArr = str.Split(" ");
            
            double a = double.Parse(strArr[0]);
            double b = double.Parse(strArr[1]);
            double c = double.Parse(strArr[2]);
            
            double sq_a = Math.Pow(a, 2);
             double sq_b = Math.Pow(b, 2);
              double sq_c = Math.Pow(c, 2);

              if(sq_a == sq_b + sq_c || sq_b == sq_a + sq_c || sq_c == sq_a + sq_b) {
                  System.Console.WriteLine("right");
              } else {
                  System.Console.WriteLine("wrong");
              }


        }
    }
    }
}