namespace leetcode
{
    public class Solution
    {
        static void Main()
        {

            Console.WriteLine(RomanToInt("LIIIV")); //expects 56

            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {
            int sum = 0;
            char lastchar = ' ';
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'I':
                        sum++;
                        lastchar = 'I';
                        break;
                    case 'V':
                        if (lastchar == 'I')
                            sum += 3;
                        else
                            sum += 5;
                        lastchar = 'V';
                        break;
                    case 'X':
                        if (lastchar == 'I')
                            sum += 8;
                        else
                            sum += 10;
                        lastchar = 'X';
                        break;
                    case 'L':
                        if (lastchar == 'X')
                            sum += 30;
                        else
                            sum += 50;

                        lastchar = 'L';
                        break;
                    case 'C':
                        if (lastchar == 'X')
                            sum += 80;
                        else
                            sum += 100;
                        lastchar = 'C';
                        break;
                    case 'D':
                        if (lastchar == 'C')
                            sum += 300;
                        else
                            sum += 500;
                        lastchar = 'D';
                        break;
                    case 'M':
                        if (lastchar == 'C')
                            sum += 800;
                        else
                            sum += 1000;
                        lastchar = 'M';
                        break;
                }
            }
            return sum;
        }
    }
}
