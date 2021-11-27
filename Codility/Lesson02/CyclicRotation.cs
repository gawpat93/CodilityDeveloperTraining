namespace Codility.Lesson2
{
    /// <summary>
    /// CyclicRotation
    /// Rotate an array to the right by a given number of steps.
    /// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
    /// </summary>
    public static class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            var lenght = A.Length;
            var B = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                var newPosition = (i + K) % lenght;
                B[newPosition] = A[i];
            }

            return B;
        }
    }
}