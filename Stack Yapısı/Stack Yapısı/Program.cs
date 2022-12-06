using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            //s.Push(5);
            s.Pop();
            s.Pop();
            s.Pop();
            int[] arr = s.GetStack();
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }

    class Stack
    {
        int[] arr;
        int index = -1;
        int capacity = 4;
        public Stack()
        {
            arr = new int[capacity];
        }

        public void Push(int val)
        {
            if(index + 1 < arr.Length)
            {
                index++;
                arr[index] = val;
            }
            else
            {
                throw new Exception("stack full");
            }
        }

        public void Pop()
        {
            if(index != -1)
            {
                index--;
            }
            else
            {
                throw new Exception("stack empty");
            }
        }

        public int[] GetStack()
        {
            int[] tempArr = new int[index + 1];
            for(int i = 0; i <= index; i++)
            {
                tempArr[i] = arr[i];
            }
            return tempArr;
        }
    }
}
