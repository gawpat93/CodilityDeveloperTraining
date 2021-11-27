namespace Codility.Lesson2
{
    /// <summary>
    /// OddOccurrencesInArray
    /// Find value that occurs in odd number of elements.
    /// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
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