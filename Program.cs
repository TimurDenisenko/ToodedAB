﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToodedAB
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new Cassa());
        }
    }
}
