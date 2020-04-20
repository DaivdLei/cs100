// 利用枚举型描述动物类型
using System;

namespace example7
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = Animal.Cat;
            switch(animal)
            {
                case Animal.Dog:
                    Console.WriteLine("狗");
                    break;
                case Animal.Cat:
                    Console.WriteLine("猫");
                    break;
                case Animal.Mouse:
                    Console.WriteLine("老鼠");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
        enum Animal: byte
        {
            Dog = 0,
            Cat = 1,
            Mouse = 2
        }
    }
}
