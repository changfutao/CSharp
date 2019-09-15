using System;
using static System.Console;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.字符串插值是调用String.Format()方法的语法糖
             * 2.C# 6.0新增 using static指令,using static System.Console; 下次直接使用WriteLine();该指令只支持静态方法和属性,不支持实例成员
             * using 作用于它所在的整个文件(或命名空间),而非仅作用于静态成员
             * 3.string类型的一个关键特征是它不可变。string msg="aaa";  msg =msg.ToUpper(); 不会将再同一个内存位置将字符串中的字母全部转换为大写。只能再其他内存位置新建字符串,让它成为旧字符串大写版本,旧字符串不会被修改,如果没有引用它,会被垃圾回收
             * 4.如果有大量字符串需要修改,使用StringBuilder,StringBuilder会修改StringBuilder本身的数据，而不是返回新的字符串
             */
            String_换行符();
            Console.ReadKey();
        }
        /// <summary>
        /// 字面值
        /// C#允许在字符串前使用@符号,指明转义序列不被处理
        /// </summary>
        static void String_字面值()
        {
            string str = @"你好,
                           我叫常福涛""";
            Console.WriteLine(str);
        }
        /// <summary>
        /// 字符串插值
        /// 字符串可用插值技术嵌入表达式,语法是在字符串前添加$符号,并在字符串中用一对大括号嵌入表达式
        /// @ 和 $ 可以组合使用,但要先指定$,再指定@
        /// </summary>
        static void String_字符串插值()
        {
            string firstName = "常";
            string lastName = "福涛";
            Console.WriteLine($@"My Name is {firstName}
                            {lastName}");
        }

        static void String_字符串方法1()
        {
            string firstName = "常";
            string lastName = "福涛";
            string fullName = string.Format("My Name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            string _fullName = string.Concat(firstName, lastName);
            Console.WriteLine(_fullName);

            //res 相等 0 str1 < str2 负值 str1 > str2 正值
            string str1 = "option";
            string str2 = "option";
            int res = string.Compare(str1, str2);
            Console.WriteLine(res);
        }

        static void String_字符串方法2()
        {
            string msg = "I Love CSharp";
            bool isStartWithLove = msg.StartsWith("love");
            bool isEndWithCSharp = msg.EndsWith("CSharp");

            string lowerString = msg.ToLower();
            string upperString = msg.ToUpper();
            WriteLine(upperString);
        }

        static void String_字符串格式化()
        {

        }
        /// <summary>
        /// Windows的换行符 \r\n,UNIX 则是单个\n
        /// System.Environment.NewLine 代表换行符(确保跨平台兼容性)
        /// </summary>
        static void String_换行符()
        {
            Console.WriteLine("Hello World");
            Console.Write("Hello World" + System.Environment.NewLine);
        }
        /// <summary>
        /// 字符串长度
        /// 判断字符串长度可以使用string的Length成员，该成员是只读,不能设置的(字符串是不可变的)
        /// </summary>
        static void String_字符串长度()
        {
            string msg = "哈哈哈";
            Console.WriteLine(msg.Length);
        }

        static void String_StringBuilder()
        {

        }
    }
}
