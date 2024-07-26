using HandsOnModel.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandsOnModel.Pages
{
    public class GetAllModel : PageModel
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){Id=1,Price=300,Name="Mouse",Stock=10},
            new Product(){Id=2,Price=300,Name="keyboard",Stock=20},
            new Product(){Id=3,Price=400,Name="Monitor",Stock=30}
        };

        [BindProperty]
        public Product product { get; set; }
        public List<Product> List
        { 
            get { return products; }
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            products.Add(product);
            return RedirectToPage("GetAll");
        }
    }
}
