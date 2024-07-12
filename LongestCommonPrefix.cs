namespace leetcode
{
    public class Solution
    {
        static void Main()
        {

            Console.WriteLine(LongestCommonPrefix(["ab", "a"])); //expects a
            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs, (x,y) => x.Length.CompareTo(y.Length));
            var s = strs.First();
            foreach (string str in strs)
            {
                for (int i = 0; i < str.Length; i++)
                {

                    if (i >= s.Length)
                        continue;
                    if (s[i] == str[i])
                    {
                        continue;
                    }
                    else
                    {
                        s = s.Remove(i);
                    }

                }
            }
            return s;
        }
    }
}
