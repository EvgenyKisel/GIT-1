using System.Collections;

namespace FloatArrays
{
    class Checker
    {
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