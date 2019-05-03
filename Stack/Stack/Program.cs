using System;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("add "+ 9);
            stack.Push(9);
            //добавили новый элемент в стек
            Console.WriteLine("add "+6);
            stack.Push(6);
            Console.WriteLine("размер "+stack.Count);
            Console.WriteLine("размер после извлечения "+Pop(stack));
            Console.WriteLine("размер после просмотра "+Peek(stack));
            Console.ReadLine();
        }
        static int Pop(Stack<int> stack)
        {
            Console.WriteLine("извлечение "+stack.Pop());
            //извлекли эллемент
            return stack.Count;
        }
        static int Peek(Stack<int> stack)
        {
            Console.WriteLine("просмотр "+stack.Peek());
            //просмотрели эллемент , но "оставили на месте"
            return stack.Count;
        }
    }
}
