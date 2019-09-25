using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 索引器
{
    //以字符串为下标的索引器
    public class IDXer2
    {
        private Hashtable name = new Hashtable();
        public string this[string index]
        {
            get
            {
                return name[index].ToString();
            }
            set
            {
                name.Add(index, value);
            }

        }
    }
}
