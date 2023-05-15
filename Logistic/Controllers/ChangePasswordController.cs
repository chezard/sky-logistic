using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Logistic.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Claims;

namespace Logistic.Controllers
{
    [Authorize(Roles = RoleConstants.AdminRole)]
    public class ChangePasswordController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly AppDbContext db;

        public ChangePasswordController(UserManager<AppUser> userManager,
                             SignInManager<AppUser> signInManager,
                           AppDbContext db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var user = await userManager.FindByNameAsync(userName);
            if (user == null) return NotFound();
            ViewBag.UserName = user.Email;
            ViewBag.Id = user.Id;
            var role = await userManager.GetRolesAsync(user);
            var users = await db.Users.ToListAsync();
            if (role.Count > 0)
            {
                ViewBag.role = role[0].ToString();
            }

            return View(users);
        }
        public async Task<IActionResult> Details(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return View();
            }
            ChangePasswordRequestVM userMain = new ChangePasswordRequestVM()
            {
                Username = user.Email

            };
            return View(userMain);
        }
        [HttpPost]
        public async Task<IActionResult> Details(ChangePasswordRequestVM user)
        {
            var userMain = await userManager.FindByEmailAsync(user.Username);
            var token = await userManager.GeneratePasswordResetTokenAsync(userMain);

            var result = await userManager.ResetPasswordAsync(userMain, token, user.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("index");
            }
            else
            {
                ModelState.AddModelError("Password", "parol formati duzgun deyil");
                return View(user);
            }
        }
    }
}
