using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LiskovSubstitutionPrinciple {
    public class ClassicExample {
        [Test]
        public void Can_calculate_area_of_a_sqaure()
        {
            const int expectedArea = 100;
            var square = RectangleFactory.GetNewSquare();

            square.setWidth(10);
            square.setHeight(10);
            Assert.That(square.GetArea() , Is.EqualTo(expectedArea));    
        }

        [Test]
        public void Can_calculate_area_for_a_rectangle() {
            const int expectedArea = 50;
            var rectangle = RectangleFactory.GetNewRectangle();

			rectangle.setWidth(5);
            rectangle.setHeight(10);
            Assert.That(rectangle.GetArea(), Is.EqualTo(expectedArea));
        }

        [Test]
        public void Is_A_rectangle_a_square() {
            const int expectedArea = 50;
            var rectangle = RectangleFactory.GetNewSquare() as Square;
            rectangle.setWidth(5);
            rectangle.setHeight(10);
            Assert.That(rectangle.GetArea(), Is.EqualTo(expectedArea));
        }


    }


    class RectangleFactory
    {
        public static Rectangle GetNewRectangle() {
            // it can be an object returned by some factory ... 
            return new Square();
        }

        public static Rectangle GetNewSquare() {
            return new Square();
        }      

    }

    class Rectangle {
        protected int m_width;
        protected int m_height;

        public void setWidth(int width) {
            m_width = width;
        }

        public void setHeight(int height) {
            m_height = height;
        }


        public int getWidth() {
            return m_width;
        }

        public int getHeight() {
            return m_height;
        }

        public int GetArea() {
            return m_width * m_height;
        }
    }

    class Square : Rectangle 
    {
	    public void setWidth(int width){
		    m_width = width;
		    m_height = width;
	    }

	    public void setHeight(int height){
		    m_width = height;
		    m_height = height;
	    }
    }
}
