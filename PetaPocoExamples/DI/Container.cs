using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Bootstrap;
using Bootstrap.Autofac;

namespace PetaPocoExamples.DI
{
    public class Container
    {
        public void Register()
        {
            Bootstrapper.With.Autofac().UsingAutoRegistration().Start();
            var container = (IContainer)Bootstrapper.Container;
            
            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);

            var webApiResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;
        }
    }
}