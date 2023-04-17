using System;
using System.Collections.Generic;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}
