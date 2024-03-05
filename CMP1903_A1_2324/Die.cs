using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Die class to hold the current die value and roll the die.
    /// </summary>
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private static Random _rnd = new Random();
        
        /// <summary>
        /// RollVal property to hold the current die value.
        /// </summary>
        public int RollVal { get; private set; } = _rnd.Next(1, 7);

        /// <summary>
        /// Method to roll the die randomly and return the value.
        /// </summary>
        /// <returns>The rolled value</returns>
        public int Roll()
        {
            RollVal = _rnd.Next(1, 7);
            return RollVal;
        }
    }
}
