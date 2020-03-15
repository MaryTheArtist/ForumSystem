namespace ArtForumSystem.Web.Areas.Administration.Controllers
{
    using ArtForumSystem.Common;
    using ArtForumSystem.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
