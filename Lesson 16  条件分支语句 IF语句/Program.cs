namespace Lesson_16__条件分支语句_IF语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件分支语句");

            #region  作用  
            //让顺序执行的代码产生分支
            //if 语句 是一个 可以让我们的程序 产生逻辑变化的 语句


            #endregion

            #region  if 语句  
            //作用：满足条件时，多运行一些代码
            //语法：if(bool 类型值)//bool类型相关：bool变量 条件运算符表达式  逻辑运算符表达式
            //{
            //满足条件（TRUE）要执行的代码  写在if代码块中；
            //}
            //注意：1.if语句不需要分号
            //2.if语句可以嵌套使用


            //嵌套例子   //可以无限嵌套
            string Answer = "666";
            int Number = 114514;
            if (Console.ReadLine() == "666")
            {
                Console.WriteLine("it is right");
                if (int.Parse(Console.ReadLine()) == 114514)
                {
                    Console.WriteLine("OK");
                }
            }


            #endregion


            #region  if ......else 语句 
            //产生分支 两个选择 满足条件做什么 不满足条件做什么
            //语法：if(bool类型值）
            //{
            //      满足条件时执行的代码
            //}
            //else
            //{
            //     不满足条件时执行的代码
            //}
            //注意：
            //1.不需要分号
            //2.同样也可以嵌套
            #endregion


            #region  if......else  if......else语句
            //产生n条分支 多条道路选择  满足了第一个后  之后的都不会往下执行了
            //语法：
            //if（bool类型值）
            //{
            //   满足条件执行的代码
            //}
            //else if（bool类型值）
            //{
            //     满足条件执行的代码
            //}
            //else if（bool类型值）
            //{
            //     满足条件执行的代码
            //}......可以有n个else if
            //else
            //{
            //
            //}

            //注意：1.else 是可以省略的
            //2.也可以嵌套
            #endregion
        }
    }
}
