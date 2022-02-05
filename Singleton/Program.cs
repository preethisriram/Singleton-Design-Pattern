// See https://aka.ms/new-console-template for more information

namespace Singleton
{
    class Logger
    {
        private static Logger l1;
        public int data;
        private Logger(int data)
        {
            this.data = data;
        }

        public static  Logger GetInstance(int num)
        {
            if (l1 == null)
                l1 = new Logger(num);
            return l1;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Logger l1 = Logger.GetInstance(44);
            Logger l2 = Logger.GetInstance(43);
            Console.WriteLine(l1.data);
            Console.WriteLine(l2.data);
            Console.WriteLine(l1.GetHashCode());
            Console.WriteLine(l2.GetHashCode());



        }
    }
}

