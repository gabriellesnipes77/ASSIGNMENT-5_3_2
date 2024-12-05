namespace ASSIGNMENT_5_3_2
{
    public class Program
    {
        public static int ClimbStairs(int n)
        {
            if (n == 1) return 1; //Special case when theres only 1 step

            //Initialize the base cases
            int prev2 = 1; // dp[0]
            int prev1 = 1; // dp[1]

            //Iterate to calculate the number of ways to reach each step
            for (int i = 2; i <= n; i++)
            {
                int current = prev1 + prev2; //Number of ways to reach current step
                prev2 = prev1; // Update prev2 to the previous step
                prev1 = current; // Update prev1 to the current step
            }

            return prev1; // The result is stored in prev1 (dp[n])
        }

        public static void Main(string[] args)
        {
            //Test cases
            Console.WriteLine(ClimbStairs (2));
            Console.WriteLine(ClimbStairs(3));
            Console.WriteLine(ClimbStairs(4));
            Console.WriteLine(ClimbStairs(5));
        }

    }
}
