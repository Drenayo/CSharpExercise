using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveCSharp
{
    internal class chapter1
    {
        static void Main(string[] args)
        {
            // 名字很重要，通过名字开发者就可以推断出var的实际类型
            var aObj = new A();
            Console.WriteLine($"{aObj.x}   {aObj.y}");
            Console.WriteLine("--------");

            // 为了防止数据精度损失,难以阅读维护，对于频繁数值转换，最好指明类型
            int number = DataLose.GetNumber(); // 这句话应该指明类型
            var double1 = number / 3.1f;
            double double2 = number / 3.1f;
            Console.WriteLine($"{double1}   {double2}");
            Console.WriteLine("--------");


            // 有时候使用var，编译器会自动推断给节省性能的类型，而如果指定类型，开发者可能会指定一个不是最佳的选择
            // 。。。


            // 总结，除非开发者必须需要指定类型才能让代码清晰，否则就可以考虑使用var。
            // 注意，国内由于开发者英语水平参差不齐，依靠变量名语义推断类型还是任重道远
        }

    }

    class A
    {
        public int x;
        public int y;
        public A()
        {
            x = 1;
            y = 2;
        }
    }


    class DataLose
    {
        public static int GetNumber()
        {
            return 8;
        }
    }
}




