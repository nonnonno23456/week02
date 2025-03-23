namespace test1
{   
    class Tst
    {
        public int Add(int num1, int num2)
        {   
            int result = num1 + num2;
            return result;
        }

        public float Add(float num1, float num2)
        {
            float result = num1 + num2;
            return result;
        }

        public void Multiple(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        public void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public void Divide(int num1, int num2, out int result1, out int result2)
        {
            result1 = num1 / num2;
            result2 = num1 % num2;
        }

        public void Sum(params int[] nums)
        {
            int sum = 0;
            for ( int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }

        public void Player(string ID, int health = 800)
        {
            Console.WriteLine("ID : {0}, HP : {1}", ID, health);
        }

    }
}