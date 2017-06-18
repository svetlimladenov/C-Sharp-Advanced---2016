using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Jedi_Galaxy
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[sizeOfMatrix[0]][];
            var counter = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[sizeOfMatrix[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }
            var jedi = Console.ReadLine();
            var JediStartIndex = new int[2];
            var EvilStartIndex = new int[2];
            var result = 0;
            while (jedi != "Let the Force be with you")
            {

                JediStartIndex = jedi
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                EvilStartIndex = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jedi = Console.ReadLine();

                var evilRow = EvilStartIndex[0] - 1;
                var evilCol = EvilStartIndex[1] - 1;
                var JediRow = JediStartIndex[0] - 1;
                var JediCol = JediStartIndex[1] - 1;
                if (JediCol < 0)
                {
                    JediCol = 0;
                }
                if (evilCol < 0)
                {
                    evilCol = 0;
                }

                for (int row = evilRow; row >= 0; row--)
                {
                    matrix[row][evilCol] = 0;
                    evilCol--;
                }



                var colAdder = 0;
                for (int row = JediRow; row >= 0; row--)
                {
                    result += matrix[row][colAdder];
                    colAdder++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
