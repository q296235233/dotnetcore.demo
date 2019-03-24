using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace beginner.Pages
{
    public class IndexModel : PageModel
    {   private readonly IUserContext _db;

        public IndexModel(IUserContext db)                     
        {
            _db = db;   
        }
        public IList<User> users { get; private set; } 
        public async Task OnGetAsync() 
        {
            users = await _db.Users.AsNoTracking().ToListAsync();

        }
        public async Task<IActionResult>OnpostDeleteAsync(int id)
        {

            var user = await _db.Users.FindAsync(id);


            if (user!=null)
            {
                _db.Users.Remove(user);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage();
        }

    }
}
