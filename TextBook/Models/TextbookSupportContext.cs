using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TextBook.Models;

public partial class TextbookSupportContext : DbContext
{
    public TextbookSupportContext()
    {
    }

    public TextbookSupportContext(DbContextOptions<TextbookSupportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Textbook> Textbooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=bit.uni-corvinus.hu;Database=TextbookSupport;User Id=hallgato;Password=Password123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasOne(d => d.StudentFkNavigation).WithMany(p => p.Orders).HasConstraintName("FK_Order_ToStudent");

            entity.HasOne(d => d.TextbookFkNavigation).WithMany(p => p.Orders).HasConstraintName("FK_Order_ToTextbook");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Neptun).IsFixedLength();
        });

        modelBuilder.Entity<Textbook>(entity =>
        {
            entity.Property(e => e.TextbookId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
