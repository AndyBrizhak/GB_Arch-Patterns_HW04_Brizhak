using System;

namespace GB_Arch_Patterns_HW04_Brizhak_02
{
    class SingletonLazy
    {
        private static Lazy<SingletonLazy> _lazy = new Lazy<SingletonLazy>(InitFunc());

        private static Func<SingletonLazy> InitFunc()
        {

            return () => new SingletonLazy();
        }

        public SingletonLazy()
        {
        }

        internal static SingletonLazy GetLazyValue()
        {
            return _lazy.Value;
        }

    }
}
