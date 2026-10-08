using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TextBook.Models;

[Table("Student")]
public partial class Student
{
    [Key]
    [Column("StudentID")]
    public int StudentId { get; set; }

    [StringLength(60)]
    public string? Name { get; set; }

    [StringLength(6)]
    public string? Neptun { get; set; }

    [InverseProperty("StudentFkNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
