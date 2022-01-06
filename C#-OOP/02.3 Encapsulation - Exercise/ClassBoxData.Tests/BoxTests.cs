using NUnit.Framework;
using System;

namespace ClassBoxData.Tests
{
    [TestFixture]
    public class BoxTests
    {
        private double length = 2;
        private double width = 3;
        private double height = 4;
        private Box box;
        [SetUp]
        public void SetUp()
        {
            box = new Box(length,width,height);
        }
        [Test]
        public void When_BoxGetLength_ShouldBeSetCorrectly()
        {
            Assert.AreEqual(box.Length, length);
        }
        [Test]
        public void When_BoxGetWidth_ShouldBeSetCorrectly()
        {
            Assert.AreEqual(box.Width, width);
        }
        [Test]
        public void When_BoxGetHeight_ShouldBeSetCorrectly()
        {
            Assert.AreEqual(box.Height, height);
        }
        [Test]
        public void When_BoxGetZeroOrNegative_ShouldThrowMessage()
        {
            box = new Box(-1, 2, 3);
            ArgumentException ex = Assert.Throws<ArgumentException>(() =>
              {

              });
            Assert.AreEqual(ex.Message, "Length cannot be zero or negative.");
        }

    }
}
