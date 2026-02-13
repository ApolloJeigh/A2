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

        // GetWidth() Tests
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

        // SetLength()
        [Test]
        public void SetLength_MinValue1_Setto1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(15, 16);
            int expected = 1;

            //Act
            int actual = rectangle.SetLength(1);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SetLength_MaxValue4500_Setto4500()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(15, 16);
            int expected = 4500;

            //Act
            int actual = rectangle.SetLength(4500);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SetLength_NegativeBelowBoundary_DoesNotUpdate()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(15, 16);
            int expected = 15;

            //Act
            int actual = rectangle.SetLength(-99);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // SetWidth()
        [Test]
        public void SetWidth_MinValue1_Setto1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(15, 16);
            int expected = 1;

            //Act
            int actual = rectangle.SetWidth(1);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SetWidth_MaxValue4500_Setto4500()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(15, 16);
            int expected = 4500;

            //Act
            int actual = rectangle.SetWidth(4500);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SetWidth_MassiveAboveBoundary_DoesNotUpdate()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(15, 16);
            int expected = 16;

            //Act
            int actual = rectangle.SetWidth(5095);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }



        [Test]
        public void GetPerimeter_DefaultRectanglePerimeter_Returns60()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(10, 20);
            int expected = 60;

            //Act
            int actual = rectangle.GetPerimeter();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPerimeter_MinValueLengthAndWidth_Returns4()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 4;
            //Act
            int actual = rectangle.GetPerimeter();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void GetPerimeter_MaxValue_Returns18000()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(4500, 4500);
            int expected = 18000;
            //Act
            int actual = rectangle.GetPerimeter();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetArea_ReturnCorrectArea()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(10, 20);
            int expected = 200;
            // Act
            int actual = rectangle.GetArea();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetArea_MinValue_Returns1()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 1;
            // Act
            int actual = rectangle.GetArea();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetArea_MaxValue_Returns20250000()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(4500, 4500);
            int expected = 20250000;

            // Act
            int actual = rectangle.GetArea();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));


        }
    }
}
