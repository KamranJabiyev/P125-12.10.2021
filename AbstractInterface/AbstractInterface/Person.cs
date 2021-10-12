using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterface
{
    class Person : IRunable,ITalk
    {
        public void Run()
        {
            Console.WriteLine("Run as person");
        }

        public void Talk()
        {
            Console.WriteLine("Talk as Gunel");
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Print(int n)
        {
            Console.WriteLine(n);
        }

        public void Print(params int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
