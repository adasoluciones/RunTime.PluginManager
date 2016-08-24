using NuGet;
using System.Collections.Generic;

namespace Ada.Framework.RunTime.PluginManager
{
    public class PluginManager
    {
        public static IList<IPlugin> ObtenerPluginsNuevos()
        {
            IList<IPlugin> retorno = new List<IPlugin>();

            return retorno;
        }

        public static IList<IPlugin> ObtenerPluginsInstalados()
        {
            IList<IPlugin> retorno = new List<IPlugin>();

            return retorno;
        }

        public static IList<IPlugin> ObtenerActualizaciones()
        {
            IList<IPlugin> retorno = new List<IPlugin>();

            return retorno;
        }

        public static void Update(IPlugin plugin)
        {
            IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");
            var aa = repo.GetPackages();

        }
    }
}
