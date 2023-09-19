using GeometricShapes;

namespace GeometricShappesTest
{
    public class UnitTestCircle
    {
        [Fact]
        public void TestCircle()
        {
            //arrange
            double radius = 5;
            double expected = radius * radius  *Math.PI;
            Circle circle = new Circle { Radius = 5 };
            
            //act
            double actual = circle.AreaOfTheShape();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}