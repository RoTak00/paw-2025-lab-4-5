using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models;

public class Stire
{
    public int Id { get; set; }
    public string Titlu { get; set; }
    public string Lead { get; set; }
    public string Continut { get; set; }
    public string Autor { get; set; }
    
    public DateTime Data { get; set; }
    
    [ForeignKey("Categorie")]
    public int CategorieId { get; set; }
    
    public Categorie Categorie { get; set; }
}