using System;
using System.Collections.Generic;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class Marisco
{
    public int IdMar { get; set; }

    public string TipMariscos { get; set; } = null!;

    public virtual ICollection<Entrega> Entregas { get; set; } = new List<Entrega>();
}
