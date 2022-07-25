using System;
using System.Threading;
using System.Threading.Tasks;

namespace delegateExample
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region delegateExample1
            //FirstDelegate firstDelegate = new FirstDelegate(ModAl);
            //firstDelegate += Bolme;
            //firstDelegate.Invoke(4, 2);
            #endregion
                
            #region delegateExample2
            //ornekDelegate del = new ornekDelegate(methodHi);
            //del += methodName;
            //del += methodSurname;
            //del.Invoke();
            //del.Invoke();
            //Console.ReadKey();
            #endregion

            #region asyncTaskAwaitExample
            //method1();
            //method2();
            //Console.ReadKey();
            #endregion  
        } 
        
        #region delegateExample1
        //delegate void FirstDelegate(int x, int y);
        //private static void ModAl(int num1, int num2)
        //{
        //    Console.WriteLine($"{num1 % num2}");
        //}

        //private static void Bolme(int num1, int num2)
        //{
        //    Console.WriteLine($"{num1 / num2}");
        //}
        #endregion
            
        #region delegateExample2
        //delegate void ornekDelegate();
        //static void methodHi()
        //{
        //    Console.WriteLine("Merhaba");
        //}

        //static void methodName()
        //{
        //    Console.WriteLine("Ada");
        //}

        //static void methodSurname()
        //{
        //    Console.WriteLine("Kara");
        //} 
        #endregion

        #region asyncTaskAwaitExample

        //static async Task method1()
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("Method1");
        //            Thread.Sleep(1000);
        //        } 
        //    });
        //    Console.WriteLine("tamamlandı ! ");

        //}
        //static void method2()
        //{
        //    for (int i = 0; i < 2; i++)
        //    {
        //        Console.WriteLine("Method2");
        //        Thread.Sleep(2000);
        //    }
        //} 
        #endregion 
    }
}
