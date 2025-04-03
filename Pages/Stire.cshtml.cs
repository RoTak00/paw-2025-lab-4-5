using Lab3.Models;
using Lab3.Models.ContextModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Lab3.Pages;

public class StireModel : PageModel
{
    private readonly StiriContext _stiriContext;
    
    public StireModel(StiriContext stiriContext)
    {
        _stiriContext = stiriContext;
    }

    public Stire Stire { get; set; }
    
    public IActionResult OnGet(int stireId)
    {
        Stire = _stiriContext.Stiri
            .Include(s => s.Categorie)
            .FirstOrDefault(s => s.Id == stireId);

        if (Stire == null)
        {
            return RedirectToPage("/Error");
        }

        return Page();
    }
}