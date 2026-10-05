using System.ComponentModel.DataAnnotations;

namespace DionicioPujols_AP1_P1.Models;

public class Autor
{
    [Key]
    public int IdAutor { get; set; }

    [Required(ErrorMessage ="Debe ingrsar el nombre obbligatoriametne")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage ="Debe ingresar la nacionalidad Obligatoriamente")]
    public string? Nacionalidad { get; set; }

    [Required(ErrorMessage ="La fecha de nacimiento debe ser obligatoriamente")]
    public DateTime? FechaNacimiento { get; set; }

    [Required(ErrorMessage ="Debe ingresar el sueldo obligatoriamente")]
    public double sueldo { get; set; }
}
