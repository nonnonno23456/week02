using System;
using test1;


namespace Intro_Ex1
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            TestPlayer();
            //TestSum();
            //TestAdd();
            //TestDivide();
            //TestSwap();
            //Console.WriteLine(tst.Add(1, 2));
            //tst.Multiple(2, 3);

        }

        public static void TestSwap(){
            Tst tst = new Tst();
            int a=3;
            int b=9;

            Console.WriteLine("Before Swap: a={0}, b={1}", a, b);
            tst.Swap(ref a, ref b);
            Console.WriteLine("After Swap: a={0}, b={1}", a, b);
        }

        public static void TestDivide(){
            Tst tst = new Tst();
            int a=9;
            int b=2;
            int result1;
            int result2;

            tst.Divide(a, b, out result1, out result2);
            Console.WriteLine("Result1 : {0}, Result2 : {1}", result1, result2);
        }

        public static void TestAdd(){
            Tst tst = new Tst();
            Console.WriteLine(tst.Add(1, 2));
            Console.WriteLine(tst.Add(1.2f, 2.3f));
        }

        public static void TestSum(){
            Tst tst = new Tst();
            tst.Sum(1, 2, 3, 4, 5);
        }

        public static void TestPlayer()
        {
            Tst tst = new Tst();
            tst.Player( ID: "고박사");
        }
    }    
}