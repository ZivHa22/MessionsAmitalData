using System;
using System.Collections.Generic;

namespace TasksApi.Models.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public virtual List<Mession>? Messions { get; set; }
}
