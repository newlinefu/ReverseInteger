using System;

namespace ReverseInteger
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.Reverse(4321));
        }

        public int Reverse(int num)
        {
            if (num == 0)
            {
                return num;
            }

            char[] numStr = num.ToString().Replace("-", string.Empty).ToCharArray();
            int sign = Math.Sign(num);
            int result = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                int singleNum = int.Parse(numStr[i].ToString());
                try
                {
                    checked
                    {
                        result += sign * singleNum * (int)Math.Pow(10, i);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }

            return result;
        }
    }
}
