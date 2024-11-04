using HW11.Entity;
using HW11.Servise;

IProductService productService= new ProductService();
bool isRun = true;
while (isRun)
{
    Console.WriteLine("1- Add Product");
    Console.WriteLine("2- Show All Product");
    Console.WriteLine("3- Show Product");
    Console.WriteLine("4- Update Product");
    Console.WriteLine("5- Delete Product");
    Console.WriteLine("6- Exit");
    var input = Console.ReadLine();
    try
    {
        switch (input)
        {
            case "1":
                Console.Write("enter product name: ");
                var name = Console.ReadLine();
                Console.Write("enter product pric: ");
                var pric =int.Parse(Console.ReadLine());
                Console.Write("enter product category ID: ");
                var categoryId =int.Parse(Console.ReadLine());
                Product product = new Product()
                {
                    Name = name,
                    Price = pric,
                    CategoryId = categoryId
                };
                productService.Add(product);
                Console.ReadKey();
                Console.Clear();
                break;
            case "2":
                foreach(var list in productService.GetAll())
                {  Console.WriteLine(list); }
                Console.ReadKey();
                Console.Clear();
                break;
            case "3":
                Console.Write("enter product id: ");
                var id = int.Parse(Console.ReadLine());
                var pr = productService.Get(id);
                Console.WriteLine(pr);
                Console.ReadKey();
                Console.Clear();
                break;
            case "4":
                Console.Write("enter product id: ");
                var newId = int.Parse(Console.ReadLine());
                Console.Write("enter product name: ");
                var newName = Console.ReadLine();
                Console.Write("enter product pric: ");
                var newPric = int.Parse(Console.ReadLine());
                Console.Write("enter product category ID: ");
                var newCategoryId = int.Parse(Console.ReadLine());
                var prodact = productService.Get(newId);
                prodact.Name = newName;
                prodact.Price = newPric;
                prodact.CategoryId = newCategoryId;
                productService.Update(prodact);
                Console.ReadKey();
                Console.Clear();
                break;
            case "5":
                Console.Write("enter product id: ");
                var delId = int.Parse(Console.ReadLine());
                productService.Delete(delId);
                Console.ReadKey();
                Console.Clear();
                break;
            case "6":
                isRun = false;
                break;
            default:
                Console.WriteLine("just enter nomber 1 to 6");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine("just enter nomber\n"+ex);
        Console.ReadKey();
        Console.Clear();
    }
}

