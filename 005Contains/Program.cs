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
    new Product { Id = 1, Name = "Apple", Quantity = 10, Price = 1200, Category = category1,CategoryId = 1 },
    new Product { Id = 2, Name = "Banana", Quantity = 20, Price = 2100, Category = category1,CategoryId = 1 },
    new Product { Id = 3, Name = "Broccoli", Quantity = 30, Price = 2300, Category = category2,CategoryId = 2 },

    new Product { Id = 4, Name = "Cucumber", Quantity = 1130, Price = 1921, Category = category2,CategoryId = 2 },
    new Product { Id = 5, Name = "Watermelon", Quantity = 4100, Price = 2200, Category = category1,CategoryId =  1 },
    new Product { Id = 6, Name = "Carrot", Quantity = 1005, Price = 1202, Category = category2,CategoryId = 2 }
};


//1.
//Получить все категории, в названии которых "Fruits"
//Get all categories with "Fruits" in their title  

var res = productions.Where(e => e.Category!.Name.ToLower().Contains("Fruits".ToLower()));
foreach (var item in res)
    System.Console.WriteLine($"{item.Name} {item.Price} {item.Quantity} {item.Category!.Name}");


//2.
//Получить все продукты, название которых "Banana"
//Get all products whose name is "Banana"

var res2 = productions.Where(e => e.Name.ToLower().Contains("Banana".ToLower()));
foreach (var item in res2)
    System.Console.WriteLine($"{item.Name} {item.Price} {item.Quantity} {item.Category!.Name}");
