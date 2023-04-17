using System;
using System.Collections.Generic;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class Entrega
{
    public int IdEnt { get; set; }

    public int IdMar { get; set; }

    public int IdTra { get; set; }

    public DateTime FecEnt { get; set; }

    public decimal PesTot { get; set; }

    public virtual Marisco IdMarNavigation { get; set; } = null!;

    public virtual Trabajadore IdTraNavigation { get; set; } = null!;
}
