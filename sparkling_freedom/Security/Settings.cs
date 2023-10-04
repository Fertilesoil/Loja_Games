using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sparkling_freedom.Security
{
    public class Settings
    {
        private static string secret = "7f3d0a0c7d000d7803fe256799fac863a3ca5a97e2f95bf610c3b131c156fbd0";
        public static string Secret { get => secret; set => secret = value; }
    }
}