namespace ArtForumSystem.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using ArtForumSystem.Data;
    using ArtForumSystem.Data.Common.Repositories;
    using ArtForumSystem.Data.Models;
    using ArtForumSystem.Services.Data;
    using ArtForumSystem.Services.Mapping;
    using ArtForumSystem.Web.ViewModels;
    using ArtForumSystem.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public HomeController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Categories =
                    this.categoriesService.GetAll<IndexCategoryViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
