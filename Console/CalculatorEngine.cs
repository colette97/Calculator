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
        /// <param name="leftNumber">1st value</param>
        /// <param name="b">2nd value</param>
        /// <returns>the addition value</returns>
        public static int Addition(int leftNumber, int rightNumber)
        {
            // new commit
            return leftNumber + rightNumber;
        }
        /// <summary>
        /// Function to Subsraction two value
        /// </summary>
        /// <param name="bigNumber">1st value</param>
        /// <param name="toSubtract">2nd value</param>
        /// <returns>the substraction value</returns>
        public virtual int Substraction(int bigNumber, int toSubtract)
        {
            return bigNumber - toSubtract;
        }

        /// <summary>
        /// Function to Multiply two value
        /// </summary>
        /// <param name="leftNumber">1st value</param>
        /// <param name="rightNumber">2nd value</param>
        /// <returns>the substraction value</returns>
        public virtual int Multiply(int leftNumber, int rightNumber)
        {
            return leftNumber * rightNumber;
        }
        /// <summary>
        /// Function to Division two value
        /// </summary>
        /// <param name="bigNumber">1st value</param>
        /// <param name="divisor">2nd value</param>
        /// <returns>the substraction value</returns>
        public virtual int Division(int bigNumber, int divisor)
        {
            int res;
            if(divisor != 0)
            {
                res = bigNumber / divisor;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }


    }
}
