using System.ComponentModel.DataAnnotations;

namespace DionicioPujols_AP1_P1.Models;

public class Autor
{
    [Key]
    public int IdAutor { get; set; }

    [Required(ErrorMessage = "Debe ingresar el nombre obligatoriamente")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Debe ingresar la nacionalidad obligatoriamente")]
    public string? Nacionalidad { get; set; }

    [Required(ErrorMessage = "Debe ingresar la fecha de nacimiento obligatoriamente")]
    public DateTime? FechaNacimiento { get; set; }

    [Required(ErrorMessage ="Debe ingresar el sueldo obligatoriamente")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El sueldo debe ser mayor a 0")]
    public double sueldo { get; set; }
}
