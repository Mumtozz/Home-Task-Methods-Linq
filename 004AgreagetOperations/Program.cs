using _001Select;

var category = new List<Category>();
var category1 = new Category()
{
    Id = 1,
    Name = "Fruits",
};
var category2 = new Category()
{
    Id = 2,
    Name = "Vegetables",
};

category.Add(category1);
category.Add(category2);

var productions = new List<Product>
{
    new Product { Id = 1, Name = "Apple", Quantity = 10, Price = 1200, Category = category1 },
    new Product { Id = 2, Name = "Banana", Quantity = 20, Price = 2100, Category = category1 },
    new Product { Id = 3, Name = "Broccoli", Quantity = 30, Price = 2300, Category = category2 },

    new Product { Id = 4, Name = "Cucumber", Quantity = 1130, Price = 1921, Category = category2 },
    new Product { Id = 5, Name = "Watermelon", Quantity = 4100, Price = 2200, Category = category1 },
    new Product { Id = 6, Name = "Carrot", Quantity = 1005, Price = 1202, Category = category2 },
    new Product { Id = 6, Name = "Potatos", Quantity = 1005, Price = 1202, Category = category2 }
};



//1.
//Получить количество продуктов в каждой категории
//Get the number of products in each category   

// var res1 = productions.GroupBy(e => e.Category).Select(g => new {Category = g.Key,Count = g.Count()});

// foreach (var item in res1)
// System.Console.WriteLine($"{item.Category} {item.Count}");


//2.
//Получить среднюю цену продуктов в каждой категории
//Get the average price of products in each category


// var res2 = productions.GroupBy(e => e.Category).Select(g => new {Category = g.Key,AveragePrice = g.Average(e => e.Price)});
// foreach (var item in res2)
// System.Console.WriteLine($"{item.Category} {item.AveragePrice}");

//3.
//Получить максимальную цену продукта в каждой категории
//Get the maximum price of a product in each category

var res3 = productions.GroupBy(e => e.Category).Select(g => new {Category = g.Key,MaxPrice = g.Max(e => e.Price)});
foreach (var item in res3)
System.Console.WriteLine($"{item.Category} {item.MaxPrice}");



