// 计算原型的面积 --常量
using System;

namespace example9
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine("半径为{0}的圆的面积为{1}", circle.Radius, circle.Area());
            Console.ReadKey();
        }
        class Circle
        {
            const double PI = 3.14f;
            public readonly int Radius = 1;
            public Circle(int radius) {
                Radius = radius;
            }
            public double Area() 
            {
                return PI * Radius * Radius;
            }
        }
    }
}
