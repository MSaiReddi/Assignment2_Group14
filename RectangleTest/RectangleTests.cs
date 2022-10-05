using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2_group14;

namespace RectangleTest
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void getCurrentLength_lengthnunber_valid()
        {
            int length = 10;
            int width = 5;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 10;

            int actual = rectangle.GetCurrentLength();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void getCurrentLength_lengthnunberpositive_valid()
        {
            int length = 3;
            int width = 7;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 3;

            int actual = rectangle.GetCurrentLength();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void getCurrentLength_lengthnunbernegative_valid()
        {
            int length = 32;
            int width = 17;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 32;

            int actual = rectangle.GetCurrentLength();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SetNewLength_lengthnumber_valid()
        {
            int length = 10;
            int width = 5;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 10;

            int actual = rectangle.SetNewLength(length);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewLength_lengthnumberPositive_valid()
        {
            int length = 12;
            int width = 15;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 12;

            int actual = rectangle.SetNewLength(length);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewLength_lengthnumberNegative_valid()
        {
            int length = 9;
            int width = 11;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 9;

            int actual = rectangle.SetNewLength(length);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void getCurrentWidth_widthnunber_valid()
        {
            int length = 15;
            int width = 10;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 10;

            int actual = rectangle.GetCurrentWidth();
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void getCurrentWidth_widthnunberpositive_valid()
        {
            int length = 11;
            int width = 12;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 12;

            int actual = rectangle.GetCurrentWidth();
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void getCurrentWidth_widthnunbernegative_valid()
        {
            int length = 23;
            int width = 14;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 14;

            int actual = rectangle.GetCurrentWidth();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SetNewWidth_widthnumber_valid()
        {
            int length = 15;
            int width = 10;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 10;

            int actual = rectangle.SetNewWidth(width);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SetNewWidth_widthnumberpositive_valid()
        {
            int length = 23;
            int width = 11;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 11;

            int actual = rectangle.SetNewWidth(width);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewWidth_widthnumbernegative_valid()
        {
            int length = 21;
            int width = 13;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            int expected = 13;

            int actual = rectangle.SetNewWidth(width);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetPerimeter_perimeternumber_valid()
        {
            int length = 5;
            int width = 5;

            int result;
          
            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            result = length + width;

            int expected = 20;

            int actual = rectangle.GetPerimeter();

            Assert.AreEqual(expected, actual);  

        }
        [Test]
        public void GetPerimeter_perimeternumberpositive_valid()
        {
            int length = 6;
            int width = 4;

            int result;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            result = length + width;

            int expected = 20;

            int actual = rectangle.GetPerimeter();

            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GetPerimeter_perimeternumbernegative_valid()
        {
            int length = 7;
            int width = 7;

            int result;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            result = length + width;

            int expected = 28;

            int actual = rectangle.GetPerimeter();

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetArea_Areanumber_valid()
        {
            int length = 5;
            int width = 5;

            int result;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            result = length * width;

            int expected = 20;

            int actual = rectangle.GetPerimeter();

            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GetArea_Areanumberpositive_valid()
        {
            int length = 16;
            int width = 4;

            int result;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            result = length * width;

            int expected = 40;

            int actual = rectangle.GetPerimeter();

            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GetArea_Areanumbernegative_valid()
        {
            int length = 3;
            int width = 7;

            int result;

            Assignment2_group14.Rectangle rectangle = new Assignment2_group14.Rectangle(length, width);

            result = length * width;

            int expected = 20;

            int actual = rectangle.GetPerimeter();

            Assert.AreEqual(expected, actual);

        }







    }
}
