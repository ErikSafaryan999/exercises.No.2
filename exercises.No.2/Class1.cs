using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises.No._2
{
    class Class1
    {
            // Поля класса
            public string Name, Family, Adress;
            public byte Age;

            // Метод, выводящий в консоль контактную информацию
            public void writeInConsoleInfo()
            {
                Console.WriteLine($"Name: {Name}\nLastName: {Family}\nAdress:{Adress}\nAge:{Age}");
            }
    }
}
