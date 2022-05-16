using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet2
{
    // minesweeper 

    internal class p6
    {


        public static void solve() {

            string file = @"C:\Users\anaaf.javed\problem_solving_tasks\minesweeper.txt";

            string[] lines = File.ReadAllLines(file);
            int g = 0;
            int n = int.Parse(lines[g++]);

            char[,] mineMat = new char[n, n];
            char[,] clicks = new char[n, n];

            for (int i = 0; i < n; i++) {
                char[] temp = lines[g++].ToCharArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    mineMat[i, j] = temp[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                char[] temp = lines[g++].ToCharArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    clicks[i, j] = temp[j];
                }
            }


            bool isExposed = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!isExposed)
                    {
                        if (clicks[i, j] == 'x' && mineMat[i, j] == '*')
                        {
                            isExposed = true;
                        }
                        else if (clicks[i, j] == 'x' && mineMat[i, j] == '.')
                        {
                            int count = 0;
                            if (i + 1 < n && mineMat[i + 1, j] == '*')
                            {
                              
                                count++;
                            }

                            if (j + 1 < n && mineMat[i, j + 1] == '*')
                            {
                            
                                count++;
                            }

                            if (i - 1 >= 0 && mineMat[i - 1, j] == '*')
                            {
                                count++;
                            }

                            if (j - 1 >= 0 && mineMat[i, j - 1] == '*')
                            {
                                count++;
                            }

                            if ((j + 1 < n && i + 1 < n) && mineMat[i + 1, j + 1] == '*')
                            {
                               
                                count++;
                            }

                            if ((j - 1 >= 0 && i - 1 >= 0) && mineMat[i - 1, j - 1] == '*')
                            {

                                count++;
                            }

                            if (j + 1 < n && i - 1 >= 0 && mineMat[i - 1, j + 1] == '*')
                            {
                                count++;
                            }

                            if ((j - 1 >= 0 && i + 1 < n) && mineMat[i + 1, j - 1] == '*')
                            {
                                count++;
                            }

                            Console.Write(count);

                        }
                        else if (clicks[i, j] == '.') {

                            Console.Write('.');
                        
                        }

                    }
                    else {

                        Console.WriteLine(mineMat[i, j]);
                    } 
                    
                }
                Console.WriteLine();
            }





        }

    }

}
