using oginshop_doan4.Models;

namespace oginshop_doan4.Data
{
    public class SeedDB
    {
        public static void SeedData(ApplicationDbContext context)
        {
            if (context.GetProducts.Count() <= 0)
            {
                var Product1 = new Product()
                {
                    CategoryId = 1,
                    Name = "MEAT",
                    Description = "Presh Beef",
                    Inmage = "product-1.jpg",
                    Price = 200,
                    Rating = 1,
                    Quantity = 20,
                    CreatedDate = DateTime.Now


                };
                var Product2 = new Product()
                {
                    CategoryId = 2,
                    Name = "PRESH FRUIT",
                    Description = "Banana",
                    Inmage = "product-2.jpg",
                    Price = 50,
                    Rating = 2,
                    Quantity = 10,
                    CreatedDate = DateTime.Now
                };
                var Product3 = new Product()
                {
                    CategoryId = 3,
                    Name = "PRESH FRUIT",
                    Description = "grape",
                    Inmage = "product-4.jpg",
                    Price = 100,
                    Rating = 6,
                    Quantity = 100,
                    CreatedDate = DateTime.Now

                };
                var Product4 = new Product()
                {
                    CategoryId = 4,
                    Name = "Fast Food",
                    Description = "Burger",
                    Inmage = "product-5.jpg",
                    Price = 250,
                    Rating = 3,
                    Quantity = 50,
                    CreatedDate = DateTime.Now

                };
                var Product5 = new Product()
                {
                    CategoryId = 2,
                    Name = "Xoai",
                    Description = "Xoai ngot",
                    Inmage = "product-6.jpg",
                    Price = 50,
                    Rating = 7,
                    Quantity = 50,
                    CreatedDate = DateTime.Now

                };
                var Product6 = new Product()
                {
                    CategoryId = 3,
                    Name = "Dua hau",
                    Description = "Dua hau",
                    Inmage = "product-7.jpg",
                    Price = 100,
                    Rating = 10,
                    Quantity = 30,
                    CreatedDate = DateTime.Now

                };
                var Product7 = new Product()
                {
                   CategoryId = 1,
                    Name = "Tao",
                    Description = "Tao ngon vcl",
                    Inmage = "product-8.jpg",
                    Price = 150,
                    Rating = 6,
                    Quantity = 100,
                    CreatedDate = DateTime.Now

                };
                var Product8 = new Product()
                {
                    CategoryId = 4,
                    Name = "Ga ran",
                    Description = "Ga ran ngon",
                    Inmage = "product-10.jpg",
                    Price = 300,
                    Rating = 5,
                    Quantity = 100,
                    CreatedDate = DateTime.Now
                };
                var Product9 = new Product()
                {
                    CategoryId = 1,
                    Name = "Nuoc cam",
                    Description = "Nuoc cam ngon",
                    Inmage = "product-11.jpg",
                    Price = 200,
                    Rating = 10,
                    Quantity = 100,
                    CreatedDate = DateTime.Now
                };
                var Product10 = new Product()
                {
                    CategoryId = 3,
                    Name = "Hoa qua say",
                    Description = "hoa qua say ngon",
                    Inmage = "product-12.jpg",
                    Price = 200,
                    Rating = 11,
                    Quantity = 50,
                    CreatedDate = DateTime.Now
                };


                context.GetProducts.Add(Product1);
                context.GetProducts.Add(Product2);
                context.GetProducts.Add(Product3);
                context.GetProducts.Add(Product4);
                context.GetProducts.Add(Product5);
                context.GetProducts.Add(Product6);
                context.GetProducts.Add(Product7);
                context.GetProducts.Add(Product8);
                context.GetProducts.Add(Product9);
                context.GetProducts.Add(Product10);

                context.SaveChanges();
            }
            //if (context.GetOderDetails.Count() <= 0)
            //{
            //    var OderDetail1 = new OderDetail()
            //    {

            //        ProductId = 1,
            //        Price = 200,
            //        Quantity = 20,
            //        CreatedDate = DateTime.Now

            //    };
            //    var OderDetail2 = new OderDetail()
            //    {

            //        ProductId = 2,
            //        Price = 50,
            //        Quantity = 10,
            //        CreatedDate = DateTime.Now
            //    };
            //    var OderDetail3 = new OderDetail()
            //    {

            //        ProductId = 1,
            //        Price = 100,
            //        Quantity = 100,
            //        CreatedDate = DateTime.Now

            //    };
            //    var OderDetail4 = new OderDetail()
            //    {

            //        ProductId = 1,
            //        Price = 250,
            //        Quantity = 50,
            //        CreatedDate = DateTime.Now

            //    };


            //    context.GetOderDetails.Add(OderDetail1);
            //    context.GetOderDetails.Add(OderDetail2);
            //    context.GetOderDetails.Add(OderDetail3);
            //    context.GetOderDetails.Add(OderDetail4);

            //    context.SaveChanges();
            //}
            if (context.GetNews.Count() <= 0)
            {
                var News1 = new News()
                {

                    Title = "6 ways to prepare breakfast ",
                    Description = "Breakfast is essential for health",
                    Inmage = "blog-2.jpg",
                    CreatedDate = DateTime.Now

                };
                var News2 = new News()
                {

                    Title = "Visit the clean farm in the US",
                    Description = "How farms in America produce safe and healthy food",
                    Inmage = "blog-3.jpg",
                    CreatedDate = DateTime.Now
                };
                var News3 = new News()
                {

                    Title = "6 ways to prepare breakfast ",
                    Description = "Breakfast is essential for health",
                    Inmage = "blog-1.jpg",
                    CreatedDate = DateTime.Now

                };
                var News4 = new News()
                {

                    Title = "6 ways to prepare breakfast ",
                    Description = "Breakfast is essential for health",
                    Inmage = "blog-4.jpg",
                    CreatedDate = DateTime.Now

                };
                var News5 = new News()
                {

                    Title = "6 ways to prepare breakfast ",
                    Description = "Breakfast is essential for health",
                    Inmage = "blog-4.jpg",
                    CreatedDate = DateTime.Now

                };
                var News6 = new News()
                {

                    Title = "6 ways to prepare breakfast ",
                    Description = "Breakfast is essential for health",
                    Inmage = "blog-4.jpg",
                    CreatedDate = DateTime.Now

                };


                context.GetNews.Add(News1);
                context.GetNews.Add(News2);
                context.GetNews.Add(News3);
                context.GetNews.Add(News4);
                context.GetNews.Add(News5);
                context.GetNews.Add(News6);

                context.SaveChanges();
            }
            if (context.GetCategories.Count() <= 0)
            {
               
                var Category1 = new Category()
                {
                    Name = "fruit",
                };
                var Category2 = new Category()
                {
                    Name = "Fresh Meat",
                };
                var Category3 = new Category()
                {
                    Name = "Organic food",
                };
                var Category4 = new Category()
                {
                    Name = " Fastfood",
                };

                context.GetCategories.Add(Category1);
                context.GetCategories.Add(Category2);
                context.GetCategories.Add(Category3);
                context.GetCategories.Add(Category4);
               


                context.SaveChanges();
            }
        }
    }
}

