using System.Collections;

namespace FloatArrays
{
    class Checker
    {
        /// <summary>
        /// This method checks the collection for the presence of elements in it.
        /// </summary>
        /// <param name="newFloatArray"> collection of new array </param>
        /// <returns> true value if collection isn't empty, else false value </returns>
        public bool CheckForNonEmpty(ArrayList newFloatArray)
        {
            bool checker = true;
            if (newFloatArray.Count == 0)
            {
                checker = false;
            }
            return checker;
        }
    }
}