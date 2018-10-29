using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

    class Program
    {
        //static void test()
        //{
        //    for(int i=1;i<=100;i++)
        //        Console.WriteLine("Test:",+i);
        //}       
        static void test(object max)
        {
            int num = Convert.ToInt32(max);  
            for(int i=1;i<=num;i++)
               Console.WriteLine("Test:{0}",+i);
        }
        static void Main(string[] args)
        {
         //ThreadStart obj=()=>test();
            ParameterizedThreadStart obj = new ParameterizedThreadStart(test);
            Thread t=new Thread(obj);
            t.Start(76);
            Console.ReadLine();
        }
    }

