using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            事件与委托调用();
            
            Console.ReadLine();
        }

        public static void 事件与委托调用()
        {
            事件与委托 eventAndDel = new 事件与委托();
            // 委托
            GreetingDelegate greetingDelegate = eventAndDel.ChineseGreeting;
            greetingDelegate += eventAndDel.EnglishGreeting;
            greetingDelegate -= eventAndDel.EnglishGreeting;
            eventAndDel.GreetPeople("王嘉！", greetingDelegate);


            // 事件
            eventAndDel.MakeGreetEvet += eventAndDel.ChineseGreeting;
            eventAndDel.DoSomething("123");
        }

    }
}
