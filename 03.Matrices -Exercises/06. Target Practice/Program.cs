using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Target_Practice
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[][] matrix = new char[sizeOfMatrix[0]][];
            var text = Console.ReadLine();
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                matrix[row] = new char[sizeOfMatrix[1]];
                foreach (var letter in text)
                {                   
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        
                    }
                }
            }
        }
    }
}
