using Autofac;

namespace PalmeirasNews.IoC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC

            ConfigurationIoC.Load(builder);

            #endregion
        }
    }
}
