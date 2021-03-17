using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                 new AppConfig() { Key = "HomeTitle", Value = "This is Home page of eShopsolution" },
                 new AppConfig() { Key = "HomeKeyword", Value = "This is home page of eShopSolution" },
                 new AppConfig() { Key = "HomeDescription", Value = "This description is  of eShopSolution" }
                 );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tieng Viet", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    ID = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    ID = 1,
                    CategoryId = 1,
                    Name = "AoNam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "San Pham ao Thoi Trang nam",
                    SeoTitle = "SanPhamAoThoiTrangNam"
                },
                new CategoryTranslation()
                {
                    ID = 2,
                    CategoryId = 1,
                    Name = "T-Shirt Men",
                    LanguageId = "en-US",
                    SeoAlias = "T-Shirt",
                    SeoDescription = "Products T-shirt Men",
                    SeoTitle = "TshirtMen"
                },
                 new CategoryTranslation()
                 {
                     ID = 3,
                     CategoryId = 2,
                     Name = "AoNu",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-nu",
                     SeoDescription = "San Pham ao Thoi Trang nam",
                     SeoTitle = "SanPhamAoThoiTrangNu"
                 },
               new CategoryTranslation()
               {
                   ID = 4,
                   CategoryId = 2,
                   Name = "Women T-Shirt ",
                   LanguageId = "en-US",
                   SeoAlias = "Women T-Shirt ",
                   SeoDescription = "Products T-shirt Women",
                   SeoTitle = "Tshirt for Women"
               }
                );

            //New Product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ID = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,


                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "AoNam",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-nam",
                     SeoDescription = "San Pham ao Thoi Trang nam",
                     SeoTitle = "SanPhamAoThoiTrangNam",
                     Details = "Mo ta San Pham"
                 },
                 new ProductTranslation()
                 {
                     Id = 2,
                     ProductId = 1,
                     Name = "Gucci T-Shirt",
                     LanguageId = "en-US",
                     SeoAlias = "T-Shirt",
                     SeoDescription = "Products T-shirt Men",
                     SeoTitle = "TshirtMen",
                     Details = "Description of product",
                     Description = ""
                 }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}
