using System;

namespace GB_Arch_Patterns_HW04_Brizhak_02
{
    class SingletonLazy
    {
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

        public SingletonLazy()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static SingletonLazy GetLazyValue()
        {
            return _lazy.Value;
        }

    }
}
