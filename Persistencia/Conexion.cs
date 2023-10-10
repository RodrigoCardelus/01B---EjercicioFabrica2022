using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    internal class Conexion
    {
        private static string _cnn = "Data Source=LAPTOP-IPNHV0O3; Initial Catalog = Ventas; Integrated Security = true";

        internal static string Cnn
        {
            get { return _cnn; }
        }

    }
}
