using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using React;
using React.Web.Mvc;

[assembly: OwinStartup(typeof(ReactWebApp.Startup))]

namespace ReactWebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // app.UseReact
        }
    }
}
