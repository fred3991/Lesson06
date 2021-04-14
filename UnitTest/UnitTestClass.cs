using Xunit;
using Shapes;
using Perimeter;
using Vectors;


namespace UnitTest
{
    public class UnitTestClass
    {
        //




        [Fact] //[Theory] тест с параметрами - метод с параметрами
        public void BoxVolumeTest()
        {
            // Arrange - установка начальных параметров

            Box box = new Box(10);

            double result = box.Volume();

            Assert.Equal(1000.0, result, 6);
        }


        [Fact] //[Theory] тест с параметрами - метод с параметрами
        public void BallVolumeTest()
        {
            // Arrange - установка начальных параметров

            Ball ball = new Ball(15.0);

            double result = ball.Volume();

            Assert.Equal(14137.16694115407, result, 6);
        }

        [Theory]
        [InlineData(20, 10)]//тест с параметрами - метод с параметрами/ конструктором
        [InlineData(10, 1)]
        public void TestShapeAdd(double contHeight, double ballRad)
        {
            var box = new Box(contHeight);
            var ball = new Ball(ballRad);

            Assert.True(box.Add(ball));
        }

    }
}
