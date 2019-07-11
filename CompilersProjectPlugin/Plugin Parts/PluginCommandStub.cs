using Jacobi.Vst.Framework;
using Jacobi.Vst.Framework.Plugin;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace CompilersProject
{
    /// <summary>
    /// Публичный класс, являющийся точкой связывания managed и unmanaged кода.
    /// </summary>
    public class PluginCommandStub : StdPluginCommandStub
    {
        static PluginCommandStub()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += new ResolveEventHandler(LoadFromSameFolder);

            string folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string roslynLocation = Path.Combine(folderPath, "roslyn");
            Environment.SetEnvironmentVariable("ROSLYN_COMPILER_LOCATION", roslynLocation);
        }

        private static Assembly LoadFromSameFolder(object sender, ResolveEventArgs args)
        {
            string folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".dll");
            if (File.Exists(assemblyPath)) return Assembly.LoadFrom(assemblyPath);
            assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".exe");
            if (File.Exists(assemblyPath)) return Assembly.LoadFrom(assemblyPath);
            return null;
        }

        /// <summary>
        /// Возвращает новый объект типа IVstPlugin.
        /// </summary>
        /// <returns></returns>
        protected override IVstPlugin CreatePluginInstance()
        {
            return new Plugin();
        }
    }
}
