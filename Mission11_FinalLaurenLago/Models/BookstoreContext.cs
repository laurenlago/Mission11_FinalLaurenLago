using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mission11_FinalLaurenLago.Models;

//this is from mission 11 videos
//namespace Mission11_FinalLaurenLago.Models;
//{
//    public class BookstoreContext: DbContext
//    {
//    public BookstoreContext (DbContextOptions<BookstoreContext> options) : base(options) { }
//    public DbSet<Book> Books { get; set; }
//    }

//}

public partial class BookstoreContext : DbContext
{
    public BookstoreContext()
    {
    }

    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mission11_FinalLaurenLago.Models.Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Bookstore.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.BookId, "IX_Books_BookID").IsUnique();

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
