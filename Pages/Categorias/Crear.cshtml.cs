using Laboratorio_web_15_8_2022.Datos;
using Laboratorio_web_15_8_2022.Modelos;

using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Laboratorio_web_15_8_2022.Pages.Categorias
{
    public class CrearModel : PageModel
    {
        private readonly AplicationDbContext _context;
        public CrearModel(AplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Categoria Categoria { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Categoria.FechaCreacion = DateTime.Now;
            _context.Add(Categoria);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
