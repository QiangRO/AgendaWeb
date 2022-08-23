using Laboratorio_web_15_8_2022.Datos;
using Laboratorio_web_15_8_2022.Modelos;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio_web_15_8_2022.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly AplicationDbContext _context;
        public IndexModel(AplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias { get; set; }
        public async Task OnGet()
        {
            Categorias = await _context.Categoria.ToListAsync();
        }
    }
}
