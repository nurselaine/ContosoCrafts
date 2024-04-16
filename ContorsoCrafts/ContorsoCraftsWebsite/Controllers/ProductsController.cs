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
  }
}