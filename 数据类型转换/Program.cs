using System;

namespace 数据类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 显式转换
             * 有可能造成数据丢失或引发异常(因为转换失败)的任何转换都需要执行显式转换,例如,long类型转为 int,因为long的范围大于int,转换可能会引起数据丢失
             * 通过在圆括号中指定希望变量转换成的类型,表明已确认在发生显式转型时可能丢失精度和数据,或可能造成异常
             * 
             * 隐式转换
             * int类型转换成long类型时,不会发生精度的丢失,而且值不会发生根本性的改变,所以代码只需指定赋值操作符,转换将隐式地发生
             */
            //long a = 111;
            //int b = (int)a;
            //Console.WriteLine(b.ToString());
            //checked
            unchecked  //unchecked块来强制不进行溢出检查,块中溢出的赋值不会引发异常
            {
                //未处理异常:System.OverflowException:算术运算导致溢出
                int n = int.MaxValue;
                n = n + 1;
                Console.WriteLine(n);
            }

            //parse()方法
            //Convert.ToInt32()
            //ToString()方法,对于引用类型返回数据类型的名称，必须重写ToString()
            //TryParse()
            Console.ReadKey();
        }
    }
}
