using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TextBook.Models;

[Table("Textbook")]
public partial class Textbook
{
    [Key]
    [Column("TextbookID")]
    public int TextbookId { get; set; }

    [StringLength(15)]
    public string? StockNumber { get; set; }

    [StringLength(100)]
    public string? Title { get; set; }

    public double? Price { get; set; }

    public bool NotAvailable { get; set; }

    [InverseProperty("TextbookFkNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
