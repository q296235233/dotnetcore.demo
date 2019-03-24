using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace beginner.Pages
{
    public class CreateModel:PageModel
    {
         

        private readonly IUserContext _db;

        public CreateModel(IUserContext db)                     
        {
            _db = db;   
        }
        


        [BindProperty]

        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }




            _db.Users.Add(User);
            await _db.SaveChangesAsync();
            return RedirectToPage("/index");

        }


        
    }
}