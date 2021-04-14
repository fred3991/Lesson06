using System;
using Xunit;
using Shapes;

namespace ShapeUnitTest
{
    public class ShUnitTest
    {
    
        
        [Fact]
        public void VolumeTest()
        {
           
            Box box = new Box(33.33); //37025,927037
            Pyramid pyramid = new(11,28); //102.66666666666667
            Ball ball = new(33); // 150532.55358940855
            Cylinder cylinder = new(10,12); //3769.9112

            Assert.Equal(37025.927037, box.Volume(), 5);
            Assert.Equal(102.66666666666, pyramid.Volume(), 8);
            Assert.Equal(150532.55358, ball.Volume(), 3);
            Assert.Equal(3769.9112, cylinder.Volume(), 2);
        }

      

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 66)]
        public void TestShapeAdd(double ballrad1, double ballrad2, double ballrad3, double ballrad4, double ballrad5, double boxH)
        {
            Ball ball1 = new(ballrad1); 
            Ball ball2 = new(ballrad2); 
            Ball ball3 = new(ballrad3); 
            Ball ball4 = new(ballrad4);
            Ball ball5 = new(ballrad5); 

            Box box = new(boxH);

            Assert.True(box.Add(ball1));
            Assert.True(box.Add(ball2));
            Assert.True(box.Add(ball3));
            Assert.True(box.Add(ball4));
            Assert.True(box.Add(ball5));

        }
    }
}
