using System;
using MyCollections;

    public class Programm
    {
        public static void Main()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
        stack.Push(4);
        stack.Push(3);
        Console.WriteLine(stack.Length);
            Console.ReadKey();
        }
    }