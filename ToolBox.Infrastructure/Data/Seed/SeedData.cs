using Microsoft.AspNetCore.Identity;
using System.Drawing.Imaging;
using ToolBox.Infrastructure.Models;
using System.Drawing;
using System.Runtime.Versioning;

namespace ToolBox.Infrastructure.Data.Seed
{
    internal class SeedData
    {
        public IdentityRole AdminRole { get; set; }
        public IdentityRole UserRole { get; set; }
        public ApplicationUser Admin { get; set; }
        public ApplicationUser User1 { get; set; }
        public ApplicationUser User2 { get; set; }
        public Category Category { get; set; }
        public Category Category1 { get; set; }
        public SubCategory SubCategory { get; set; }
        public SubCategory SubCategory1 { get; set; }
        public SubCategory SubCategory2 { get; set; }
        public SubCategory SubCategory3 { get; set; }
        public SubCategory SubCategory4 { get; set; }
        public SubCategory SubCategory5 { get; set; }
        public SubCategory SubCategory6 { get; set; }
        public SubCategory SubCategory7 { get; set; }
        public Product Product1 { get; set; }
        public Product Product2 { get; set; }
        public Product Product3 { get; set; }
        public Product Product4 { get; set; }
        public Product Product5 { get; set; }
        public Product Product6 { get; set; }
        public Product Product7 { get; set; }
        public Product Product8 { get; set; }
        public Product Product9 { get; set; }
        public Product Product10 { get; set; }
        public Product Product11 { get; set; }
        public Product Product12 { get; set; }
        public Product Product13 { get; set; }
        public Product Product14 { get; set; }
        public Product Product15 { get; set; }
        public Product Product16 { get; set; }
        public Product Product17 { get; set; }
        public ProductSubCategory ProductSubCategory1 { get; set; }
        public ProductSubCategory ProductSubCategory2 { get; set; }
        public ProductSubCategory ProductSubCategory3 { get; set; }
        public ProductSubCategory ProductSubCategory4 { get; set; }
        public ProductSubCategory ProductSubCategory5 { get; set; }
        public ProductSubCategory ProductSubCategory6 { get; set; }
        public ProductSubCategory ProductSubCategory7 { get; set; }
        public ProductSubCategory ProductSubCategory8 { get; set; }
        public ProductSubCategory ProductSubCategory9 { get; set; }
        public ProductSubCategory ProductSubCategory10 { get; set; }
        public ProductSubCategory ProductSubCategory11 { get; set; }
        public ProductSubCategory ProductSubCategory12 { get; set; }
        public ProductSubCategory ProductSubCategory13 { get; set; }
        public ProductSubCategory ProductSubCategory14 { get; set; }
        public ProductSubCategory ProductSubCategory15 { get; set; }
        public ProductSubCategory ProductSubCategory16 { get; set; }
        public ProductSubCategory ProductSubCategory17 { get; set; }
        public ProductSubCategory ProductSubCategory18 { get; set; }
        public Comment Comment1 { get; set; }
        public Comment Comment2 { get; set; }
        public Cart Cart1 { get; set; }
        public Cart Cart2 { get; set; }
        public SeedData()
        {
            SeedRole();
            SeedAdmin();
            SeedUser();
            SeedCategory();
            SeedSubCategory();
            SeedProduct();
            SeedProductSubCategory();
            SeedComment();
            SeedCart();
        }
        private void SeedRole()
        {
            AdminRole = new IdentityRole()
            {
                Id = "10acf0fb-c86b-4559-9eee-1febe790886e",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            UserRole = new IdentityRole()
            {
                Id = "f8a9f603-046f-4257-a5c6-95019dca99e9",
                Name = "User",
                NormalizedName = "USER"
            };
        }

        private void SeedAdmin()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            Admin = new ApplicationUser()
            {
                Id = "79b8a2fa-0fd5-4d3a-ab98-4d7093728c14",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                FirstName = "Admin",
                LastName = "Adminov"
            };

            Admin.PasswordHash = hasher.HashPassword(Admin, "Kotka5#");
        }

        private void SeedUser()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            User1 = new ApplicationUser()
            {
                Id = "6331660a-cf01-4033-8642-8774887bc271",
                UserName = "user1@gmail.com",
                NormalizedUserName = "USER1@GMAIL.COM",
                Email = "user1@gmail.com",
                NormalizedEmail = "USER1@GMAIL.COM",
                FirstName = "Ivan",
                LastName = "Ivanov",
            };
            User1.PasswordHash = hasher.HashPassword(User1, "Zaek5#");

