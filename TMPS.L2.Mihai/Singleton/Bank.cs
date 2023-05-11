using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L2.Mihai.Singleton
{
    // Singleton Design Pattern
    public sealed class Bank
    {
        private static readonly Bank instance = new();

        private Bank() { }

        public static Bank GetInstance()
        {
            return instance;
        }
    }
}
