namespace BlogApp.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogModelDbContext : DbContext
    {
        public BlogModelDbContext()
            : base("name=BlogDbContext")
        {
        }

        public BlogModelDbContext(string ConnectionString)
          : base(ConnectionString)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Articles)
                .Map(m => m.ToTable("ArticleTag").MapLeftKey("ArticleId").MapRightKey("TagId"));

            modelBuilder.Entity<Author>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Author>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<Author>()
                .Property(e => e.EmailAdress)
                .IsFixedLength();

            modelBuilder.Entity<Author>()
                .Property(e => e.Explanation)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.NameSurname)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.Image)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User1)
                .WithMany(e => e.Users)
                .Map(m => m.ToTable("AuthorFollow").MapLeftKey("AuthorId").MapRightKey("UserId"));
        }
    }
}
