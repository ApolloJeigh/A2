using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace A2.Test
{
    public class RectangleTest
    {
        // GetLength() Tests
        [Test]
        public void GetLength_DefaultRectangleLength_Returns1()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;

            // Act
            int actual = rectangle.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetLength_AfterSetLength345_Returns345()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(345);
            int expected = 345;

            // Act
            int actual = rectangle.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetLength_NonDefaultRectangleMaxRangeLength_ReturnsMaxRangeLength()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(4500, 100);
            int expected = 4500;

            // Act
            int actual = rectangle.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // GetLength() Tests
        [Test]
        public void GetWidth_DefaultRectangleWidth_Returns1()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;

            // Act
            int actual = rectangle.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetWidth_AfterSetWidth250_Returns250()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(250);
            int expected = 250;

            // Act
            int actual = rectangle.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetWidth_NonDefaultRectangleMaxRangeWidth_ReturnsMaxRangeWidth()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(500, 4500);
            int expected = 4500;

            // Act
            int actual = rectangle.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
