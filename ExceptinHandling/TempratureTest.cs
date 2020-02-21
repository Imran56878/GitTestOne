using System;

namespace ExceptinHandling
{
    class TempratureTest
    {
        static void Main(string[] args)
        {
            Temprature temp = new Temprature();
            try
            {
                temp.ShowTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException :{0}",e.Message);
            }
            Console.ReadKey();
        }
    }
}
