using static System.Console;

namespace Test
{
    public class Player
    {
        private string ID;
        private int CurrentHP;
        private int CurrentMP;

        private int damage = 10;


	public string getID() {
		return this.ID;
	}

	public void setID(string ID) {
		this.ID = ID;
	}

	public int getCurrentHP() {
		return this.CurrentHP;
	}

	public void setCurrentHP(int CurrentHP) {
		this.CurrentHP = CurrentHP;
	}

	public int getCurrentMP() {
		return this.CurrentMP;
	}

	public void setCurrentMP(int CurrentMP) {
		this.CurrentMP = CurrentMP;
	}


        public Player()
        {
            ID = "player";
            
        }
        public Player( int CurrentHP) : this()
        {
            this.CurrentHP = CurrentHP;
        }

        public Player( int CurrentHP, int CurrentMP) : this(CurrentHP)
        {
            this.CurrentMP = CurrentMP;
        }


        public void TakeDamage(int damage)
        {
            if(CurrentHP > damage)
            {
                CurrentHP -= damage;
            }

        }

        public void Hit(Enemy enemy)
        {
            enemy.TakeDamage(damage);
        }
    }

    public abstract class Enemy
    {
        private Player player;

        public void AttackToTarget(Player target)
        {
            target.TakeDamage(100);
        }

        public void TakeDamage(int damage)
        {
            WriteLine("적 : {0} 만큼 체력 감소", damage);
        }
    }

    public class Goblin : Enemy
    {
        public new void TakeDamage(int damage)
        {
            WriteLine("고블린 : {0} 만큼 체력 감소", damage);
        }
    }
    public class Slime : Enemy
    {
        public void TakeDamage(int damage)
        {   
            WriteLine("슬라임 : {0} 만큼 체력 감소", damage);

        }
        
    }

    public class Dragon: Enemy
    {
        public void TakeDamage(int damage)
        {   
            WriteLine("드래곤 : {0} 만큼 체력 감소", damage);
        }
    }

    interface Vehicle
    {
        void Run();
    }

    public class Car : Vehicle
    {
        public void Run()
        {
            WriteLine("빵빵");
        }
    }

    public class Airplane : Vehicle
    {
        public void Run()
        {
            WriteLine("붕붕");
        }
    }








}