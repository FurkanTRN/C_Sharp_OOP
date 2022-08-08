using System;

namespace Interface_Demo_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Managers(),
                new Worker(),
                new Robot()
            };
            IEat[] eats = new IEat[2]
            {
                new Managers(),
                new Worker()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
     
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Managers : IWorker,IEat, ISalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker,ISalary,IEat
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }

}
