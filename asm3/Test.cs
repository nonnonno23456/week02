using static System.Console;

namespace Test
{
    public class Player
    {
        private string ID;
        private int CurrentHP;
        private int CurrentMP;


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

        public Player DeepCopy()
        {
            Player clone = new Player();
            clone.ID = ID;
            clone.CurrentHP = CurrentHP;
            clone.CurrentMP = CurrentMP;
            return clone;
        }
    }

    public class Enemy
    {
        private Player player;

        public void AttackToTarget(Player target)
        {
            target.TakeDamage(100);
        }
    }








}