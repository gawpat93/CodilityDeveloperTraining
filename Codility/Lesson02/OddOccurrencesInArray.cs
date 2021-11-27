namespace Codility.Lesson2
{
    /// <summary>
    /// OddOccurrencesInArray
    /// Find value that occurs in odd number of elements.
    /// </summary>
    public static class OddOccurrencesInArray
    {
        public static int Solution(int[] A)
        {
            var result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                result = result ^ A[i];
            }

            return result;
        }
    }
}