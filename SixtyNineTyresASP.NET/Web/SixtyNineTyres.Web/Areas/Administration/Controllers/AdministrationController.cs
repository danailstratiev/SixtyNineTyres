namespace SixtyNineTyres.Web.Areas.Administration.Controllers
{
    using SixtyNineTyres.Common;
    using SixtyNineTyres.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
