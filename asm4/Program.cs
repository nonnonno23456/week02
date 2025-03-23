using static System.Console;
using Test;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Player player = new Player(100, 50);
            Enemy goblin = new Goblin();
            Enemy slime = new Slime();
            Enemy dragon = new Dragon();

            player.Hit(goblin);
            player.Hit(slime);
            player.Hit(dragon);
            
        }

        public struct IdCard
        {
            public string Name;
            public int Age;
            public string Address;
        }

        public static class Calculator
        {   

            public static int multiply2(int a)
            {
                return a * 2;
            }

        }
        public void PrintData(this string str)
        {
            WriteLine(str); 
            
        }

    }
}
