using SingletonPattern;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main( )
        {
            Console.WriteLine("Hello World!");
            Singleton s1 = Singleton.GetInstance();
            s1.Show();
        }
    }
}
