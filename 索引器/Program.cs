using System;
using System.Collections.Generic;

namespace 索引器
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
       * 1.索引器
       * 索引器允许类或者结构的实例按照与数组相同的方式进行索引。索引器类似于属性,不同之处在于他们的访问采用参数
       * 
       * 2.索引器与数组的区别
       *  2.1索引器的索引值(Index)类型不限定为整数
       *      用来访问数组的索引器(Index)一定为整数,而索引器的索引值类型可以定义为其他类型
       *  2.2索引器允许重载
       *      一个类不限定为只能定义一个索引器，只要索引器的函数签名不同，就可以定义多个索引器，可以重载它的功能。
       *3.索引器与属性的区别
       *  3.1索引器以函数签名方式this来标识,而属性采用名称来标识,名称可以任意
       *  3.2索引器可以重载,而属性不能重载
       *  3.3索引器不能用static来进行声明,而属性可以,索引器永远属于实例成员,因此不能声明为static
       */
      demo2();
      Console.Read();
    }

    static void demo1()
    {
      IDxer indexer = new IDxer();
      // "="号右边对索引器赋值,其实就是调用其set方法
      indexer[0] = "张三";
      indexer[1] = "李四";
      //输出索引器的值,其实就是调用其get方法
      Console.WriteLine(indexer[0]);
      Console.WriteLine(indexer[1]);

    }

    static void demo2()
    {
      IDXer2 indexer = new IDXer2();
      // "="号右边对索引器赋值,其实就是调用其set方法
      indexer["A01"] = "张三";
      indexer["A02"] = "李四";
      //输出索引器的值,其实就是调用其get方法
      Console.WriteLine(indexer["A01"]);
      Console.WriteLine(indexer["A02"]);
    }

    static void demo3()
    {

      //多参数索引器和索引器重载          
      FindScore fScore = new FindScore();
      fScore["张三", 1] = 98;
      fScore["张三", 2] = 100;
      fScore["张三", 3] = 95;
      fScore["李四", 1] = 96;
      //查找 张三 课程编号2 的成绩
      Console.WriteLine("李四 课程编号2 成绩为:" + fScore["李四", 1]);
      //查找所有张三的成绩
      List<Scores> listScores = fScore["张三"];
      if (listScores.Count > 0)
      {
        foreach (Scores s in listScores)
        {
          Console.WriteLine(string.Format("张三 课程编号{0} 成绩为:{1}", s.CourseId, s.Score));
        }
      }
      else
      {
        Console.WriteLine("无该学生成绩单");
      }
    }
  }
}
