#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DebuggingChallenge.Models;

public class User
{
    // agregar mensaje de error
    [Required(ErrorMessage ="ingrese su nombre")]
    public string Name {get;set;}

    public string? Location {get;set;}
}