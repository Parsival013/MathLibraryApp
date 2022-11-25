using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryP
{
    public class MathClass
    {
        /// <summary>
        /// Нахождение суммы
        /// </summary>
        /// <param name="x">
        /// Первое значение
        /// </param>
        /// <param name="y">
        /// Второе значение
        /// </param>
        /// <returns>
        /// Возвращает результат суммы
        /// </returns>
        public static int Sum(int x,int y)
        {
            int s = x + y;
            return s;
        }
    }
}
