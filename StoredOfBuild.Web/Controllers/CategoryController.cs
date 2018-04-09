using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoredOfBuild.Domain.DTOs;
using StoredOfBuild.Domain.Products;

namespace StoredOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStorer _categoryStorer;

        public CategoryController(CategoryStorer categoryStorer)
        {
            _categoryStorer = categoryStorer;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryDTO dto)
        {
            _categoryStorer.Store(dto);
            return View();
        }
    }
}