// 计算矩形的面积 --变量
using System;

namespace example10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine("请输入矩形的长宽:");
            rect.Width = int.Parse(Console.ReadLine());
            rect.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("矩形的面积为：{0}", rect.Area());
            Console.WriteLine("矩形的面积为：{0}", rect.TryArea());
            Console.ReadKey();
        }
        class Rectangle
        {
            public int Width;
            public int Height;
            public int TryArea()
            {
                checked
                {
                    int area = Width * Height;
                    return area;
                }
            }
            public int Area()
            {
                return Width * Height;
            }
        }
    }
}
