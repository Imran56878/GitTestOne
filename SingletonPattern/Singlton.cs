using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
   public  class Singleton
    {
      private static  Singleton instance = null;
        private Singleton ()
        { }
        public static  Singleton GetInstance()
        {
            if (instance==null)
            {
                instance=new Singleton();
                return instance;
            }
            return  instance;
        }
        public void Show()
        {
            Console.WriteLine("This is message block");
        }
    }
}
