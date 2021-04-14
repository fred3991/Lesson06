using Xunit;
using Shapes;
using Perimeter;
using Vectors;


namespace UnitTest
{
    public class UnitTestClass
    {
        //




        [Fact] //[Theory] ���� � ����������� - ����� � �����������
        public void BoxVolumeTest()
        {
            // Arrange - ��������� ��������� ����������

            Box box = new Box(10);

            double result = box.Volume();

            Assert.Equal(1000.0, result, 6);
        }


        [Fact] //[Theory] ���� � ����������� - ����� � �����������
        public void BallVolumeTest()
        {
            // Arrange - ��������� ��������� ����������

            Ball ball = new Ball(15.0);

            double result = ball.Volume();

            Assert.Equal(14137.16694115407, result, 6);
        }

        [Theory]
        [InlineData(20, 10)]//���� � ����������� - ����� � �����������/ �������������
        [InlineData(10, 1)]
        public void TestShapeAdd(double contHeight, double ballRad)
        {
            var box = new Box(contHeight);
            var ball = new Ball(ballRad);

            Assert.True(box.Add(ball));
        }

    }
}
