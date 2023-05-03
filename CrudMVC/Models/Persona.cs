using System;
using System.Collections.Generic;

namespace CrudMVC.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;
}
