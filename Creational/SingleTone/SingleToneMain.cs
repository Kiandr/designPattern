using System;
using System.Diagnostics.Contracts;

namespace tester
{
    public sealed class SingleTone
    {
        private SingleTone instance;
        private readonly object lockThis = null;
        public DateTime time;
        public SingleTone() => time = new DateTime().ToLocalTime();

        public SingleTone GetInstanceEager()
        {
            instance = new SingleTone();
            return instance;
        }
        public SingleTone GetInstanceLazy()
        {
            if (instance == null) instance = new SingleTone();
            return instance;
        }
        public SingleTone GetInstanceThreadSafe()
        {
            Contract.Ensures(Contract.Result<SingleTone>() != null);
            lock (lockThis)
            {
                if (instance == null) instance = new SingleTone();
                return instance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                var myObject = new SingleTone().GetInstanceEager();
                Console.WriteLine(myObject.time.ToString());

            }
            for (int i = 0; i < 10; i++)
            {
                var myObject = new SingleTone().GetInstanceEager();
                Console.WriteLine(myObject.time.ToString());

            }

            for (int i = 0; i < 10; i++)
            {
                var myObject = new SingleTone().GetInstanceThreadSafe();
                Console.WriteLine(myObject.time.ToString());

            }

        }
    }

}
