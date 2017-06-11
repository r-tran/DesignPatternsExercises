using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class LazyDoubleCheckedLockingProduction
    {
        public class President
        {
            private readonly static Lazy<President> presidentInstance = new Lazy<President>(() => new President());
            private President() { }

            public static President Instance => presidentInstance.Value;
        }
    }

    public class LazyImplementation
    {
        public class President
        {
            private static President presidentInstance;
            private President() { }

            public static President Instance
            {
                get
                {
                    if (presidentInstance == null)
                        presidentInstance = new President();
                    return presidentInstance;
                }
            }
        }
    }

    public class LazyImplementationUsingSyncLock
    {
        public class President
        {
            private static President _presidentInstance;
            private static readonly object _syncLock = new object();

            private President() { }

            public static President Instance
            {
                get
                {
                    lock (_syncLock)
                    {
                        if (_presidentInstance == null)
                            _presidentInstance = new President();
                    }

                    return _presidentInstance;
                }
            }
        }
    }

    public class LazyImplementationUsingDoubleCheckedSyncLock
    {
        public class President
        {
            private static President _presidentInstance;
            private static readonly object _syncLock = new object();

            private President() { }

            public static President Instance
            {
                get
                {
                    if (_presidentInstance == null)
                    {
                        lock (_syncLock)
                        {
                            if (_presidentInstance == null)
                                _presidentInstance = new President();
                        }
                    }

                    return _presidentInstance;
                }
            }
        }
    }
}
