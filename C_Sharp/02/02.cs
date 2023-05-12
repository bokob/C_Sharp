using System;

namespace ConsoleApplication1
{
    class CSVar
    {
        int globalVar;
        const int MAX = 1024;
        readonly int Max;

        public CSVar()
        {
            Max = 1;
        }
        public void Method1()
        {
            int localVar;

            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CSVar obj = new CSVar();
            obj.Method1();
        }
    }
}