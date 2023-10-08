using System;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObjects.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("BusinessObjects.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Author 1",
                            Name = "Author 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Author 2",
                            Name = "Author 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for Author 3",
                            Name = "Author 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description for Author 4",
                            Name = "Author 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description for Author 5",
                            Name = "Author 5"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Description for Author 6",
                            Name = "Author 6"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Description for Author 7",
                            Name = "Author 7"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSale")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Description for Book 1",
                            GenreId = 1,
                            ISBN = "123456789",
                            Image = "1.jpg",
                            IsSale = true,
                            LanguageId = 1,
                            OriginalPrice = 19.99m,
                            PageCount = 300,
                            PublicationYear = 2020,
                            PublisherId = 1,
                            SellingPrice = 14.99m,
                            Title = "Book 1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Description = "Description for Book 2",
                            GenreId = 2,
                            ISBN = "987654321",
                            Image = "2.jpg",
                            IsSale = false,
                            LanguageId = 2,
                            OriginalPrice = 24.99m,
                            PageCount = 400,
                            PublicationYear = 2019,
                            PublisherId = 2,
                            SellingPrice = 19.99m,
                            Title = "Book 2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "Description for Book 3",
                            GenreId = 1,
                            ISBN = "987654322",
                            Image = "3.jpg",
                            IsSale = true,
                            LanguageId = 1,
                            OriginalPrice = 29.99m,
                            PageCount = 350,
                            PublicationYear = 2021,
                            PublisherId = 1,
                            SellingPrice = 24.99m,
                            Title = "Book 3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Description = "Description for Book 4",
                            GenreId = 3,
                            ISBN = "123456790",
                            Image = "4.jpg",
                            IsSale = true,
                            LanguageId = 3,
                            OriginalPrice = 18.99m,
                            PageCount = 280,
                            PublicationYear = 2018,
                            PublisherId = 3,
                            SellingPrice = 15.99m,
                            Title = "Book 4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            Description = "Description for Book 5",
                            GenreId = 2,
                            ISBN = "987654323",
                            Image = "5.jpg",
                            IsSale = false,
                            LanguageId = 2,
                            OriginalPrice = 34.99m,
                            PageCount = 450,
                            PublicationYear = 2022,
                            PublisherId = 2,
                            SellingPrice = 29.99m,
                            Title = "Book 5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 4,
                            Description = "Description for Book 6",
                            GenreId = 1,
                            ISBN = "123456791",
                            Image = "6.jpg",
                            IsSale = false,
                            LanguageId = 1,
                            OriginalPrice = 14.99m,
                            PageCount = 240,
                            PublicationYear = 2017,
                            PublisherId = 1,
                            SellingPrice = 11.99m,
                            Title = "Book 6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 5,
                            Description = "Description for Book 7",
                            GenreId = 1,
                            ISBN = "987654324",
                            Image = "7.jpg",
                            IsSale = true,
                            LanguageId = 3,
                            OriginalPrice = 22.99m,
                            PageCount = 320,
                            PublicationYear = 2019,
                            PublisherId = 3,
                            SellingPrice = 18.99m,
                            Title = "Book 7"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 2,
                            Description = "Description for Book 8",
                            GenreId = 2,
                            ISBN = "123456792",
                            Image = "8.jpg",
                            IsSale = true,
                            LanguageId = 2,
                            OriginalPrice = 26.99m,
                            PageCount = 380,
                            PublicationYear = 2021,
                            PublisherId = 2,
                            SellingPrice = 21.99m,
                            Title = "Book 8"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 3,
                            Description = "Description for Book 9",
                            GenreId = 1,
                            ISBN = "987654325",
                            Image = "9.jpg",
                            IsSale = false,
                            LanguageId = 1,
                            OriginalPrice = 17.99m,
                            PageCount = 260,
                            PublicationYear = 2020,
                            PublisherId = 1,
                            SellingPrice = 14.99m,
                            Title = "Book 9"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 4,
                            Description = "Description for Book 10",
                            GenreId = 3,
                            ISBN = "123456793",
                            Image = "10.jpg",
                            IsSale = true,
                            LanguageId = 3,
                            OriginalPrice = 31.99m,
                            PageCount = 420,
                            PublicationYear = 2022,
                            PublisherId = 3,
                            SellingPrice = 26.99m,
                            Title = "Book 10"
                        });
                });

            modelBuilder.Entity("BusinessObjects.CartDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CartId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("BusinessObjects.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiscountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountName = "Discount 1",
                            EndDate = new DateTime(2023, 10, 15, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(272),
                            StartDate = new DateTime(2023, 10, 1, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(265)
                        },
                        new
                        {
                            Id = 2,
                            DiscountName = "Discount 2",
                            EndDate = new DateTime(2023, 10, 18, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(274),
                            StartDate = new DateTime(2023, 10, 5, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(273)
                        },
                        new
                        {
                            Id = 3,
                            DiscountName = "Discount 3",
                            EndDate = new DateTime(2023, 10, 13, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(275),
                            StartDate = new DateTime(2023, 10, 7, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(275)
                        });
                });

            modelBuilder.Entity("BusinessObjects.Favourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("BusinessObjects.FeedBack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("BusinessObjects.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(220),
                            ApprovalStatus = 0,
                            Description = "Description for Fiction",
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 2,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(234),
                            ApprovalStatus = 1,
                            Description = "Description for Mystery",
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 3,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(235),
                            ApprovalStatus = 2,
                            Description = "Description for Science Fiction",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 4,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(235),
                            ApprovalStatus = 0,
                            Description = "Description for Fantasy",
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 5,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(236),
                            ApprovalStatus = 1,
                            Description = "Description for Romance",
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 6,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(236),
                            ApprovalStatus = 0,
                            Description = "Description for Horror",
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(237),
                            ApprovalStatus = 1,
                            Description = "Description for Adventure",
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 8,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(238),
                            ApprovalStatus = 2,
                            Description = "Description for Non-fiction",
                            Name = "Non-fiction"
                        },
                        new
                        {
                            Id = 9,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(238),
                            ApprovalStatus = 0,
                            Description = "Description for Biography",
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 10,
                            AddDate = new DateTime(2023, 10, 8, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(239),
                            ApprovalStatus = 1,
                            Description = "Description for History",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Spanish"
                        },
                        new
                        {
                            Id = 3,
                            Name = "French"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeleveryLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<bool>("IsConfirm")
                        .HasColumnType("bit");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "Customer 1",
                            CustomerPhone = "123-456-7890",
                            DeleveryLocal = "123 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 13, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(321),
                            DiscountId = 1,
                            IsConfirm = false,
                            Total = 100.00m
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Customer 2",
                            CustomerPhone = "987-654-3210",
                            DeleveryLocal = "456 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 13, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(323),
                            DiscountId = 2,
                            IsConfirm = true,
                            Total = 75.50m
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Customer 3",
                            CustomerPhone = "111-222-3333",
                            DeleveryLocal = "789 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 16, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(325),
                            DiscountId = 1,
                            IsConfirm = true,
                            Total = 90.00m
                        },
                        new
                        {
                            Id = 4,
                            CustomerName = "Customer 4",
                            CustomerPhone = "444-555-6666",
                            DeleveryLocal = "101 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 14, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(326),
                            DiscountId = 2,
                            IsConfirm = false,
                            Total = 85.75m
                        },
                        new
                        {
                            Id = 5,
                            CustomerName = "Customer 5",
                            CustomerPhone = "777-888-9999",
                            DeleveryLocal = "202 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 17, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(327),
                            DiscountId = 1,
                            IsConfirm = false,
                            Total = 120.25m
                        },
                        new
                        {
                            Id = 6,
                            CustomerName = "Customer 6",
                            CustomerPhone = "555-666-7777",
                            DeleveryLocal = "303 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 15, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(328),
                            DiscountId = 2,
                            IsConfirm = true,
                            Total = 110.50m
                        },
                        new
                        {
                            Id = 7,
                            CustomerName = "Customer 7",
                            CustomerPhone = "888-999-0000",
                            DeleveryLocal = "404 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 19, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(329),
                            DiscountId = 1,
                            IsConfirm = true,
                            Total = 95.00m
                        },
                        new
                        {
                            Id = 8,
                            CustomerName = "Customer 8",
                            CustomerPhone = "333-444-5555",
                            DeleveryLocal = "505 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 18, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(331),
                            DiscountId = 2,
                            IsConfirm = false,
                            Total = 65.25m
                        },
                        new
                        {
                            Id = 9,
                            CustomerName = "Customer 9",
                            CustomerPhone = "999-000-1111",
                            DeleveryLocal = "606 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 22, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(332),
                            DiscountId = 1,
                            IsConfirm = true,
                            Total = 135.75m
                        },
                        new
                        {
                            Id = 10,
                            CustomerName = "Customer 10",
                            CustomerPhone = "666-777-8888",
                            DeleveryLocal = "707 Delivery St",
                            DeliveryDate = new DateTime(2023, 10, 20, 20, 59, 0, 722, DateTimeKind.Local).AddTicks(333),
                            DiscountId = 2,
                            IsConfirm = false,
                            Total = 70.00m
                        });
                });

            modelBuilder.Entity("BusinessObjects.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            BookId = 1,
                            Quantity = 2,
                            UnitPrice = 50.00m
                        },
                        new
                        {
                            OrderId = 2,
                            BookId = 2,
                            Quantity = 3,
                            UnitPrice = 60.00m
                        },
                        new
                        {
                            OrderId = 3,
                            BookId = 6,
                            Quantity = 1,
                            UnitPrice = 40.00m
                        },
                        new
                        {
                            OrderId = 4,
                            BookId = 3,
                            Quantity = 2,
                            UnitPrice = 55.50m
                        },
                        new
                        {
                            OrderId = 5,
                            BookId = 4,
                            Quantity = 2,
                            UnitPrice = 48.00m
                        },
                        new
                        {
                            OrderId = 6,
                            BookId = 1,
                            Quantity = 1,
                            UnitPrice = 35.25m
                        },
                        new
                        {
                            OrderId = 7,
                            BookId = 7,
                            Quantity = 3,
                            UnitPrice = 75.00m
                        },
                        new
                        {
                            OrderId = 8,
                            BookId = 9,
                            Quantity = 2,
                            UnitPrice = 42.00m
                        },
                        new
                        {
                            OrderId = 9,
                            BookId = 10,
                            Quantity = 1,
                            UnitPrice = 65.75m
                        },
                        new
                        {
                            OrderId = 10,
                            BookId = 5,
                            Quantity = 3,
                            UnitPrice = 45.00m
                        });
                });

            modelBuilder.Entity("BusinessObjects.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Spanish"
                        },
                        new
                        {
                            Id = 3,
                            Name = "French"
                        },
                        new
                        {
                            Id = 4,
                            Name = "German"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Italian"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chinese"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Japanese"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Korean"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Russian"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Arabic"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("GoogleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("BookStore.Models.Cart", b =>
                {
                    b.HasOne("BusinessObjects.AppUser", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Book", b =>
                {
                    b.HasOne("BusinessObjects.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");

                    b.Navigation("Language");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BusinessObjects.CartDetail", b =>
                {
                    b.HasOne("BusinessObjects.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Cart", null)
                        .WithMany("CartDetails")
                        .HasForeignKey("CartId");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BusinessObjects.Favourite", b =>
                {
                    b.HasOne("BusinessObjects.Book", "Book")
                        .WithMany("Favourites")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.AppUser", "User")
                        .WithMany("Favourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Order", b =>
                {
                    b.HasOne("BusinessObjects.Discount", "Discount")
                        .WithMany("Orders")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.AppUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("Discount");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.OrderDetail", b =>
                {
                    b.HasOne("BusinessObjects.Book", "Book")
                        .WithMany("OrderDetails")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BusinessObjects.Review", b =>
                {
                    b.HasOne("BusinessObjects.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.AppUser", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Models.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("BusinessObjects.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BusinessObjects.Book", b =>
                {
                    b.Navigation("Favourites");

                    b.Navigation("OrderDetails");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BusinessObjects.Discount", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BusinessObjects.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BusinessObjects.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BusinessObjects.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BusinessObjects.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BusinessObjects.AppUser", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Favourites");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
