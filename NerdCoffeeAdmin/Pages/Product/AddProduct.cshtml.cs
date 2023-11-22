using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using NerdCoffeeAdmin.Data.Models;

namespace NerdCoffeeAdmin.Pages.Product
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public NerdCoffeeAdmin.Data.Models.Product NewProduct { get; set; } 
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        { 
            if(ModelState.IsValid)
            {
                var name = NewProduct.Name;

                return RedirectToPage("ViewAllProducts");

            }
            else
            {
                return Page();
            }

            
        }
    }
}
