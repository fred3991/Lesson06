using System;
using Xunit;
using Vectors;

namespace VectorsUnitTest
{
    public class VUnitTest
    {       
        [Theory] 
        [InlineData(1, 1, 1)]
        public void CreateVector(int x, int y, int z)
        {
            var vector = new Vector(x, y, z);           
            Assert.Equal(1.7320508, vector.Length(), 7);
        }

        [Fact]
        public void CheckVector—rossProduct()
        {
            
            var vectorA = new Vector(12, 122, -50);
            var vectorB = new Vector(134, 23, -1);
            var crossp = vectorA.—rossProduct(vectorB);

            Vector chekVect = new(1028, -6688, -16072);
            Assert.True(crossp.Length()==chekVect.Length());
        }

        [Fact]
        public void CheckCosineOfVector()
        {
            
            var vectorA = new Vector(11, 22, 33);
            var vectorB = new Vector(-11, -22, -33);
            var cosineVec = Math.Round(vectorA.CosineOfVector(vectorB),3);
            var cosine = -1;
            Assert.Equal(cosine, cosineVec,3);
        }

    }
}
