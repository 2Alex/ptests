using System;

namespace ParameterizedTestSamples.Sample1
{
    public static class Calculator
    {
        /// <summary>
        /// Возвращает true, если числа являются взаимно простыми.
        /// </summary>
        public static bool IsCoprimeNumbers(int n1, int n2)
        {
            if (n1 == n2)
            {
                return false;
            }
            if (n1 < 2 || n2 < 2)
            {
                return false;
            }

            int max = Math.Max(n1, n2);
            for (int i = 2; i <= max; i++)
            {
                if (n1 % i == 0
                 && n2 % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}