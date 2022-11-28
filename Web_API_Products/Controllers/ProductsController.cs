using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Data.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API_Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext context;
        private readonly IProductService productService;

        public ProductsController(ProductsDbContext context, IProductService productService)
        {
            this.context = context;
            this.productService = productService;
        }

        //[HttpGet("/all")] // GET: ~/all
        [HttpGet("all")]    // GET: ~/api/Products/all
        public IActionResult GetAll()
        {
            return Ok(productService.GetAll());
        }

        // put data to action
        // 1 - [FromQuery]: ~/api/Products/get?id=2
        // 2 - [FromRoute]: ~/api/Products/get/2

        [HttpGet("get/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var product = productService.GetById(id);

            if(product == null) return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductDTO product)
        {
            // check metadata validations
            if(!ModelState.IsValid) return BadRequest();

            productService.Create(product);

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] ProductDTO product)
        {
            if (!ModelState.IsValid) return BadRequest();

            productService.Edit(product);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            productService.Delete(id);

            return Ok();
        }
    }
}
