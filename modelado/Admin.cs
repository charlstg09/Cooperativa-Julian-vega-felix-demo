using System;
using System.Collections.Generic;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class Admin
{
    public int IdAdm { get; set; }

    public string Nombre { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;
}
