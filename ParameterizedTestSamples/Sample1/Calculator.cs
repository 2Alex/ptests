using System;
using System.Diagnostics;

namespace ParameterizedTestSamples.Sample1
{
    public static class Calculator
    {
        /// <summary>
        /// Возвращает true, если числа являются взаимно простыми.
        /// </summary>
        public static bool IsCoprimeNumbers(int n1, int n2)
        {
            // Никакие два равные числа не могут быть простыми.
            if (n1 == n2)
            {
                return false;
            }

            // Числа 0 и 1 никогда не могуть быть взаимно простыми с кем-либо.           
            if (n1 <= 1  || n2 <= 1)
            {
                return false;
            }

            Debug.Assert(n1 >= 2);
            Debug.Assert(n2 >= 2);            
            
            // Если хоть одно число от 2 до максимального из двух чисел включительно
            // делит оба числа без остатка - значит они не взаимнопростые и существует общий делитель отличный от 1.
            var max = Math.Max(n1, n2);
            for (var i = 2; i <= max; i++)
            {
                if (n1 % i == 0
                 && n2 % i == 0)
                {
                    return false;
                }
            }

            // Выход не был выполнен, значит общие делители не найдены и числа являются взаимно простыми.
            return true;
        }
    }
}