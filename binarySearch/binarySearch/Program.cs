using System;
using System.IO;
using System.Collections.Generic;
namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2 , 3 , 5 , 7 , 8 , 13 , 23 , 29 , 31 , 45 , 51 , 64 , 73 , 76 , 83 , 92 , 111 , 133, 141 , 153 , 167 , 177 , 189 , 200};
            int number = 31;
            Console.WriteLine(search(number, array));
            Console.ReadKey();
        }
        static int search(int number , int[] array)
        {
            int index=array.Length-1;
            int shift = index / 2;
            int intermidiate = 0 ;
            while (true)
            {
                intermidiate = array[index];
                Console.WriteLine("number "+intermidiate);
                if (intermidiate == number)
                {
                    break;
                }
                else if (intermidiate<number)
                {
                    Console.WriteLine("more");
                    //index /= 2;
                    index += shift;
                }
                else if (intermidiate>number)
                {
                    Console.WriteLine("less");
                    //index /= 2;
                    index -= shift;                    
                }
                Console.WriteLine("index "+index);
                //index /= 2;
                shift /= 2;
            }
            return index;
        }
    }
}
