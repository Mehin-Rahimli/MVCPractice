using Microsoft.AspNetCore.Mvc;
using MVCProduct.Models;
using MVCProduct.ViewModels;

namespace MVCProduct.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product{Image="https://www.bhphotovideo.com/images/images2000x2000/lenovo_20bls00300_thinkpad_x140e_laptop_computer_1094621.jpg\r\n",
                
                Name="ThinkPad Lenovo",
                Description="Useful",
                Price=3200,
                DiscountPrice=150,
                Category="Computers",
                Color="Black"
                
                }

                
            };
            
            ProductViewModel viewmodels=new ProductViewModel
            {
                Products=products

            };
            return View(viewmodels);
        }


        public IActionResult Test()
        {
            string name = TempData["Name"].ToString();
            return Content(name);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
