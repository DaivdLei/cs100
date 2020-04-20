// 修改圆柱体的高度和底面半径 --引用类型
using System;

namespace example8
{
    class Program
    {
        static void Main(string[] args)
        {
            Column column1 = new Column();
            Circle circle1 = new Circle();
            column1.Height = 20;
            column1.circle = circle1;
            circle1.Radius = 10;
            Console.WriteLine("圆柱体高{0}，半径{1}", column1.Height, column1.circle.Radius);
            circle1.Radius = 30;
            Column column2 = new Column();
            column2.Height = 20;
            column2.circle = circle1;
            Console.WriteLine("圆柱体高{0}，半径{1}", column2.Height, column2.circle.Radius);
            Console.ReadKey();
        }
        struct Column
        {
            public Circle circle;
            public int Height;
        }
        class Circle
        {
            public int Radius;
        }
    }
}
