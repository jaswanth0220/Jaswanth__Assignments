using HandsOnModel.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace HandsOnModel.Pages
{
    public class Index1Model : PageModel
    {
        static List<Bookstore> bs = new List<Bookstore>()
        {
            new Bookstore(){Id=1,Name="bookname",Price=300,Language="English",Author="author name"}
        };
        [BindProperty]
        public Bookstore Bookstore { get; set; }
        public List<Bookstore> List
        {
            get { return bs; }
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            bs.Add(Bookstore);
            return RedirectToPage("Index1");
        }
    }
}
