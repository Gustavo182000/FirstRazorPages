using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages.Data.RazorPagesContext _context;

        public IndexModel(RazorPages.Data.RazorPagesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string TermoBusca { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilmeGenero { get; set; }
        public SelectList Generos { get; set; }
        public async Task OnGetAsync()
        {
            if (_context.Filme != null)
            {
                Filme = await _context.Filme.ToListAsync();

                if (!string.IsNullOrWhiteSpace(TermoBusca))
                {
                    Filme = Filme.Where(f => f.Titulo.Contains(TermoBusca)).ToList();
                }
                if (!string.IsNullOrWhiteSpace(FilmeGenero))
                {
                    Filme = Filme.Where(f => f.Genero == FilmeGenero).ToList();
                }
                Generos = new SelectList(await _context.Filme.Select(e => e.Genero).Distinct().ToListAsync());
            }
        }
    }
}
