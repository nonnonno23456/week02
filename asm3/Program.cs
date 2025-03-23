using static System.Console;
using Test;


namespace Program
{
    class Program
    {
        private Player player01;
        private Player player02;
        static void Main()
        {
            Player player01 = new Player(500, 50);
            Player player02 = new Player(200, 100);
            Enemy enemy = new Enemy();
            enemy.AttackToTarget(player01);
            enemy.AttackToTarget(player02);
            WriteLine(player01.getCurrentHP());
            WriteLine(player02.getCurrentHP());Player player03 = player01.DeepCopy();
            player03.setID("player03");
            WriteLine(player03.getID());
        }   
    }
}


