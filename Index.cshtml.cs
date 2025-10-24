using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StandAutomoveis.Data;
using StandAutomoveis.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandAutomoveis.Pages.Viaturas
{
    public class IndexModel : PageModel
    {
        private readonly ViaturaContext _context;

        public IndexModel(ViaturaContext context)
        {
            _context = context;
        }

        public IList<Viatura> Viaturas { get; set; } = new List<Viatura>();
        public SelectList Lojas { get; set; }

        [BindProperty(SupportsGet = true)]
        public string LojaSelecionada { get; set; }

        public async Task OnGetAsync()
        {
            var query = _context.Viaturas.AsQueryable();

            // Obter lista de lojas existentes
            var lojas = await _context.Viaturas
                .Select(v => v.Loja)
                .Distinct()
                .ToListAsync();

            Lojas = new SelectList(lojas);

            // Aplicar filtro se alguma loja foi selecionada
            if (!string.IsNullOrEmpty(LojaSelecionada) && LojaSelecionada != "Todas")
            {
                query = query.Where(v => v.Loja == LojaSelecionada);
            }

            Viaturas = await query.ToListAsync();
        }
    }
}