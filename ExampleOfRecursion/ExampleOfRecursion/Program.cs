using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача - получить число из массива 
            // на нечётных итерация два соседних числа складываются ,образуя новый массив
            // на чётных итерация два соседних числа перемножаются ,образуя новый массив
            // всё происходит пока не получим массив с одним значением-ответом на задачу
            // сделано с помощью рекурсии и является наглядным примером.
            // made by recursion
            int[] array = new int[] { 1 , 2, 3 , 4 ,5 , 6 , 7, 8  };
            Console.WriteLine(arrayConversion(array));
            Console.ReadLine();
        }
        static int arrayConversion(int[] inputArray)
        {
            return Iteration(inputArray, 1);
        }
        static int Iteration(int[] input, int iteration)
        {
            if (input.Length == 1)
                return input[0];
            else
            {
                int[] intermidiate = new int[input.Length / 2];
                for (int counter = 0, count = 0; count < intermidiate.Length; counter++, count++)
                {
                    if (iteration % 2 == 1)
                    {
                        intermidiate[count] = input[counter];
                        counter++;
                        intermidiate[count] += input[counter];
                    }
                    else
                    {
                        intermidiate[count] = input[counter];
                        counter++;
                        intermidiate[count] *= input[counter];
                    }
                }
                return Iteration(intermidiate, iteration + 1);
            }
        }

    }
}
