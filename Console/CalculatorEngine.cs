using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine
    {
        // c'est bon
        /// <summary>
        /// Function to Addition two value
        /// </summary>
        /// <param name="a">1st value</param>
        /// <param name="b">2nd value</param>
        /// <returns>the addition value</returns>
        public virtual int Addition(int a, int b)
        {
            // new commit
            return a + b;
        }
        /// <summary>
        /// Function to Subsraction two value
        /// </summary>
        /// <param name="a">1st value</param>
        /// <param name="b">2nd value</param>
        /// <returns>the substraction value</returns>
        public virtual int Sub(int a, int b)
        {
            return a - b;
        }
        public virtual int Multiply(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Function to  two value
        /// </summary>
        /// <param name="a">1st value</param>
        /// <param name="b">2nd value</param>
        /// <returns>the substraction value</returns>
        public virtual int Div(int a, int b)
        {
            int res;
            if(b != 0)
            {
                res = a / b;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }


    }
}
