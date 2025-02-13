using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using static C43_G01_LINQ02.ListGenerator;
namespace C43_G01_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("dictionary_english.txt");
            #region LINQ - Aggregate Operators
            #region 1. Get the total units in stock for each product category.
            //var result = ProductsList.Where(p => p.UnitsInStock >= 0).GroupBy(p => p.Category).Select(p => new
            //{
            //    categoryName = p.Key,
            //    unitsInStock = p.Sum(p => p.UnitsInStock),
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            #endregion
            #region 2. Get the cheapest price among each category's products
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    categoryName = p.Key,
            //    unitsPrice = p.Min(p => p.UnitPrice),
            //}).OrderBy(p => p.unitsPrice).First();
            //Console.WriteLine($"Category: {result.categoryName}, Price: {result.unitsPrice:C}");
            #endregion
            #region 3. Get the products with the cheapest price in each category (Use Let)
            //مش عارف احلها وبعتلك كنت قافل ف هحضرها في الوورك شوب

            #endregion
            #region 4. Get the most expensive price among each category's products.
            //var result = ProductsList.GroupBy(p => p.Category).Select(g => new
            //{
            //    categoryName = g.Key,
            //    price = g.Max(g => g.UnitPrice),
            //}).OrderBy(p => p.price).First();
            //Console.WriteLine(result);
            #endregion
            #region 5. Get the products with the most expensive price in each category.
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => p.OrderByDescending(p=>p.UnitPrice).First());
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} , {item.ProductName} , {item.UnitPrice}");
            //}
            #endregion
            #region 6. Get the average price of each category's products
            //var result = ProductsList.GroupBy(p => p.Category).Select(
            //    p =>new
            //    {
            //        categoryName = p.Key,
            //        AvgPrice = p.Select(p=>p.UnitPrice).Average()
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var result = ProductsList.GroupBy(p => p.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //}
            #endregion
            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductsList.Select(p => p.ProductName[0])
            //    .Union( CustomersList.Select(p => p.CustomerName[0]).Distinct());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(p => p.CustomerName[0]).Distinct());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductsList.Select(p => p.ProductName[0]).Except(CustomersList.Select(p => p.CustomerName[0]).Distinct());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductsList.Select(p => p.ProductName.TakeLast(3).ToArray()).Concat(CustomersList.Select(c => c.CustomerName.TakeLast(3).ToArray()));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}         
            #endregion

            #endregion
            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var result = CustomersList.Where(c => c.Region == "WA").Select(c => new
            //{
            //    customerName = c.CustomerName,
            //    Region = c.Region,
            //    order = c.Orders.Take(3),

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"CustomerName: {item.customerName}, Region: {item.Region}");
            //    foreach (var order in item.order)
            //    {
            //        Console.WriteLine($"Order: {order}");
            //    }
            //}
            #endregion
            #region 2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomersList.Where(x=>x.Region == "WA").Select(p => new
            //{
            //    customerName = p.CustomerName,
            //    Region = p.Region,
            //    orders = p.Orders.Skip(2),
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"CustomerName: {item.customerName} , Region: {item.Region}");
            //    foreach( var item2 in item.orders) Console.WriteLine(item2);
            //}

            #endregion
            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((n, i) => n > i);
            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion
            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (int n in result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((n, i) => n > i);
            //foreach (int n in result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #endregion
            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var result = words.Any(p => p.Contains("ei"));
            //if (result)
            //{
            //    Console.WriteLine("there is words contain the substring 'ei'");

            //}
            //    else
            //    {
            //        Console.WriteLine("none");
            //    }
            #endregion
            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductsList.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock == 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"categoryName :{item.Key}");
            //    foreach(var item2 in item)
            //        Console.WriteLine($"\t \t ProductName: {item2.ProductName} , Units: {item2.UnitsInStock}");
            //    Console.WriteLine("--------------------------------------------------");
            //}
            #endregion
            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ProductsList.GroupBy(p => p.Category).Where(p => p.All(p => p.UnitsInStock > 0));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //        Console.WriteLine($"\t \t ProductName: {item2.ProductName} , Units: {item2.UnitsInStock}");
            //    Console.WriteLine("--------------------------------------------------");
            //}

            #endregion

            #endregion
            #region LINQ – Grouping Operators
            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(x => x % 5);
            //foreach (var i in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {i.Key} when devided by 5:");
            //    foreach (var x in i)
            //        Console.WriteLine(x);
            //}

            #endregion
            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //var result = words.GroupBy(x => x[0]);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);

            //}

            #endregion
            #region 3. Consider this Array as an Input String [] Arr = {"from", "salt", "earn", " last", "near", "form"};
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr.GroupBy(x => new string(x.OrderBy(w => w).ToArray()));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //    Console.WriteLine("-----------------------------------");
            //}
            #endregion
            #endregion
        }
    }
}
    

