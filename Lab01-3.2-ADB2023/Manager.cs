using Db4objects.Db4o;
using Db4objects.Db4o.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3._2_ADB2023
{
    public class Manager
    {
        public static string DbFileName { get; set; }
        public static IObjectContainer Database => Db4oEmbedded.OpenFile(DbFileName);
    }
}
