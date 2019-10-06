using System;

namespace _2.考虑用readonly代替const
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
            readonly 运行期常量 
            const 编译器常量 (编译器常量能令程序运行得稍快一点,但远不如运行期常量灵活,只有当程序性能极端重要且常量取值不会随版本而变化得情况下,才可以考虑这种常量)

            区别: const 可以在方法里面声明,而readonly常量则不行
                 const 取值会嵌入目标代码
          */
        }
    }
}
