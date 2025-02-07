using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestViewDb.Models;

[Table("Car")]
public partial class Car
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("category")]
    [StringLength(50)]
    public string Category { get; set; } = null!;

    [Column("house")]
    [StringLength(50)]
    public string House { get; set; } = null!;
}
