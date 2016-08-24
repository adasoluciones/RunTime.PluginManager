
namespace Ada.Framework.RunTime.PluginManager
{
    public interface IPlugin
    {
        void PostInstall();
        void Uninstall();
        void Update();
    }
}
