﻿using Sitecore.Pipelines;
using System.Web.Routing;
using System.Web.Mvc;

namespace Sitecore.Support.ExperienceForms.Mvc.Pipelines.Initialize
{
  class InitializeRoutes : Sitecore.Mvc.Pipelines.Loader.InitializeRoutes
  {
    protected override void RegisterRoutes(RouteCollection routes, PipelineArgs args)
    {
      routes.MapRoute("ShellFormBuilder", "sitecore/shell/formbuilder/{action}/{id}", new
      {
        controller = "FormBuilder",
        action = "Index",
        id = UrlParameter.Optional
      },
      new[] { "Sitecore.Support.ExperienceForms.Mvc.Controllers" }
      );

      routes.MapRoute("FormBuilder", "formbuilder/{action}/{id}", new
      {
        controller = "FormBuilder",
        action = "Index",        
        id = UrlParameter.Optional
      },
      new[] { "Sitecore.ExperienceForms.Mvc.Controllers" }
      );
      routes.MapRoute("FieldTracking", "fieldtracking/{action}", new
      {
        controller = "FieldTracking",
        action = "Register"
      },
      new[] { "Sitecore.ExperienceForms.Mvc.Controllers" }
      );

    }
  }
}