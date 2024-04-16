using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContorsoCraftsWebsite.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger; 
    
    public IndexModel(ILogger<IndexModel> logger,
    JsonFileProductService productService)
    {
        _logger = logger;
        ProductService = productService;
    }

    public JsonFileProductService ProductService { get; }
    public IEnumerable<Product> Products { get; private set; }

    public void OnGet()
    {
        Products = ProductService.GetProducts();
    }
}
