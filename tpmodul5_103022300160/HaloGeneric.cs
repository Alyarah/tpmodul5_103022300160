using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300160
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user" + X);
        }
    }
}
