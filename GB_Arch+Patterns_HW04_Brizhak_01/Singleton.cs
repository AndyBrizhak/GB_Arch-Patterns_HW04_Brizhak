namespace GB_Arch_Patterns_HW04_Brizhak_01
{
    public class Singleton
    {
        private static Singleton _inst;

        /// <summary>
        /// обьект содержащий блокируемый код
        /// </summary>
        private static readonly object ObjLock = new object();

        private Singleton() { }

        /// <summary>
        /// метод создания единственного экземпляра
        /// </summary>
        public static Singleton Inst
        {
            get
            {
                if (_inst == null)
                {
                    lock (ObjLock)
                    {
                        if (_inst == null)
                            _inst = new Singleton();
                    }
                }
                return _inst;
            }
        }
    }
}
