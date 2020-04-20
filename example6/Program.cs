// 判断矩形是否为正方形
using System;

namespace example6
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 100;
            rect.Height = 100;
            Console.WriteLine("长：{0}，宽： {1}", rect.Width,rect.Height);

            bool isSquare = rect.IsSquare();
            Console.WriteLine("是否为正方形:{0}",isSquare);
            Console.ReadKey();
        }
    }
    struct Rectangle
    {
        public int Width;
        public int Height;
        public bool IsSquare() {
            return Width == Height;
        }
    }
}
