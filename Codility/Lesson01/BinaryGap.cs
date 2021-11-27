namespace Codility.Lesson1
{
    /// <summary>
    /// BinaryGap
    /// Find longest sequence of zeros in binary representation of an integer.
    /// </summary>
    public static class BinaryGap
    {
        public static int Solution(int N)
        {
            var longestBinaryGap = 0;
            var currentBinaryGap = 0;
            var counting = false;
            do
            {
                var next = N / 2;
                var rest = N % 2;
                if (rest == 1)
                {
                    counting = true;
                    if (currentBinaryGap > longestBinaryGap) longestBinaryGap = currentBinaryGap;
                    currentBinaryGap = 0;
                }
                else
                {
                    if (counting) currentBinaryGap++;
                }

                N = next;
            }
            while (N > 0);

            return longestBinaryGap;
        }
    }
}