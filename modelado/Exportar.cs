using System;
using System.Collections.Generic;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class Exportar
{
    public int IdExp { get; set; }

    public int IdCom { get; set; }

    public int IdMar { get; set; }

    public decimal PesTot { get; set; }

    public DateTime? FecExp { get; set; }

    public virtual Compañium IdComNavigation { get; set; } = null!;

    public virtual Marisco IdMarNavigation { get; set; } = null!;
}
