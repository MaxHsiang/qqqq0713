using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace qqqq.Models
{
    public partial class 我救浪Context : DbContext
    {
        public 我救浪Context()
        {
        }

        public 我救浪Context(DbContextOptions<我救浪Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Age> Ages { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Hgender> Hgenders { get; set; }
        public virtual DbSet<Ligation> Ligations { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberComment> MemberComments { get; set; }
        public virtual DbSet<MemberWish> MemberWishes { get; set; }
        public virtual DbSet<MemberWishColor> MemberWishColors { get; set; }
        public virtual DbSet<MyFavorite> MyFavorites { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<PetDetail> PetDetails { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Vactivity> Vactivities { get; set; }
        public virtual DbSet<VactivityCategory> VactivityCategories { get; set; }
        public virtual DbSet<VallowTime> VallowTimes { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=我救浪;Integrated Security=True");
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.;Initial Catalog=我救浪;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Age>(entity =>
            {
                entity.ToTable("Age");

                entity.Property(e => e.AgeId).HasColumnName("AgeID");

                entity.Property(e => e.AgeType).HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName).HasMaxLength(10);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ColorName).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpoyeeId);

                entity.ToTable("Employee");

                entity.Property(e => e.EmpoyeeId).HasColumnName("EmpoyeeID");

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderType).HasMaxLength(50);
            });

            modelBuilder.Entity<Hgender>(entity =>
            {
                entity.ToTable("HGender");

                entity.Property(e => e.HgenderId).HasColumnName("HGenderID");

                entity.Property(e => e.GenderType).HasMaxLength(50);
            });

            modelBuilder.Entity<Ligation>(entity =>
            {
                entity.ToTable("Ligation");

                entity.Property(e => e.LigationId).HasColumnName("LigationID");

                entity.Property(e => e.LigationType).HasMaxLength(50);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BirthdayDate).HasColumnType("date");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HgenderId).HasColumnName("HGenderID");

                entity.Property(e => e.MemberPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Member_City");

                entity.HasOne(d => d.Hgender)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.HgenderId)
                    .HasConstraintName("FK_Member_HGender");
            });

            modelBuilder.Entity<MemberComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("Member_Comment");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentDate).HasColumnType("date");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberComments)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_Member_Comment_Member");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MemberComments)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Member_Comment_Product");
            });

            modelBuilder.Entity<MemberWish>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK_Member_Adopt");

                entity.ToTable("Member_Wish");

                entity.Property(e => e.MemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemberID");

                entity.Property(e => e.AgeId).HasColumnName("AgeID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LigationId).HasColumnName("LigationID");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.YearCost).HasColumnType("money");

                entity.HasOne(d => d.Age)
                    .WithMany(p => p.MemberWishes)
                    .HasForeignKey(d => d.AgeId)
                    .HasConstraintName("FK_Member_Wish_Age");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MemberWishes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Member_Wish_Category");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MemberWishes)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Member_Adopt_City");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.MemberWishes)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Member_Wish_Gender");

                entity.HasOne(d => d.Ligation)
                    .WithMany(p => p.MemberWishes)
                    .HasForeignKey(d => d.LigationId)
                    .HasConstraintName("FK_Member_Wish_Ligation");

                entity.HasOne(d => d.Member)
                    .WithOne(p => p.MemberWish)
                    .HasForeignKey<MemberWish>(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Adopt_Member");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.MemberWishes)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_Member_Wish_Size");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.MemberWishes)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Wish_SubCategory");
            });

            modelBuilder.Entity<MemberWishColor>(entity =>
            {
                entity.ToTable("Member_Wish_Color");

                entity.Property(e => e.MemberWishColorId).HasColumnName("Member_Wish_ColorID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.MemberWishColors)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_Member_Wish_Color_Color");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberWishColors)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_Member_Wish_Color_Member_Wish");
            });

            modelBuilder.Entity<MyFavorite>(entity =>
            {
                entity.HasKey(e => e.MyFavorite1)
                    .HasName("PK_MyFavorite_1");

                entity.ToTable("MyFavorite");

                entity.Property(e => e.MyFavorite1).HasColumnName("MyFavorite");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MyFavorites)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyFavorite_Member1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MyFavorites)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyFavorite_Product1");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStatusId).HasColumnName("Order_StatusID");

                entity.Property(e => e.SendAddress).HasMaxLength(50);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Orders_Employee");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_Orders_Member");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_Orders_Order_Status");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK_Order_Detail_1");

                entity.ToTable("Order_Detail");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Detail_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Detail_Product");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("Order_Status");

                entity.Property(e => e.OrderStatusId).HasColumnName("Order_StatusID");

                entity.Property(e => e.StatusType).HasMaxLength(50);
            });

            modelBuilder.Entity<PetDetail>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_AdoptionID");

                entity.ToTable("Pet_Detail");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.AgeId).HasColumnName("AgeID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LigationId).HasColumnName("LigationID");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.YearCost).HasColumnType("money");

                entity.HasOne(d => d.Age)
                    .WithMany(p => p.PetDetails)
                    .HasForeignKey(d => d.AgeId)
                    .HasConstraintName("FK_Pet_Detail_Age");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.PetDetails)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Pet_Detail_City");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.PetDetails)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_Pet_Detail_Color");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.PetDetails)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Pet_Detail_Gender");

                entity.HasOne(d => d.Ligation)
                    .WithMany(p => p.PetDetails)
                    .HasForeignKey(d => d.LigationId)
                    .HasConstraintName("FK_Pet_Detail_Ligation");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.PetDetail)
                    .HasForeignKey<PetDetail>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdoptionID_Product");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.PetDetails)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_Pet_Detail_Size");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => e.PictureId);

                entity.ToTable("Photo");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PictureName).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Photo_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_SubCategory");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Product_Supplier");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.SizeType).HasMaxLength(50);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.ToTable("SubCategory");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.SubCategoryName).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategory_Category");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Supplier_Employee");
            });

            modelBuilder.Entity<Vactivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK_ActivityTable");

                entity.ToTable("VActivity");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.ActivityCategoryId).HasColumnName("ActivityCategoryID");

                entity.Property(e => e.ActivityPhoto).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.ActivityCategory)
                    .WithMany(p => p.Vactivities)
                    .HasForeignKey(d => d.ActivityCategoryId)
                    .HasConstraintName("FK_VActivity_VActivityCategory");
            });

            modelBuilder.Entity<VactivityCategory>(entity =>
            {
                entity.HasKey(e => e.ActivityCategoryId)
                    .HasName("PK_ActivityCategory");

                entity.ToTable("VActivityCategory");

                entity.Property(e => e.ActivityCategoryId).HasColumnName("ActivityCategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<VallowTime>(entity =>
            {
                entity.HasKey(e => e.AllowTimeId)
                    .HasName("PK_AllowTime");

                entity.ToTable("VAllowTime");

                entity.Property(e => e.AllowTimeId).HasColumnName("AllowTimeID");

                entity.Property(e => e.TimeRange).HasMaxLength(50);
            });

            modelBuilder.Entity<Volunteer>(entity =>
            {
                entity.ToTable("Volunteer");

                entity.Property(e => e.VolunteerId).HasColumnName("VolunteerID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.AllowDate).HasMaxLength(50);

                entity.Property(e => e.AllowTimeId).HasColumnName("AllowTimeID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Volunteers)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_Volunteer_VActivity");

                entity.HasOne(d => d.AllowTime)
                    .WithMany(p => p.Volunteers)
                    .HasForeignKey(d => d.AllowTimeId)
                    .HasConstraintName("FK_Volunteer_VAllowTime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Volunteers)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_Volunteer_Member");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
