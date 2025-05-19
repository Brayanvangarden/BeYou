using System;
using System.Collections.Generic;

namespace BeYou.Infraestructure.Models;

public partial class Province
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Canton> Cantons { get; set; } = new List<Canton>();
}
