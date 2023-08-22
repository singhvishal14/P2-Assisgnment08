using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static Employee emp;
        public static int nt()
        {
            int Value = int.Parse(Console.ReadLine());
            return Value;
        }
        public static double d()
        {
            double Value = double.Parse(Console.ReadLine());
            return Value;
        }
        public static string t()
        {
            string Value = Console.ReadLine();
            return Value;
        }
        public static DateTime dt()
        {
            DateTime Value = DateTime.Parse(Console.ReadLine());
            return Value;
        }
        static AdvancedDbEntities db;
        public static void DisplayEmployeeRecords()
        {
            foreach (Employee e in db.Employees)
            {
                Console.WriteLine("Id" + e.EmployeeId);
                Console.WriteLine("First Name" + e.FirstName);
                Console.WriteLine("Lat Name" + e.LastName);
                Console.WriteLine("Slary" + e.BirthDate);
                Console.WriteLine("Desg" + e.Salary);
                Console.WriteLine("------------------- ");

            }
        }
        public static void InsertEmployeeRecord()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee Id");
            emp.EmployeeId = nt();
            Console.WriteLine("Enter First Name");
            emp.FirstName = t();
            Console.WriteLine("Enter Lat Name");
            emp.LastName = t();
            Console.WriteLine("Enter BirthDate");
            emp.BirthDate = dt();
            Console.WriteLine("Salary");
            emp.Salary = d();

            db.Employees.Add(emp);
            db.SaveChanges();
            Console.WriteLine("Record Inserted");
        }
        public static void UpdateEmployeeRecord()
        {
            Console.WriteLine("enter Id to Update ");
            int id = nt();

            emp = db.Employees.SingleOrDefault(e => e.EmployeeId == id);
            if (emp == null)
            {
                Console.WriteLine("NO SUCH RECORD eXIST");
            }
            else
            {

                Employee emp = new Employee();
                Console.WriteLine("Enter Employee Id");
                emp.EmployeeId = nt();
                Console.WriteLine("Enter First Name");
                emp.FirstName = t();
                Console.WriteLine("Enter Lat Name");
                emp.LastName = t();
                Console.WriteLine("Enter BirthDate");
                emp.BirthDate = dt();
                Console.WriteLine("Salary");
                emp.BirthDate = dt();
                db.SaveChanges();
                Console.WriteLine("Record Updated");
            }

        }
        public static void InsertProductRecord()
        {
            Product product = new Product();
            Console.WriteLine("Enter Product ID");
            product.ProductId = nt();
            Console.WriteLine("Enter Product Name");
            product.ProductName = t();
            Console.WriteLine("Enter Description");
            product.PDescription = t();
            Console.WriteLine("Enter Release Date");
            product.ReleaseDate = dt();
            Console.WriteLine("Enter Price");
            product.Price = d();

            db.Products.Add(product);
            db.SaveChanges();
            Console.WriteLine("Product Record Inserted");
        }
        public static void DeleteProductRecord()
        {
            Console.WriteLine("Enter Product ID to delete:");
            int productId = nt();

            Product productToDelete = db.Products.FirstOrDefault(p => p.ProductId == productId);

            if (productToDelete == null)
            {
                Console.WriteLine("Product not found.");
            }
            else
            {
                db.Products.Remove(productToDelete);
                db.SaveChanges();
                Console.WriteLine("Product Record Deleted");
            }
        }
        public static void DeleteEmployeeRecord()
        {
            Console.WriteLine("enter Id to Delete ");
            int id = nt();

            emp = db.Employees.SingleOrDefault(e => e.EmployeeId == id);
            if (emp == null)
            {
                Console.WriteLine("NO SUCH RECORD eXIST");
            }
            else
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                Console.WriteLine("Record Deleted");
            }

        }
        public static void UpdateProductRecord()
        {
            Console.WriteLine("Enter Product ID to update:");
            int productId = nt();

            Product productToUpdate = db.Products.FirstOrDefault(p => p.ProductId == productId);

            if (productToUpdate == null)
            {
                Console.WriteLine("Product not found.");
            }
            else
            {
                Console.WriteLine("Enter Product Name:");
                productToUpdate.ProductName = t();
                Console.WriteLine("Enter Description:");
                productToUpdate.PDescription = t();
                Console.WriteLine("Enter Release Date:");
                productToUpdate.ReleaseDate = dt();
                Console.WriteLine("Enter Price:");
                productToUpdate.Price = d();

                db.SaveChanges();
                Console.WriteLine("Product Record Updated");
            }
        }

        public static void DisplayProductRecords()
        {
            foreach (Product prod in db.Products)
            {
                Console.WriteLine("Product ID: " + prod.ProductId);
                Console.WriteLine("Product Name: " + prod.ProductName);
                Console.WriteLine("Description: " + prod.PDescription);
                Console.WriteLine("Release Date: " + prod.ReleaseDate);
                Console.WriteLine("Price: " + prod.Price);
                Console.WriteLine("------------------- ");
            }
        }

        public static void DeleteOrderRecord()
        {
            Console.WriteLine("Enter Order ID to delete:");
            int orderId = nt();

            Order orderToDelete = db.Orders.FirstOrDefault(o => o.OrderId == orderId);

            if (orderToDelete == null)
            {
                Console.WriteLine("Order not found.");
            }
            else
            {
                db.Orders.Remove(orderToDelete);
                db.SaveChanges();
                Console.WriteLine("Order Record Deleted");
            }
        }

        public static void UpdateOrderRecord()
        {
            Console.WriteLine("Enter Order ID to update:");
            int orderId = nt();

            Order orderToUpdate = db.Orders.FirstOrDefault(o => o.OrderId == orderId);

            if (orderToUpdate == null)
            {
                Console.WriteLine("Order not found.");
            }
            else
            {
                Console.WriteLine("Enter Order Date:");
                orderToUpdate.OrderDate = dt();
                Console.WriteLine("Enter Quantity:");
                orderToUpdate.Quantity = (short)nt(); // Cast to short
                Console.WriteLine("Enter Discount:");
                orderToUpdate.Discount = (float)d(); // Cast to float
                Console.WriteLine("Enter Is Shipped (true or false):");
                orderToUpdate.IsShipped = bool.Parse(t());

                db.SaveChanges();
                Console.WriteLine("Order Record Updated");
            }
        }
        public static void InsertOrderRecord()
        {
            Order order = new Order();
            Console.WriteLine("Enter Order ID:");
            order.OrderId = nt();
            Console.WriteLine("Enter Order Date:");
            order.OrderDate = dt();
            Console.WriteLine("Enter Quantity:");
            order.Quantity = (short)nt(); // Cast to short
            Console.WriteLine("Enter Discount:");
            order.Discount = (float)d(); // Cast to float
            Console.WriteLine("Enter Is Shipped (true or false):");
            order.IsShipped = bool.Parse(t());

            db.Orders.Add(order);
            db.SaveChanges();
            Console.WriteLine("Order Record Inserted");
        }
        public static void DisplayOrderRecords()
        {
            foreach (Order order in db.Orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}");
                Console.WriteLine($"Order Date: {order.OrderDate}");
                Console.WriteLine($"Quantity: {order.Quantity}");
                Console.WriteLine($"Discount: {order.Discount}");
                Console.WriteLine($"Is Shipped: {order.IsShipped}");
                Console.WriteLine("------------------- ");
            }
        }



        static void Main(string[] args)
        {
        start:
            db = new AdvancedDbEntities();
            Console.WriteLine("Press 1 For perform on Employee Records");
            Console.WriteLine("Press 2 For perform on  Products Records");
            Console.WriteLine("Press 3 For perform on  Orders Records");
            Console.WriteLine("Press 4 For Exit");
            int d = int.Parse(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine("Press 1 For Display Employee Records");
                    Console.WriteLine("Press 2 For Insert on Employee Records");
                    Console.WriteLine("Press 3 For Update on Employee Records");
                    Console.WriteLine("Press 4 For Delete Employee Record");
                    int e = int.Parse(Console.ReadLine());
                    switch (e)
                    {
                        case 1:
                            DisplayEmployeeRecords();
                            break;
                        case 2:
                            InsertEmployeeRecord();
                            break;
                        case 3:
                            UpdateEmployeeRecord();
                            break;
                        case 4:
                            DeleteEmployeeRecord();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Press 1 For Display Product Records");
                    Console.WriteLine("Press 2 For Insert on Product Records");
                    Console.WriteLine("Press 3 For Update on Product Records");
                    Console.WriteLine("Press 4 For Delete Product Record");
                    int p = int.Parse(Console.ReadLine());
                    switch (p)
                    {
                        case 1:
                            DisplayProductRecords();
                            break;
                        case 2:
                            InsertProductRecord();
                            break;
                        case 3:
                            DeleteProductRecord();
                            break;
                        case 4:
                            UpdateProductRecord();
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Press 1 For Display Order Records");
                    Console.WriteLine("Press 2 For Insert on Order Records");
                    Console.WriteLine("Press 3 For Update on Order Records");
                    Console.WriteLine("Press 4 For Delete Order Record");
                    int o = int.Parse(Console.ReadLine());
                    switch (o)
                    {
                        case 1:
                            DisplayOrderRecords();
                            break;
                        case 2:
                            InsertOrderRecord();
                            break;
                        case 3:
                            DeleteOrderRecord();
                            break;
                        case 4:
                            UpdateOrderRecord();
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("\nDo you wish to continue CRUD operations\nIf yes press 'y' or press any key");
            char choice = char.Parse(Console.ReadLine().ToLower());
            if (choice == 'y')
            {
                goto start;
            }

        }
    }
}