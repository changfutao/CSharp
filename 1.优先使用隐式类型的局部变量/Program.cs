using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.优先使用隐式类型的局部变量
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             var 声明隐式类型的局部变量,编译器会自动选择合适的类型。
             var声明的变量不是动态变量,是编译器编译的时候确定变量的类型(它的类型会根据赋值符号右侧的值的类型来确定)，跟JavaScript的var不同(js的var是运行时确定变量类型)
             数值类型建议不使用var,会存在类型转换
             */
            List<Person> list = new List<Person>()
            {
                new Person { Age=18, Name="张三"},
                new Person { Age=19, Name="李四"},
            };
            var q = from p in list
                    select p.Name;
            q = q.Where(x => x.Contains("三"));
            var a = 1;
            Console.ReadKey();
        }
    }
}
