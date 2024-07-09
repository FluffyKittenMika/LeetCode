namespace leetcode
{
    public class Solution
    {
        static void Main()
        {

            Console.WriteLine(ReverseInt(-322212)); //expects 212223
            Console.ReadLine();
        }

        public static int ReverseInt(int x)
        {
            bool wasnegative = false;
            if (x < 0)
            {
                x *= -1;
                wasnegative = true;
            }
            string t = x.ToString();
            char[] c = t.ToCharArray();
            Array.Reverse(c);
            bool success = Int32.TryParse(new string(c), out int nx);
            if (!success) 
                return 0;
            if (wasnegative)
                return nx * -1;
            return nx;
        }
    }
}
