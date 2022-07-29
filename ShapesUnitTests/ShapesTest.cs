using Shapes;
using Xunit;

namespace ShapesUnitTest
{
    public class ShapesTest
    {
        private readonly Circle testCircle;
        private readonly Triangle testTriangle;

        public ShapesTest()
        {
            testCircle = new Circle();
            testTriangle = new Triangle();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(3.141592653589793, 1)]
        [InlineData(78.53981633974483, 5)]
        [InlineData(3.877733785771607, 1.111)]
        [InlineData(0.047877565735424725, 0.12345)]
        public void CircleAreaTest(double area, double r)
        {
            double result = testCircle.Area(r);
            Assert.Equal(area, result);
        }
        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0.4330127018922193, 1, 1, 1)]
        [InlineData(6, 3, 4, 5)]
        public void TriangleAreaTest(double area, double a, double b, double c)
        {
            double result = testTriangle.Area(a, b, c);
            Assert.Equal(area, result);
        }
        [Theory]
        [InlineData(false, 0, 0, 0)]
        [InlineData(false, 1, 1, 1)]
        [InlineData(true, 3, 4, 5)]
        public void TriangleRightAngleTest(bool right, double a, double b, double c)
        {
            bool result = testTriangle.IsRightAngled(a, b, c);
            Assert.Equal(right, result);
        }
    }
}
