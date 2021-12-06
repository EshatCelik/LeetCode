using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEF
{
    class Program
    {
        class Category
        {
            public int Id { get; set; }
            public string  CategoryName { get; set; }
        }
        class Product
        {
            public int Id { get; set; }
            public int CategoryId { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            var catList = new List<Category>()
            {
                new Category(){Id=1,CategoryName="Elektronik"},
                new Category(){Id=2,CategoryName="Ev"},
                new Category(){Id=3,CategoryName="yemek"},
                new Category(){Id=4,CategoryName="mutfak"},
            };
            var productList = new List<Product>()
            {
                new Product(){Id=1,Name="Telefon",CategoryId=1},
                new Product(){Id=2,Name="televizyon",CategoryId=1},
                new Product(){Id=3,Name="buzdolabı",CategoryId=2},
                new Product(){Id=4,Name="bıçak",CategoryId=4},
                new Product(){Id=5,Name="bilgisayar",CategoryId=1},
                new Product(){Id=6,Name="tablet",CategoryId=1}
            };

            var list = (from p in productList
                        join c in catList on p.CategoryId equals c.Id
                        select p).ToList();

        }
    }
}
