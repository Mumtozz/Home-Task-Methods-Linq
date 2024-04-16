using _001Select;

var category = new List<Category>();
var category1 =new Category()
{
    Id = 1,
    Name = "Fruits",
};
var category2 =new Category()
{
    Id = 2,
    Name = "Vegetables",
};
var category3 = new Category(){
    Id = 3,
    Name = "Fruits"
};

category.Add(category1);
category.Add(category2);

var productions = new List<Product>
{
    new Product {Id = 1,Name = "Apple",  Quantity = 10,Price = 1200,Category = category1},
    new Product {Id = 2,Name = "Banana",  Quantity = 20 ,Price = 2100,Category =category1 },
    new Product {Id = 3,Name = "Broccoli",  Quantity = 30,Price = 2300,Category =category2 }
};


//1.
//Выбрать все записи из таблицы "Products"
//Select all records from the "Products" table

// var res = (from pr in productions
//           select pr);
//           foreach (var pro in res)
//           {
//                 System.Console.WriteLine($"{pro.Id} {pro.Name} {pro.Quantity} {pro.Price} {pro.Category?.Name}");
//           }

//2.
//Выбрать только имена продуктов из таблицы "Products"
//Select only product names from the "Products" table
// var res2 = (from pr in productions
//            select pr);
//            foreach (var pr in res2)
//            {
//                 System.Console.WriteLine($"{pr.Name}");
//            }


//3.
//Выбрать только уникальные категории продуктов из таблицы "Products"
//Select only unique product categories from the "Products" table

var unique = productions.Select(e => e.Category).Distinct();
foreach (var pro in unique)
    System.Console.WriteLine($"{pro.Id} {pro.Name} {pro.Products}");



