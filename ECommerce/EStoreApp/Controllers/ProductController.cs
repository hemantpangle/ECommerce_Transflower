using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreApp.Models;
using BLL;
using BOL;
using EStoreApp.Models;

namespace EStoreApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatlogManager manager = new CatlogManager();
        List<Product> allProducts = manager.GetAllProducts();
        this.ViewData["product"] = allProducts; 
        return View();
    }

     public IActionResult Details(int id)
    {
      CatlogManager manager=new CatlogManager();
      //Product product=manager.Product(id);
      Product product = manager.GetProductById(id);
      this.ViewData["product"]=product;
      return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}