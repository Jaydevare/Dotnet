using System.Xml.Linq;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() {Name = "jay", City="Kalyan", PhoneNo=9619575472,State="Maharshtra", EmpId = 1, Department = "it" };
            Employee emp1 = new Employee() {Name = "Jyotiee", City="Titwala", PhoneNo=9619575472,State="Maharshtra", EmpId = 2, Department = "devops" };
            ICommonRepository1<Employee> EmpCRUD = new CommonRepsitory<Employee>();
            EmpCRUD.Insert(emp);
            EmpCRUD.Insert(emp1);

            foreach (var employee in EmpCRUD.GetAll())
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Name = {employee.Name} Lives in {employee.City} {employee.State} Phone No is {employee.PhoneNo} having Employee ID {employee.EmpId} and Department {employee.Department}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
            Employee em = EmpCRUD.GetDetails(0);
            Console.WriteLine($"{em.Name}, {em.City}, {em.State}, {em.PhoneNo}, {em.EmpId}, {em.Department}");
            Employee em1 = EmpCRUD.GetDetails(01);
            Console.WriteLine($"{em1.Name}, {em1.City}, {em1.State}, {em1.PhoneNo}, {em1.EmpId}, {em1.Department}");
            //Console.WriteLine(EmpCRUD.GetDetails(0));
            EmpCRUD.Delete(em);
            foreach (var employee in EmpCRUD.GetAll())
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Name = {employee.Name} Lives in {employee.City} {employee.State} Phone No is {employee.PhoneNo} having Employee ID {employee.EmpId} and Department {employee.Department}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }



            Supplier sup = new Supplier() { Name = "jay", City = "Kalyan", PhoneNo = 9619575472, State = "Maharshtra", SupplierID = 101, SupplierOf = "Sugar" };
            Supplier sup1 = new Supplier() { Name = "Jyotiee", City = "Titwala", PhoneNo = 9619575472, State = "Maharshtra", SupplierID = 102, SupplierOf = "NailPolish" };
            ICommonRepository1<Supplier> SupCRUD = new CommonRepsitory<Supplier>();
            SupCRUD.Insert(sup);
            SupCRUD.Insert(sup1);

            foreach (var supplier in SupCRUD.GetAll())
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Name = {supplier.Name} Lives in {supplier.City} {supplier.State} Phone No is {supplier.PhoneNo} having supplier ID {supplier.SupplierID} and Items {supplier.SupplierOf}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
            Supplier sp = SupCRUD.GetDetails(0);
            Console.WriteLine($"{sp.Name}, {sp.City}, {sp.State}, {sp.PhoneNo}, {sp.SupplierID}, {sp.SupplierOf}");
            Supplier sp1 = SupCRUD.GetDetails(01);
            Console.WriteLine($"{sp1.Name}, {sp1.City}, {sp1.State}, {sp1.PhoneNo}, {sp1.SupplierID}, {sp1.SupplierOf}");
            SupCRUD.Delete(sp);
            foreach (var supplier in SupCRUD.GetAll())
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Name = {supplier.Name} Lives in {supplier.City} {supplier.State} Phone No is {supplier.PhoneNo} having supplier ID {supplier.SupplierID} and Items {supplier.SupplierOf}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }

            Shipper ship = new Shipper() { Name = "jay", City = "Kalyan", PhoneNo = 9619575472, State = "Maharshtra", ShiperID = 101, ModeOfShipping = "Truck" };
            Shipper ship1 = new Shipper() { Name = "Jyotiee", City = "Titwala", PhoneNo = 9619575472, State = "Maharshtra", ShiperID = 102, ModeOfShipping = "AirLines" };
            ICommonRepository1<Shipper> ShipCRUD = new CommonRepsitory<Shipper>();
            ShipCRUD.Insert(ship);
            ShipCRUD.Insert(ship1);

            foreach (var shipper in ShipCRUD.GetAll())
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Name = {shipper.Name} Lives in {shipper.City} {shipper.State} Phone No is {shipper.PhoneNo} having shipper ID {shipper.ShiperID} and Mode Of Transport {shipper.ModeOfShipping}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
            Shipper sh = ShipCRUD.GetDetails(0);
            Console.WriteLine($"{sh.Name}, {sh.City}, {sh.State}, {sh.PhoneNo}, {sh.ShiperID}, {sh.ModeOfShipping}");
            Shipper sh1 = ShipCRUD.GetDetails(01);
            Console.WriteLine($"{sh1.Name}, {sh1.City}, {sh1.State}, {sh1.PhoneNo}, {sh1.ShiperID}, {sh1.ModeOfShipping}");
            ShipCRUD.Delete(sh1);
            foreach (var shipper in ShipCRUD.GetAll())
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Name = {shipper.Name} Lives in {shipper.City} {shipper.State} Phone No is {shipper.PhoneNo} having shipper ID {shipper.ShiperID} and Mode Of Transport {shipper.ModeOfShipping}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }

            Console.Read();
        }
    }
}
