using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProductCRUD crud = new ProductCRUD();
            //int option = 0;
            //do
            //{
            //    Console.WriteLine("1. Add Product");
            //    Console.WriteLine("2. Update Product");
            //    Console.WriteLine("3. Delete Product");
            //    Console.WriteLine("4. Display All Products");
            //    int op = Convert.ToInt32(Console.ReadLine());

            //    switch(op)
            //    {
            //        case 1:
            //            Product p1 = new Product();
            //            Console.WriteLine("Enter Product Id");
            //            p1.Id = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Product Name");
            //            p1.Name = Console.ReadLine();
            //            Console.WriteLine("Enter Product price");
            //            p1.Price = Convert.ToDouble(Console.ReadLine());

            //            crud.AddProduct(p1);
            //            break;

            //        case 2:
            //            //update
            //            Product p2 = new Product();
            //            Console.WriteLine("Enter id to modify");
            //            p2.Id = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter product name");
            //            p2.Name = Console.ReadLine();
            //            Console.WriteLine("Enter product price");
            //            p2.Price = Convert.ToDouble(Console.ReadLine());

            //            crud.UpdateProduct(p2);
            //            break;

            //        case 3:
            //            //delete
            //            Product p3 = new Product();
            //            Console.WriteLine("Enter id to modify");
            //            int id = Convert.ToInt32(Console.ReadLine());
            //            crud.DeleteProduct(id);
            //            break;

            //        case 4:
            //            //Display
            //            List<Product> list = crud.GetProducts();
            //            foreach (Product p in list)
            //            {
            //                Console.WriteLine($"{p.Id}--> {p.Name} --> {p.Price}");
            //            }
            //            break;
            //    }
            //    Console.WriteLine("Press 1 for Continue");
            //    option = Convert.ToInt32(Console.ReadLine());
            //}
            //while (option == 1);


            EmployeeCRUD cRUD = new EmployeeCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add method");
                Console.WriteLine("2. Update method");
                Console.WriteLine("3. Delete method");
                Console.WriteLine("4. Display method");

                Console.WriteLine("Enter a number");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        e1.Name = (Console.ReadLine());
                        Console.WriteLine("Enter salary");
                        e1.salary = Convert.ToInt32(Console.ReadLine());

                        cRUD.AddEmp(e1);
                        break;

                    case 2:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter id");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        e2.Name = (Console.ReadLine());
                        Console.WriteLine("Enter salary");
                        e2.salary = Convert.ToInt32(Console.ReadLine());

                        cRUD.UpdateEmp(e2);
                        break;

                    case 3:
                        Employee e3 = new Employee();
                        Console.WriteLine("enter id to modify");
                        int id = Convert.ToInt32(Console.ReadLine());
                        cRUD.DeleteEmp(id);
                        break;

                    case 4:
                        Employee e4 = new Employee();
                        List<Employee> list = cRUD.GetEmp();
                        foreach (Employee p in list)
                        {
                            Console.WriteLine($"{p.Id}--> {p.Name} --> {p.salary}");
                        }
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());

            }
            while (option == 1);
        }
    }
}
