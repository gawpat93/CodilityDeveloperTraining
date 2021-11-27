namespace Codility.Lesson3
{
    /// <summary>
    /// PermMissingElem
    /// Find the missing element in a given permutation.
    /// https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
    /// </summary>
    public static class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            var result = 0;
            result ^= (A.Length + 1);
            for (int i = 0; i < A.Length; i++)
            {
                result = result ^ A[i] ^ (i + 1);
            }

            return result;
        }
    }
}