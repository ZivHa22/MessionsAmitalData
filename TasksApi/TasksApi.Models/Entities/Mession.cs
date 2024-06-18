using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TasksApi.Models.Entities;

public partial class Mession
{

    public int TaskId { get; set; }

    public int UserId { get; set; }

    public string Subject { get; set; } = null!;

    public DateTime TargetDate { get; set; }

    public bool IsCompleted { get; set; }
}
