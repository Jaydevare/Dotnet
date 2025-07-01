using System.Data;
using WhyLinq.Models;
using System.Xml.Linq;

namespace WhyLinq;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Why LINQ!");
        //foreach (var customer in GetAllCustomers())
        //{
        //    Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}!");
        //}
        //var CityWiseCustomersCount = from customer in GetAllXmlCustomers()
        //                             group customer by customer.City into k
        //                             select new { Count = k.Count(), City = k.Key };
        //foreach (var item in CityWiseCustomersCount)
        //{
        //    Console.WriteLine($"In city {item.City}, there is/are {item.Count} number of customers!");
        //}
        //Console.WriteLine("");

        //var query1 = from customer in GetAllCustomers()
        //             select customer;
        //var query2 = from customer in GetAllCustomers()
        //             where customer.City == "Mumbai"
        //             select customer;
        //var query3 = from customer in GetAllCustomers()
        //             orderby customer.City descending, customer.ContactName
        //             select customer;
        //foreach (var customer in query3)
        //{
        //    Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}!");
        //}
        //Console.WriteLine("");
        //foreach (var order in GetAllOrders())
        //{
        //    Console.WriteLine($"Order No {order.OrderId} placed on {order.OrderDate}. Total Invoice amount INR {order.Quantity * order.UnitPrice}/-.");
        //}
        //Console.WriteLine("Customer Orders List!");

        var CustomerOrders = from customer in GetAllCustomers()
                             join
                             order in GetAllOrders()
                             on customer.CustomerId equals order.CustomerId
                             join
                             product in GetAllProducts()
                             on order.ProductId equals product.ProductId
                             join
                             employee in GetAllEmployees()
                             on order.EmployeeId equals employee.EmployeeId
                             select new
                             {
                                 CustomerName = customer.ContactName,
                                 Delivery = customer.City,
                                 OrderNumber = order.OrderId,
                                 DeliveryDate = order.RequiredDate,
                                 TotalPrice = order.Quantity * order.UnitPrice,
                                 ProductName = product.ProductName,
                                 EmployeeName = employee.EmpName
                             };
        foreach (var customerOrder in CustomerOrders) 
        {
            Console.WriteLine($"Customer {customerOrder.CustomerName} has placed order for {customerOrder.ProductName} with id {customerOrder.OrderNumber}. Needs to deliver on {customerOrder.DeliveryDate} to city {customerOrder.Delivery} collect INR {customerOrder.TotalPrice}/- .The order is handled by {customerOrder.EmployeeName}");
        }

    }
    private static List<Customer> GetAllCustomers()
    {
        return new List<Customer>() {
            new Customer(){CustomerId = 1, ContactName="Alisha C.",City="Mumbai"},
            new Customer(){CustomerId = 2, ContactName="John Mark",City="London"},
            new Customer(){CustomerId = 3, ContactName="Alicia Web",City="New York"},
            new Customer(){CustomerId = 4, ContactName="Maria Andrus",City="Mumbai"},
            new Customer(){CustomerId = 5, ContactName="Yash P. D.",City="New York"},
        };
    }

    private static List<Order> GetAllOrders()
    {
        return new List<Order> {
            new Order{CustomerId = 1,ProductId=1,OrderId=1001,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(2),Quantity=100,UnitPrice=119999.99,EmployeeId=1},
            new Order{CustomerId = 1,ProductId=2,OrderId=1002,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(2),Quantity=45,UnitPrice=79999.99,EmployeeId=1},
            new Order{CustomerId = 4,ProductId=3,OrderId=1003,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(5),Quantity=30,UnitPrice=44999.59,EmployeeId=2},
            new Order{CustomerId = 2,ProductId=4,OrderId=1004,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(3),Quantity=20,UnitPrice=99999.89,EmployeeId=3},
        };
    }
    private static List<Product> GetAllProducts()
    {
        return new List<Product>() {
            new Product(){ProductId=1,ProductName="Laptop",UnitsInStock=100},
            new Product(){ProductId=2,ProductName="Mobile",UnitsInStock=200},
            new Product(){ProductId=3,ProductName="Tablet",UnitsInStock=150},
            new Product(){ProductId=4,ProductName="Monitor",UnitsInStock=80},
        };
    }

    private static List<Employee> GetAllEmployees()
    {
        return new List<Employee>() {
            new Employee(){EmployeeId=1,EmpName="Sumedh"},
            new Employee(){EmployeeId=2,EmpName="Jay"},
            new Employee(){EmployeeId=3,EmpName="Mayur"},
            new Employee(){EmployeeId=4,EmpName="Rupesh"},
            new Employee(){EmployeeId=5,EmpName="Omkar"},
        };
    }
}
