﻿using System;
using System.Collections.Generic;

namespace BeYou.Infraestructure.Models;

public partial class Gender
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
