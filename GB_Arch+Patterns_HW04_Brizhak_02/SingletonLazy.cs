using System;

namespace GB_Arch_Patterns_HW04_Brizhak_02
{
    public class SingletonLazy
    {
       private  SingletonLazy() {}

        /// <summary>
        /// отложенная инициализация 
        /// </summary>
        private static Lazy<SingletonLazy> _lazy = new Lazy<SingletonLazy>(InitFunc());

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static Func<SingletonLazy> InitFunc()
        {
           return () => new SingletonLazy();
        }



        /// <summary>
        /// статический метод, возвращающий значение
        /// ссылочного типа на класс SingletonLazy
        /// </summary>
        /// <returns></returns>
        public static SingletonLazy GetLazyValue()
        {
            return _lazy.Value;
        }

    }
}
