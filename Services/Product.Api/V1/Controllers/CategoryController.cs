using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product.Api.V1.Models;

namespace Product.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CategoryController : ControllerBase
    {
        List<CategoryOutput> _category;
        public CategoryController()
        {
            _category = new List<CategoryOutput>();
            for (int i = 1; i < 10; i++)
                _category.Add(new CategoryOutput() { Id = i, Name = $"category {i}" });
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryOutput>> Get()
        {
            return _category;
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryOutput> Get(int id)
        {
            return _category.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
