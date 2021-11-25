using Codility;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void BinaryGapTest()
        {
            Assert.AreEqual(0, BinaryGap.Solution(1));
            Assert.AreEqual(0, BinaryGap.Solution(2));
            Assert.AreEqual(0, BinaryGap.Solution(3));
            Assert.AreEqual(0, BinaryGap.Solution(4));
            Assert.AreEqual(2, BinaryGap.Solution(9));
            Assert.AreEqual(0, BinaryGap.Solution(15));
            Assert.AreEqual(1, BinaryGap.Solution(20));
            Assert.AreEqual(0, BinaryGap.Solution(32));
            Assert.AreEqual(4, BinaryGap.Solution(529));
        }

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