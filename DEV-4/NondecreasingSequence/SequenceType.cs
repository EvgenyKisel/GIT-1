namespace NondecreasingSequence
{
    //This class was created to detect type of the sequence
    class SequenceType
    {
        //check sequence for nondecreasing
        public bool NondecreasingSequence(int[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] >= sequence[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}