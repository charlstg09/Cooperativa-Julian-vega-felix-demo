using System;
using System.Collections.Generic;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class Personal
{
    public int IdPer { get; set; }

    public int IdAre { get; set; }

    public string NomPer { get; set; } = null!;

    public string ApePer { get; set; } = null!;

    public string TelPer { get; set; } = null!;

    public string? Rfc { get; set; }

    public string Curp { get; set; } = null!;

    public virtual Area IdAreNavigation { get; set; } = null!;
}
