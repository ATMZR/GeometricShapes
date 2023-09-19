using GeometricShapes;

namespace GeometricShappesTest
{
    public class UnitTestTriangle
    {
        [Fact]
        public void TestTriangle()
        {
            //arrange
            double SideOne = 7;
            double SideTwo = 9;
            double SideThree = 12;
            double HalfPerimeter = (SideOne + SideTwo + SideThree) / 2;
            double expected = Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideOne) * (HalfPerimeter - SideTwo) * (HalfPerimeter - SideThree));
            Triangle triangle = new Triangle { SideOne = 7, SideTwo = 9, SideThree = 12 };

            //act
            double actual = triangle.AreaOfTheShape();

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPifagorTrue()
        {
            //arrange
            bool expected = true;
            Triangle triangle = new Triangle { SideOne = 3, SideTwo = 5, SideThree = 4 };

            //act
            bool actual = triangle.Pifagor();

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPifagorFalse()
        {
            //arrange
            bool expected = false;
            Triangle triangle = new Triangle { SideOne = 7, SideTwo = 11, SideThree = 9 };

            //act
            bool actual = triangle.Pifagor();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}