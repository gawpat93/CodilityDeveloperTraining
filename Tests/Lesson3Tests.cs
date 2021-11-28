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

        [Test]
        public void FrogJmpTest1()
        {
            var result = FrogJmp.Solution(10, 85, 30);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void FrogJmpTest2()
        {
            var result = FrogJmp.Solution(5, 85, 80);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FrogJmpTest3()
        {
            var result = FrogJmp.Solution(0, 60, 80);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FrogJmpTest4()
        {
            var result = FrogJmp.Solution(0, 30, 20);
            Assert.AreEqual(2, result);
        }
    }
}