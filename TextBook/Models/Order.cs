using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TextBook.Models;

[Table("Order")]
public partial class Order
{
    [Key]
    [Column("OrderSK")]
    public int OrderSk { get; set; }

    [Column("StudentFK")]
    public int? StudentFk { get; set; }

    [Column("TextbookFK")]
    public int? TextbookFk { get; set; }

    [ForeignKey("StudentFk")]
    [InverseProperty("Orders")]
    public virtual Student? StudentFkNavigation { get; set; }

    [ForeignKey("TextbookFk")]
    [InverseProperty("Orders")]
    public virtual Textbook? TextbookFkNavigation { get; set; }
}
