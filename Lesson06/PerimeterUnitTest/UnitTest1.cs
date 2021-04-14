using System;
using Xunit;
using Perimeter;


namespace PerimeterUnitTest
{
    public class UnitTest1
    {
        /// <summary>
        /// ���� �������� ��������� ������������
        /// </summary>
        [Fact] //[Theory] ���� � ����������� - ����� � �����������
        public void PerimeterCheck3Point()
        {
            // Arrange - ��������� ��������� ����������
            Point firstPoint = new Point(1, 1, "firstPoint");
            Point secondPoint = new Point(2, 2, "secondPoint");
            Point threePoint = new Point(3, 1, "threePoint");
            Polygon triangle = new(firstPoint, secondPoint, threePoint);           
            Assert.Equal(4.828, triangle.Perimeter(), 3);
        }
        /// <summary>
        /// ���� �������� ��������� ��������
        /// </summary>
        [Fact] //[Theory] ���� � ����������� - ����� � �����������
        public void PerimeterCheck4Point()
        {
            // Arrange - ��������� ��������� ����������
            Point firstPoint = new Point(1, 1, "firstPoint");
            Point secondPoint = new Point(2, 2, "secondPoint");
            Point threePoint = new Point(3, 1, "threePoint");
            Point fourPoint = new Point(2, -10, "fourPoint");
            Polygon kvadrat = new Polygon(firstPoint, secondPoint, threePoint, fourPoint);
            Assert.Equal(24.919, kvadrat.Perimeter(), 3);
        }

        [Fact] //[Theory] ���� � ����������� - ����� � �����������
        public void PerimeterCheck5Point()
        {
            // Arrange - ��������� ��������� ����������
            Point firstPoint = new Point(1, 1, "firstPoint");
            Point secondPoint = new Point(2, 2, "secondPoint");
            Point threePoint = new Point(3, 1, "threePoint");
            Point fourPoint = new Point(2, -10, "fourPoint");
            Point fivePoint = new Point(-5, -5, "fivePoint");
            Polygon fiveugolnik = new Polygon(firstPoint, secondPoint, threePoint, fourPoint, fivePoint);
            Assert.Equal(30.961, fiveugolnik.Perimeter(), 3);
        }


    }
}
