using Autofac;
using Autofac.Integration.Mvc;
using FAM.Repository;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FAM.BLL;

namespace Presentation
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			var builder = new ContainerBuilder();
			builder.RegisterControllers(typeof(MvcApplication).Assembly);
			builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
			builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>));

			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

		}
	}
}
