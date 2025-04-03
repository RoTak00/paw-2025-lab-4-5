using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab3.Models;
using Lab3.Models.ContextModels;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Pages;

public class Acasa : PageModel
{
    private readonly StiriContext _stiriContext;
    public Stire[] Stiri { get; set; }

    public Acasa(StiriContext stiriContext)
    {
        _stiriContext = stiriContext;
    }
    public void OnGet()
    {
        Stiri = _stiriContext.Stiri.Include(s => s.Categorie).ToArray();
    }
}