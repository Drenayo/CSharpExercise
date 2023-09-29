using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{
    // 声明委托
    public delegate void GreetingDelegate(string name);
    

    class 事件与委托
    {
        // 声明事件  需要依赖与委托（对委托做一层封装，之后使用委托都通过事件来使用，增加安全性）
        // 对事件的声明实际是声明一个私有的委托变量
        public event GreetingDelegate MakeGreetEvet;
        public void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning" + name);
        }
        public void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好" + name);
        }
        public void GreetPeople(string name, GreetingDelegate make)
        {
            // 这个方法的参数是一个委托类型
            // 你可以传入一个方法当作参数，也可以直接传入一个委托当作参数
            // 区别在于使用方法相当于临时赋值，使用委托相当于使用了“方法List的变量”，调用MakeGreeting时，会依次调用传入的“方法List变量”，也就是委托变量
            // += -= 绑定和取消绑定
            make(name);
            make.Invoke(name);
        }

        public void DoSomething(string name)
        {
            if (MakeGreetEvet != null)
            {
                // MakeGreetEvet(name); 可以使用，但是不推荐
                MakeGreetEvet?.Invoke(name);
            }
        }
    }
}
