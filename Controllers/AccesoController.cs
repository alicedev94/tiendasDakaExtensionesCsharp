using Microsoft.AspNetCore.Mvc;

using TEC_AL_0002.Models;
using TEC_AL_0002.DATA;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace TEC_AL_0002.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
        public async Task<IActionResult> Index(Usuario _usuario)
        { 
            DA_logic _Logic = new DA_logic();
            var usuario = _Logic.ValidarUsuario(_usuario.Correo, _usuario.Clave);

            if(usuario != null)
			{
                var claims = new List<Claim>
				{
                    new Claim(ClaimTypes.Name, usuario.Nombre),
                    new Claim("Correo", usuario.Correo)
                };

				foreach (string rol in usuario.Roles)
				{
                    claims.Add(new Claim(ClaimTypes.Role, rol));
				}

                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index","Home");
			}
			else
			{
                return View();
            }
        }

        public async Task<IActionResult> Salir()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Acceso");
        }
    }
}
