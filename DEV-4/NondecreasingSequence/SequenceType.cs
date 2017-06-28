namespace NondecreasingSequence
{
    //This class was created to detect type of the sequence
    class SequenceType
    {
        const string NONDECREASING = "\nIt is nondecreasing sequence of integers";
        const string NOTNONDECREASING = "\nIt is not nondecreasing sequence of integers";

        //check sequence for nondecreasing
        public string DetermineSequenceType(int[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] >= sequence[i - 1])
                {
                    return NONDECREASING;
                }
            }
            return NOTNONDECREASING;
        }
    }
}