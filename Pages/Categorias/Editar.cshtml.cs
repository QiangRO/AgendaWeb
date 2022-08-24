using Laboratorio_web_15_8_2022.Datos;
using Laboratorio_web_15_8_2022.Modelos;

using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Laboratorio_web_15_8_2022.Pages.Categorias
{
    public class EditarModel : PageModel
    {
        private readonly AplicationDbContext _context;
        public EditarModel(AplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Categoria Categoria { get; set; }
        public async Task OnGet(int id)
        {
            Categoria = await _context.Categoria.FindAsync(id);
        }
        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CategoriaDesdeBD = await _context.Categoria.FindAsync(Categoria.Id);
                CategoriaDesdeBD.Nombre = Categoria.Nombre;
                CategoriaDesdeBD.FechaCreacion = Categoria.FechaCreacion;
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