            User2 = new ApplicationUser()
            {
                Id = "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
                UserName = "user2@gmail.com",
                NormalizedUserName = "USER2@GMAIL.COM",
                Email = "user2@gmail.com",
                NormalizedEmail = "USER2@GMAIL.COM",
                FirstName = "Krum",
                LastName = "Popov",
            };
            User2.PasswordHash = hasher.HashPassword(User2, "Kuche5#");
        }

        private void SeedCategory()
        {
            Category = new Category()
            {
                Id = 1,
                CategoryName = "Специализирани инструменти",
            };

            Category1 = new Category()
            {
                Id = 2,
                CategoryName = "Ръчни инструменти",
            };
        }

        private void SeedSubCategory()
        {
            SubCategory = new SubCategory()
            {
                Id = 1,
                SubCategoryName = "Mercedes",
                CategoryId = 1,
            };

            SubCategory1 = new SubCategory()
            {
                Id = 2,
                SubCategoryName = "Audi",
                CategoryId = 1,
            };
            SubCategory2 = new SubCategory()
            {
                Id = 3,
                SubCategoryName = "Opel",
                CategoryId = 1,
            };
            SubCategory3 = new SubCategory()
            {
                Id = 4,
                SubCategoryName = "Chevrolet",
                CategoryId = 1,
            };
            SubCategory4 = new SubCategory()
            {
                Id = 5,
                SubCategoryName = "Комплекти",
                CategoryId = 2
            };
            SubCategory5 = new SubCategory()
            {
                Id = 6,
                SubCategoryName = "Динамометрични ключове",
                CategoryId = 2
            };
            SubCategory6 = new SubCategory()
            {
                Id = 7,
                SubCategoryName = "Скоби",
                CategoryId = 2
            };
            SubCategory7 = new SubCategory()
            {
                Id = 8,
                SubCategoryName = "Звездогаечни ключове",
                CategoryId = 2
            };
        }

        private void SeedProduct()
        {
            string imagePath1 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\4576.jpg";

            Product1 = new Product()
            {
                Id = 1,
                ProductName = "Комплект за фиксиране на двигател - Audi 3.0 V6",
                SKU = "4576",
                ProductDescription = "Подходящ за бензинови двигатели: ASN и BBJ",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath1),
                ProductPrice = 120.00M,
                Quantity = 5,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.5M,
            };
            string imagePath2 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\6302.jpg";

