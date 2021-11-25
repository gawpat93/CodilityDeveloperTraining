namespace Codility
{
    /// <summary>
    /// CyclicRotation
    /// Rotate an array to the right by a given number of steps.
    /// </summary>
    public static class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            var lenght = A.Length;
            K = K % lenght;
            var B = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                var newPosition = i + K;
                if (newPosition + 1 > lenght) newPosition = newPosition % lenght;
                B[newPosition] = A[i];
            }

            return B;
        }
    }
}