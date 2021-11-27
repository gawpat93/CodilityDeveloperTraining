using Codility.Lesson3;
using NUnit.Framework;

namespace Tests
{
    public class Lesson3Tests
    {
        [Test]
        public void PermMissingElemTest1()
        {
            var A = new int[] { 1, 2, 3, 4, 6 };
            var result = PermMissingElem.Solution(A);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void PermMissingElemTest2()
        {
            var A = new int[] { 9, 7, 1, 4, 5, 3, 2, 8 };
            var result = PermMissingElem.Solution(A);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void PermMissingElemTest3()
        {
            var A = new int[] { 2, 3, 1, 5 };
            var result = PermMissingElem.Solution(A);
            Assert.AreEqual(4, result);
        }
    }
}