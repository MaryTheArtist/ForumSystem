﻿namespace ArtForumSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ArtForumSystem.Services.Data;
    using ArtForumSystem.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult ByName(string name)
        {
            var viewModel = this.categoriesService.GetByName<CategoryViewModel>(name);
            return this.View(viewModel);
        }
    }
}
