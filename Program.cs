using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the amount of lines choosen to your vect:");
                int lines = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the amount of columns choosen to your vect:");
                int columns = Convert.ToInt32(Console.ReadLine());

                int[,] values = new int[lines, columns];
                string[] str = new string[columns];

                Console.WriteLine("Input your vect values separated by blank space: ");
                for (int i = 0; i < lines; i++)
                {
                    string nums = Console.ReadLine();
                    for (int j = 0; j < columns; j++)
                    {
                        str[j] = nums.Split(' ')[j];
                        values[i, j] = Convert.ToInt32(str[j]);
                    }
                }
                Console.Write("What is the number you want to search for? ");
                int src = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < lines; i++)
                {

                    for (int j = 0; j < columns; j++)
                    {
                        Console.WriteLine("\n#######################################");
                        if (values[i, j] == src)
                        {
                            Console.WriteLine($"\nLine: {i}, column: {j}");
                            Console.WriteLine("----------------------------");
                            //LEFT
                            if (j > 0)
                            {
                                Console.WriteLine($"Left: {values[i, j - 1]}");
                            }//RIGHT
                            if (j < columns - 1)
                            {
                                Console.WriteLine($"Right: {values[i, j + 1]}");
                            }//UP
                            if (i > 0)
                            {
                                Console.WriteLine($"Up: {values[i - 1, j]}");
                            }//DOWN
                            if (i < lines - 1)
                            {
                                Console.WriteLine($"Down: {values[i + 1, j]}");
                            }
                        }
                    }
                } Console.ReadKey();
            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }
        }
    }
}
