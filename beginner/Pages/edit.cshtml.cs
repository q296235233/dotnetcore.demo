using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace beginner.Pages
{
    public class editModel : PageModel
    {

        private readonly IUserContext _db;

        public editModel(IUserContext db)
        {
            _db = db;
        }
        [BindProperty]
        public User user{ get; set; }

        public async Task<IActionResult> OnGetAsync(int id)

        {
               user = await _db.Users.FindAsync(id);
            if (user==null)
            {
                return RedirectToRoute("index");

            }



            return Page();
         }
        public async Task<IActionResult> OnpostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }




            _db.Attach(user).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
;            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new Exception($"user {user.Id} not found ", e);
            }
            await _db.SaveChangesAsync();
            return RedirectToPage("/index");
        }


    }
}