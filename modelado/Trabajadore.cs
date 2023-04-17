using System;
using System.Collections.Generic;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class Trabajadore
{
    public int IdTra { get; set; }

    public string NomTra { get; set; } = null!;

    public string ApelTra { get; set; } = null!;

    public string TelTra { get; set; } = null!;

    public string? Rfc { get; set; }

    public string Curp { get; set; } = null!;

    public virtual ICollection<Entrega> Entregas { get; set; } = new List<Entrega>();
}
