using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EwidencjaPojazdow
{
    internal static class SqlServerTypesLoader
    {
        private static bool _loaded = false;
        private static readonly object _lock = new object();

        public static void LoadNativeAssemblies()
        {
            if (_loaded)
                return;

            lock (_lock)
            {
                if (_loaded)
                    return;

                var nativeBinaryPath = AppDomain.CurrentDomain.BaseDirectory;
                var architecture = Environment.Is64BitProcess ? "x64" : "x86";
                var path = Path.Combine(nativeBinaryPath, architecture);

                if (!Directory.Exists(path))
                {
                    return;
                }

                LoadNativeAssembly(path, "msvcr120.dll");
                LoadNativeAssembly(path, "SqlServerSpatial140.dll");

                _loaded = true;
            }
        }

        private static void LoadNativeAssembly(string path, string assemblyName)
        {
            var fullPath = Path.Combine(path, assemblyName);
            if (File.Exists(fullPath))
            {
                LoadLibrary(fullPath);
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string libname);
    }
}
