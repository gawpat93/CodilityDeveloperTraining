using Codility.Lesson1;
using NUnit.Framework;

namespace Tests
{
    public class Lesson1Tests
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
    }
}