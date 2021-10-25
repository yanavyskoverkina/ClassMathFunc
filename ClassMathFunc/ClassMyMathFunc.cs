using System;

namespace ClassMathFunc
{
    public class ClassMyMathFunc
    {
        /// <summary>
        /// Расчет факториала
        /// </summary>
        /// <param name="num">Цифра</param>
        /// <returns></returns>
        public int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="x">Первый множитель</param>
        /// <param name="y">Второй множитель</param>
        /// <returns></returns>
        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Расчет суммы
        /// </summary>
        /// <param name="x">Первое слогаемое</param>
        /// <param name="y">Второе слогаемое</param>
        /// <returns></returns>
        public int Addition(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Вичитание
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитаемое</param>
        /// <returns></returns>
        public int Subtraction(int x, int y)
        {
            return x - y;
        }
    }
}
