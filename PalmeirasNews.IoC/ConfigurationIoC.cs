using Autofac;
using PalmeirasNews.Application.Services;
using PalmeirasNews.Domain.Interfaces;
using PalmeirasNews.Infrastructure.Repository;
using PalmeirasNews.Infrastructure.Repository.Interfaces;

namespace PalmeirasNews.IoC
{
    public static class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Services
            builder.RegisterType<NoticiaService>().As<INoticiaService>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<NoticiaRepository>().As<INoticiaRepository>();
            #endregion

            #endregion
        }
    }
}
