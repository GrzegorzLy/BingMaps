using SimpleInjector;

namespace BingMaps.Web.App_Start
{
    internal class SimpleInjectorDependencyResolver
    {
        private readonly Container container;

        public SimpleInjectorDependencyResolver(Container container)
        {
            this.container = container;
        }
    }
}