using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsSiteBackend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult GetCategories()
        {
            var result = _categoryService.GetCategories();
            if (result==null)
            {
                return BadRequest(result);
            }
            return Ok(result);

        }
    }
}