            Product2 = new Product()
            {
                Id = 2,
                ProductName = "Комплект за фиксиране на двигател - Mercedes 271",
                SKU = "6302",
                ProductDescription = "Подходящ за бензинови двигатели с код на двигател 271",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath2),
                ProductPrice = 180.00M,
                Quantity = 22,
                IsInStock = true,
                IsVisible = true,
                IsPromo = true,
                PromoPrice = 145.00M,
                Weight = 2.0M,
            };

            string imagePath3 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\GAAT0805.jpg";

            Product3 = new Product()
            {
                Id = 3,
                ProductName = "Комплект oтвертки в тарелка - 8 бр.",
                SKU = "GAAT0805",
                ProductDescription = null,
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath3),
                ProductPrice = 65.00M,
                Quantity = 4,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 0.8M,
            };

            string imagePath4 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\5902.jpg";

            Product4 = new Product()
            {
                Id = 4,
                ProductName = "Комплект за фиксиране на двигател Opel / Chevrolet 1.0, 1.2, 1.4",
                SKU = "5902",
                ProductDescription = "Подходящ за три цилиндрови двигатели с ванос.",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath4),
                ProductPrice = 120.00M,
                Quantity = 0,
                IsInStock = false,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.3M,
            };

            string imagePath5 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\GAAE1101.jpg";

            Product5 = new Product()
            {
                Id = 5,
                ProductName = "Комплект oтвертки в картонена опаковка - 11 бр.",
                SKU = "GAAE1101",
                ProductDescription = "Прави отвертки: 3x75, 3.5x100, 4x100, 5.5x100, 6.5x150, 8x175, 10x200 \n\r Кръстати отвертки: PH0x60, PH1x80, PH2x100, PH3x150",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath5),
                ProductPrice = 66.34M,
                Quantity = 20,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.0M,
            };

            string imagePath6 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\GEB1203.jpg";

            Product6 = new Product()
            {
                Id = 6,
                ProductName = "Комплект oтвертки - 12 бр.",
                SKU = "GEB1203",
                ProductDescription = null,
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath6),
                ProductPrice = 90.30M,
                Quantity = 20,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.0M,
            };

            string imagePath7 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\GAAE0704.jpg";

            Product7 = new Product()
            {
                Id = 7,
                ProductName = "Комплект изолирани oтвертки - 7 бр.",
                SKU = "GAAE0704",
                ProductDescription = null,
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath7),
                ProductPrice = 35.34M,
                Quantity = 0,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 0.8M,
            };

            string imagePath8 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\GZC1401.jpg";

            Product8 = new Product()
            {
                Id = 8,
                ProductName = "Комплект oтвертки - 14 бр.",
                SKU = "GZC1401",
                ProductDescription = null,
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath8),
                ProductPrice = 92.34M,
                Quantity = 1,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.6M,
            };

            string imagePath9 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\GAAI1101.jpg";

            Product9 = new Product()
            {
                Id = 9,
                ProductName = "Динамометричен ключ със сменяеми глави 40-210 Nm.",
                SKU = "GAAI1101",
                ProductDescription = "Дължина на рамото - 578 mm \n\r Точност ± 4% \n\r 36 зъба",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath9),
                ProductPrice = 330.00M,
                Quantity = 1,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 3.2M,
            };

            string imagePath10 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\GAAF1008.jpg";

            Product10 = new Product()
            {
                Id = 10,
                ProductName = "Комплект звездогаечни ключове, удължени (10 бр.).",
                SKU = "GAAF1008",
                ProductDescription = "Изработени от хром-ванадиева легирана стомана \n\r Размери: 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 мм \n\r Гаечната глава е извита на 15 градуса за улеснен достъп",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath10),
                ProductPrice = 85.60M,
                Quantity = 10,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.2M,
            };

            string imagePath11 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\ANBV1621.jpg";

            Product11 = new Product()
            {
                Id = 11,
                ProductName = "Динамометричен ключ - 1/2“, 40 - 210 Nm",
                SKU = "ANBV1621",
                ProductDescription = "Дължина на рамото - 525 mm \n\r Точност ± 4% \n\r 24 зъба",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath11),
                ProductPrice = 108.00M,
                Quantity = 0,
                IsInStock = false,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.5M,
            };

            string imagePath12 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\DTA-200.jpg";

            Product12 = new Product()
            {
                Id = 12,
                ProductName = "Динамометричен адаптер - 1/2“, 40 - 210 NM",
                SKU = "DTA-200",
                ProductDescription = "Точност ± 2% \n\r Прецизна точност на отчитане за минимум 5000 цикъла на затягане \n\r Избор на мерни единица: Nm, Ft-Lb, In-Lb, Kg-m, Kg-cm",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath12),
                ProductPrice = 115.00M,
                Quantity = 04,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 0.4M,
            };

            string imagePath13 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\JEAB0216.jpg";

            Product13 = new Product()
            {
                Id = 13,
                ProductName = "Универсална скоба за шарнири",
                SKU = "JEAB0216",
                ProductDescription = "Отвор на челюстта - 22 mm \n\r Максимално разтваряне на челюстите - 55 mm \n\r Обща дължина - 160 мм",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath13),
                ProductPrice = 70.00M,
                Quantity = 5,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 1.3M,
            };

            string imagePath14 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\jeab0833.jpg";

            Product14 = new Product()
            {
                Id = 14,
                ProductName = "Скоба за кормилни накрайници",
                SKU = "JEAB0833",
                ProductDescription = "Размери на челюстите: \n\r А: 33 mm \n\r B: 64 mm",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath14),
                ProductPrice = 24.96M,
                Quantity = 5,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 0.00M,
                Weight = 0.8M,
            };

            string imagePath15 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\AAEB.jpg";

            Product15 = new Product()
            {
                Id = 15,
                ProductName = "Звездогаечен ключ, 21 mm",
                SKU = "AAEB2121",
                ProductDescription = null,
                Size = "21 mm",
                Characteristic = "Стандартна дължина",
                Image = ConvertImageToByteArray(imagePath15),
                ProductPrice = 12.96M,
                Quantity = 19,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 00.00M,
                Weight = 0.5M,
            };

            Product16 = new Product()
            {
                Id = 16,
                ProductName = "Удължен вездогаечен ключ, 10 mm",
                SKU = "AAEL1010",
                ProductDescription = null,
                Size = "10 mm",
                Characteristic = "Удължен",
                Image = null,
                ProductPrice = 15.96M,
                Quantity = 19,
                IsInStock = true,
                IsVisible = true,
                IsPromo = false,
                PromoPrice = 00.00M,
                Weight = 0.5M,
            };

            string imagePath17 = "C:\\Users\\nedan\\OneDrive\\Desktop\\ToolBox\\ToolBox.Infrastructure\\Images\\JEAI0167.jpg";

            Product17 = new Product()
            {
                Id = 17,
                ProductName = "Скоба за демонтаж на главини",
                SKU = "JEAI0167",
                ProductDescription = "Проектиран да работи на оси с болтове и шпилки с диаметър до 9/16\" (14.2 mm) \n\r Подходящ за главина с 4 или 5 болта, диапазон на диаметъра на кръга на шпилката от 4\" - 6\" (101.6 - 152.4 mm) \n\r Обратен чук с тегло 4.5 кг",
                Size = null,
                Characteristic = null,
                Image = ConvertImageToByteArray(imagePath17),
                ProductPrice = 124.96M,
                Quantity = 19,
                IsInStock = true,
                IsVisible = true,
                IsPromo = true,
                PromoPrice = 105.00M,
                Weight = 3.5M,
            };
        }

        private void SeedProductSubCategory()
        {
            ProductSubCategory1 = new ProductSubCategory()
            {
                ProductId = 1,
                SubCategoryId = 2
            };

            ProductSubCategory2 = new ProductSubCategory()
            {
                ProductId = 2,
                SubCategoryId = 1
            };

            ProductSubCategory3 = new ProductSubCategory()
            {
                ProductId = 3,
                SubCategoryId = 5
            };
            ProductSubCategory4 = new ProductSubCategory()
            {
                ProductId = 4,
                SubCategoryId = 3
            };
            ProductSubCategory5 = new ProductSubCategory()
            {
                ProductId = 4,
                SubCategoryId = 4
            };
            ProductSubCategory6 = new ProductSubCategory()
            {
                ProductId = 5,
                SubCategoryId = 5
            };
            ProductSubCategory7 = new ProductSubCategory()
            {
                ProductId = 6,
                SubCategoryId = 5
            };
            ProductSubCategory8 = new ProductSubCategory()
            {
                ProductId = 7,
                SubCategoryId = 5
            };
            ProductSubCategory9 = new ProductSubCategory()
            {
                ProductId = 8,
                SubCategoryId = 5
            };
            ProductSubCategory10 = new ProductSubCategory()
            {
                ProductId = 9,
                SubCategoryId = 6
            };
            ProductSubCategory11 = new ProductSubCategory()
            {
                ProductId = 10,
                SubCategoryId = 5
            };
            ProductSubCategory12 = new ProductSubCategory()
            {
                ProductId = 11,
                SubCategoryId = 6
            };
            ProductSubCategory13 = new ProductSubCategory()
            {
                ProductId = 12,
                SubCategoryId = 6
            };
            ProductSubCategory14 = new ProductSubCategory()
            {
                ProductId = 13,
                SubCategoryId = 7
            };
            ProductSubCategory15 = new ProductSubCategory()
            {
                ProductId = 14,
                SubCategoryId = 7
            };
            ProductSubCategory16 = new ProductSubCategory()
            {
                ProductId = 15,
                SubCategoryId = 8
            };
            ProductSubCategory17 = new ProductSubCategory()
            {
                ProductId = 16,
                SubCategoryId = 8
            };
            ProductSubCategory18 = new ProductSubCategory()
            {
                ProductId = 17,
                SubCategoryId = 7
            };
        }
        private void SeedComment()
        {
            Comment1 = new Comment()
            {
                Id = 1,
                ProductComment = "Много здрава скоба.",
                Time = DateTime.Now,
                UserId = "6331660a-cf01-4033-8642-8774887bc271",
                ProductId = 13
            };
            Comment2 = new Comment()
            {
                Id = 2,
                ProductComment = "Напишете какви размери има в комплекта.",
                Time = DateTime.Now,
                UserId = "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
                ProductId = 8
            };
        }

        private void SeedCart()
        {
            Cart1 = new Cart()
            {
                Id= 1,
                UserId = "6331660a-cf01-4033-8642-8774887bc271",
            };
            Cart2 = new Cart()
            {
                Id= 2,
                UserId = "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
            };
        }

        [SupportedOSPlatform("windows")]
        private byte[] ConvertImageToByteArray(string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException();
            }

            using (var memoryStream = new MemoryStream())
            {
                using (var image = Image.FromFile(imagePath))
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                }
                return memoryStream.ToArray();
            }
        }
    }
}
