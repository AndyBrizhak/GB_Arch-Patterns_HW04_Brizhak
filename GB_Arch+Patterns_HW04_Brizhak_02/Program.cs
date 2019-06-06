using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ДЗ к уроку 4 по Курсу "Архитектуры и шаблоны программирования" Брижак Андрей
//2. Реализовать шаблон «Одиночка» для многопоточной программы с использованием класса
//Lazy<T>.

namespace GB_Arch_Patterns_HW04_Brizhak_02
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonLazy instOne = SingletonLazy.GetLazyValue();

            SingletonLazy instTwo = SingletonLazy.GetLazyValue();
        }
    }
}
