using System.Web.Mvc;
using Sitecore.ExperienceForms.Mvc;
using Sitecore.ExperienceForms.Processing;
using Sitecore.Mvc.Filters;
using Sitecore.ExperienceForms.Mvc.Filters;

namespace Sitecore.Support.ExperienceForms.Mvc.Controllers
{
  public class FormBuilderController : Sitecore.ExperienceForms.Mvc.Controllers.FormBuilderController
  {
    public FormBuilderController(IFormRenderingContext formRenderingContext, IFormSubmitHandler formSubmitHandler) : base(formRenderingContext, formSubmitHandler)
    {
    }

    [HttpGet]
    [SitecoreAuthorize(Roles = "sitecore\\Forms Editor")]
    [SetFormMode(Editing = true)]
    public ActionResult ShellLoad(string id)
    {

      return base.Load(id);
    }
  }
}