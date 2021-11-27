using Codility.Lesson2;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Lesson2Tests
    {

        [Test]
        public void CyclicRotationTest1()
        {
            var A = new int[] { 3, 8, 9, 7, 6 };
            var K = 3;
            var expected = new int[] { 9, 7, 6, 3, 8 };
            var result = CyclicRotation.Solution(A, K);
            Assert.True(expected.SequenceEqual(result));
        }

        [Test]
        public void CyclicRotationTest2()
        {
            var A = new int[] { 1, 2, 3, 4 };
            var K = 4;
            var expected = new int[] { 1, 2, 3, 4 };
            var result = CyclicRotation.Solution(A, K);
            Assert.True(expected.SequenceEqual(result));
        }

        [Test]
        public void CyclicRotationTest3()
        {
            var A = new int[] { 0, 0, 0 };
            var K = 1;
            var expected = new int[] { 0, 0, 0 };
            var result = CyclicRotation.Solution(A, K);
            Assert.True(expected.SequenceEqual(result));
        }

        [Test]
        public void OddOccurrencesInArrayTest1()
        {
            var A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            var result = OddOccurrencesInArray.Solution(A);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void OddOccurrencesInArrayTest2()
        {
            var A = new int[] { 9, 8, 12, 8, 13, 6, 9, 6, 12 };
            var result = OddOccurrencesInArray.Solution(A);
            Assert.AreEqual(13, result);
        }
    }
}