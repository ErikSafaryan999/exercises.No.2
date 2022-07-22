using System;

namespace exercises.No._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 myInfo = new Class1();

            myInfo.Name = "Erik";
            myInfo.Family = "Safaryan";
            myInfo.Adress = "Yerevan";
            myInfo.Age = 20;

            myInfo.writeInConsoleInfo();
        }
    }
}
