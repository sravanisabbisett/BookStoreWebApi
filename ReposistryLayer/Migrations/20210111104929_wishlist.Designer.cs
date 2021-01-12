﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace ReposistryLayer.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20210111104929_wishlist")]
    partial class wishlist
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("commonLayerr.Models.AdminUserRegistration", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("fullName")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("phone")
                        .IsRequired();

                    b.Property<DateTime?>("updatedAt");

                    b.HasKey("EmployeeId");

                    b.ToTable("adminUserRegistrations");
                });

            modelBuilder.Entity("commonLayerr.Models.CartItem", b =>
                {
                    b.Property<int>("cartItem_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NewOrderorderId");

                    b.Property<bool>("addedTocart");

                    b.Property<string>("loginUser");

                    b.Property<long>("price");

                    b.Property<int>("product_id");

                    b.Property<int>("quantityToBuy");

                    b.HasKey("cartItem_id");

                    b.HasIndex("NewOrderorderId");

                    b.HasIndex("product_id");

                    b.ToTable("cartItems");
                });

            modelBuilder.Entity("commonLayerr.Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .IsRequired();

                    b.Property<string>("addressType");

                    b.Property<string>("city")
                        .IsRequired();

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("fullAddress")
                        .IsRequired();

                    b.Property<string>("phone")
                        .IsRequired();

                    b.Property<string>("pincode")
                        .IsRequired();

                    b.Property<string>("state")
                        .IsRequired();

                    b.HasKey("CustomerId");

                    b.ToTable("customerDetails");
                });

            modelBuilder.Entity("commonLayerr.Models.NewOrder", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId");

                    b.HasKey("orderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("newOrders");
                });

            modelBuilder.Entity("commonLayerr.Models.Product", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("addedTocart");

                    b.Property<string>("admin_user_id");

                    b.Property<string>("author")
                        .IsRequired();

                    b.Property<string>("bookImage");

                    b.Property<string>("bookName")
                        .IsRequired();

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<long>("discountPrice");

                    b.Property<long>("price");

                    b.Property<long>("quantity");

                    b.Property<DateTime?>("updatedAt");

                    b.HasKey("product_id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("commonLayerr.Models.UserRegistration", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("fullName")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("phone")
                        .IsRequired();

                    b.Property<DateTime?>("updatedAt");

                    b.HasKey("EmployeeId");

                    b.ToTable("userRegistrations");
                });

            modelBuilder.Entity("commonLayerr.Models.Wishlist", b =>
                {
                    b.Property<int>("wishList_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("addedToCart");

                    b.Property<string>("loginUser");

                    b.Property<int>("product_id");

                    b.HasKey("wishList_id");

                    b.HasIndex("product_id");

                    b.ToTable("wishlists");
                });

            modelBuilder.Entity("commonLayerr.Models.CartItem", b =>
                {
                    b.HasOne("commonLayerr.Models.NewOrder")
                        .WithMany("orders")
                        .HasForeignKey("NewOrderorderId");

                    b.HasOne("commonLayerr.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("commonLayerr.Models.NewOrder", b =>
                {
                    b.HasOne("commonLayerr.Models.CustomerDetails", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("commonLayerr.Models.Wishlist", b =>
                {
                    b.HasOne("commonLayerr.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
