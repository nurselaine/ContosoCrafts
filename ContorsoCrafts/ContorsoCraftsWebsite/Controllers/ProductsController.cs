using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace ContorsoCraftsWebsite.Controllers
{
  [Microsoft.AspNetCore.Mvc.Route("[controller]")]
  [ApiController]

  public class ProductsController : ControllerBase 
  {
    
    public ProductsController(JsonFileProductService productService)
    {
      this.ProductService = productService;
    }

    public JsonFileProductService ProductService { get; }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
      return ProductService.GetProducts();
    }

    // [HttpPatch]
    [Microsoft.AspNetCore.Mvc.Route("Rate")]
    [HttpGet]
    public ActionResult Get([FromQuery] string ProductId,[FromQuery] int Rating)
    {

      Console.WriteLine("RATING::::" + Rating);
      ProductService.AddRating(ProductId, Rating);
      return Ok();
    }
  }
}
// http://localhost:5080/products/rate?ProductId=jenlooper-cactus&Rating=5