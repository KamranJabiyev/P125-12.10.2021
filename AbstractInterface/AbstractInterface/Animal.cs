using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterface
{
    abstract class Animal
    {
        public int Age { get; set; }
        public Animal()
        {

        }

        public abstract void Eat();

        public virtual void Sleep()
        {
            Console.WriteLine("Sleep as Animal");
        }
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird,IRunable
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public void Run()
        {
            Console.WriteLine("Run as Eagle");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep as Eagle");
        }
    }

    abstract class Fish : Animal
    {

    }

    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep as Shark");
        }
    }
}
