using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topografía.Properties;
using System.Configuration;

namespace Topografía
{
    class Connect
    {
        public static string stringConecction()
        {
            return Settings.Default.TopografiaConnectionString1;
        }
    }
}
