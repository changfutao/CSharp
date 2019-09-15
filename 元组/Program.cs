using System;

namespace 元组
{
    class Program
    {
        static void Main(string[] args)
        {
            var returnData = ComputeNum(1, 2);
            Console.WriteLine($"Num:{returnData.num.ToString()},Message:{returnData.message}");
            Console.ReadKey();
        }

        /// <summary>
        /// 1.将元组赋给单独声明的变量
        /// </summary>
        static void ValueTuple1()
        {
            (string country, string capital, double gdpPerCapita) = ("Malawi", "Lilongwe", 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {country},{capital}:{gdpPerCapita}");
        }
        /// <summary>
        /// 2.将元组赋给预声明的变量
        /// </summary>
        static void ValueTuple2()
        {
            string country;
            string capital;
            double gdpPerCapita;
            (country, capital, gdpPerCapita) = ("Malawi", "Lilongwe", 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {country},{capital}:{gdpPerCapita}");
        }
        /// <summary>
        /// 3.将元组赋给单独声明和隐式类型的变量
        /// </summary>
        static void ValueTuple3()
        {
            (var country, var capital, var gdpPerCapita) = ("Malawi", "Lilongwe", 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {country},{capital}:{gdpPerCapita}");
        }
        /// <summary>
        /// 4.将元组赋给单独声明和隐式类型的变量,但只用了一个var
        /// </summary>
        static void ValueTuple4()
        {
            var (country, capital, gdpPerCapita) = ("Malawi", "Lilongwe", 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {country},{capital}:{gdpPerCapita}");
        }
        /// <summary>
        /// 5.声明具名元组,将元组值赋给它,按名称访问元组项
        /// </summary>
        static void ValueTuple5()
        {
            (string country, string capital, double gdpPerCapita) countryInfo = ("Malawi", "Lilongwe", 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {countryInfo.country},{countryInfo.capital}:{countryInfo.gdpPerCapita}");
        }
        /// <summary>
        /// 6.声明包含具名元组,将其赋给隐式类型的变量,按名称访问元组项
        /// </summary>
        static void ValueTuple6()
        {
            var countryInfo = (Name: "Malawi", capital: "Lilongwe", gdpPerCapita: 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {countryInfo.Name},{countryInfo.capital}:{countryInfo.gdpPerCapita}");
        }
        /// <summary>
        /// 7.将元组项未具名的元组赋给隐式类型的变量,通过项编号属性访问单独的元素
        /// </summary>
        static void ValueTuple7()
        {
            var countryInfo = ("Malawi", "Lilongwe", 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {countryInfo.Item1},{countryInfo.Item2}:{countryInfo.Item3}");
        }
        /// <summary>
        /// 将元组项具名的元组赋给隐式类型的变量,但还是通过项编号属性访问单独的元素
        /// </summary>
        static void ValueTuple8()
        {
            var countryInfo = (Name: "Malawi", capital: "Lilongwe", gdpPerCapita: 226.50);
            Console.WriteLine($"the poorest country in the world in 2017 was {countryInfo.Name},{countryInfo.capital}:{countryInfo.gdpPerCapita}");
        }

        static void ValueTuple9()
        {
            string country = "Malawi";
            string capital = "Lilongwe";
            double gdpPerCapita = 226.50;
            var countryInfo = (country, capital, gdpPerCapita);
            Console.WriteLine($"the poorest country in the world in 2017 was {countryInfo.country},{countryInfo.capital}:{countryInfo.gdpPerCapita}");
        }

        static (int num,string message) ComputeNum(int a, int b)
        {
            int c = a + b;
            string message = "成功";
            return (c, message);
        }

      
    }
}
