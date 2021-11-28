namespace Codility.Lesson3
{
    /// <summary>
    /// FrogJmp
    /// Count minimal number of jumps from position X to Y.
    /// https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
    /// </summary>
    public static class FrogJmp
    {
        public static int Solution(int X, int Y, int D) => (Y - X) % D > 0
                ? (Y - X) / D + 1
                : (Y - X) / D;
    }
}