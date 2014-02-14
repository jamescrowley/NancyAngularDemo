using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.TinyIoc;
using Owin;

[assembly: OwinStartup(typeof(NancyAngularDemo.Web.Startup))]

namespace NancyAngularDemo.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            app.UseNancy();
        }
    }
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            
        }
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);

            //conventions.ViewLocationConventions.Add((viewName, model, viewLocationContext) => string.Concat(viewLocationContext.ModulePath, "/", viewName));
        }
    }
}
