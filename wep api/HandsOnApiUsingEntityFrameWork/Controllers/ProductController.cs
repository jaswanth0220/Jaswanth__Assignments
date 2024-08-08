using HandsOnApiUsingEntityFrameWork.Entities;
using HandsOnApiUsingEntityFrameWork.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEntityFrameWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //public ProductController()
        //{
        //    _productRepository = new ProductRepository();
        //}

        [HttpGet,Route("GetProducts")]
        [Authorize(Roles ="Admin")]
        public IActionResult GetAll()
        {
            var products = _productRepository.GetAll();
            return StatusCode(200, products);
        }

        [HttpGet, Route("GetProduct/{id}")]
        [Authorize(Roles ="Admin,User")]
        public IActionResult Get([FromRoute] int id)
        {
            var product = _productRepository.GetProduct(id);
            if(product!=null)
            {
                return StatusCode(200,product);
            }
            else
            {
                return StatusCode(404, "Invalid Id");
            }
        }

        [HttpPost,Route("AddProduct")]
        [Authorize(Roles = "Admin")]
        public IActionResult Add([FromBody] Product product)
        {
            _productRepository.Add(product);
            return StatusCode(200, product);
        }

        [HttpPut,Route("EditProduct")]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit([FromBody] Product product)
        {
            _productRepository.Update(product);
            return StatusCode(200, product);
        }

        [HttpDelete, Route("DeleteProduct")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromQuery] int id)
        {
            _productRepository.Delete(id);
            return Ok();
        }
    }
}
