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
            �¼���ί�е���();
            
            Console.ReadLine();
        }

        public static void �¼���ί�е���()
        {
            �¼���ί�� eventAndDel = new �¼���ί��();
            // ί��
            GreetingDelegate greetingDelegate = eventAndDel.ChineseGreeting;
            greetingDelegate += eventAndDel.EnglishGreeting;
            greetingDelegate -= eventAndDel.EnglishGreeting;
            eventAndDel.GreetPeople("���Σ�", greetingDelegate);


            // �¼�
            eventAndDel.MakeGreetEvet += eventAndDel.ChineseGreeting;
            eventAndDel.DoSomething("123");
        }

    }
}
