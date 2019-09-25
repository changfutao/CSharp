using System;
using System.Collections.Generic;
using System.Text;

namespace 索引器
{
    /// <summary>
    /// 最简单的索引器
    /// </summary>
    public class IDxer
    {
        private string[] name = new string[10];
        //索引器必须以this关键字定义,其实这个this就是类实例化之后的对象
        public string this[int index]
        {
            get {
                return name[index];
            }
            set {
                name[index] = value;
            }
        }
    }
}
