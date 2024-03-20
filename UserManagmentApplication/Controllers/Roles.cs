using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagementApplication.ViewModels;

namespace UserManagementApplication.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Roles : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public Roles(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _roleManager.Roles.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(RoleFormViewModel model)
        {
            if(ModelState.IsValid)
            {
                return View("Index", await _roleManager.Roles.ToListAsync());
            }

            if(await _roleManager.RoleExistsAsync(model.Name))
            {
                ModelState.AddModelError("", "Role already exists");
                return View("Index", await _roleManager.Roles.ToListAsync());
            }

            await _roleManager.CreateAsync(new IdentityRole(model.Name));

            return RedirectToAction("Index");

        }
    }
}
