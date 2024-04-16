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
    new Product {Id = 1,Name = "Apple",  Quantity = 10,Price = 1200,Category = category1,CategoryId = 1},
    new Product {Id = 2,Name = "Banana",  Quantity = 20 ,Price = 2100,Category =category1,CategoryId = 1 },
    new Product {Id = 3,Name = "Broccoli",  Quantity = 30,Price = 2300,Category =category2,CategoryId = 2 }
};




//1.
//Выбрать все продукты с ценой больше 1000
//Select all products with a price greater than 1000

// var res = (from pr in productions
//           where pr.Price > 1000
//           select pr);
//           foreach (var pro in res)
//           {
//                 System.Console.WriteLine($"{pro.CategoryId} {pro.Id} {pro.Name} {pro.Price} {pro.Quantity}");
//           }

//2.
//Выбрать все продукты, которые содержат слово "Apple" в названии
//Select all products that contain the word "Apple" in the name

// var res2 = from product in productions
//            where product.Name.ToLower().Contains("Apple".ToLower())
//            select product;
// foreach (var pro in res2)
// {
//     System.Console.WriteLine($"{pro.Id} {pro.Name} {pro.Price} {pro.Quantity}");

// }

//3.
//Выбрать все продукты, которые не находятся в  категории "Fruits"
//Select all products that are not in "Fruits" categories:

var res3 = from p in productions
        where p.Category!.Name.ToLower()!= "Fruits".ToLower()
        select p;

        foreach (var pr in res3)
        {
            System.Console.WriteLine($"{pr.Name} {pr.Price} {pr.Quantity}");
        }