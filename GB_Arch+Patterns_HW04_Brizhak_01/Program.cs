//ДЗ к уроку 4 по Курсу "Архитектуры и шаблоны программирования" Брижак Андрей
//1. Реализовать шаблон «Одиночка» для многопоточной программы с использованием оператора
//lock.

namespace GB_Arch_Patterns_HW04_Brizhak_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instOne = Singleton.Inst;

            Singleton instTwo = Singleton.Inst;

        }
    }
}
