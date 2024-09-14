using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
namespace Delegates
{

    public class Car
    {
        public Car(int id, string mark, string color, int year, int price)
        {
            Id = id;
            Mark = mark;
            Color = color;
            Year = year;
            Price = price;
        }
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
    //public List<Car> GetAllWhereYearGreaterThan2010(List<Car> cars)
    //{
    //    if (cars == null)
    //    {
    //        throw new ArgumentNullException("Argument cannot be null.");
    //    }
    //    List<Car> result = new List<Car>();
    //    foreach (Car car in cars)
    //    {
    //        if (car.Year > 2010)
    //        {
    //            result.Add(car);
    //        }
    //    }
    //    return result;
    //}
    //public List<Car> GetAllWherePriceGreaterThan10000(List<Car> cars)
    //{
    //    if (cars == null)
    //    {
    //        throw new ArgumentNullException("Argument cannot be null.");
    //    }
    //    List<Car> result = new List<Car>();
    //    foreach (Car car in cars)
    //    {
    //        if (car.Price > 10000)
    //        {
    //            result.Add(car);
    //        }
    //    }
    //    return result;
    //}
    //public List<Car> GetAllWhereColorIsYellow(List<Car> cars)
    //{
    //    if (cars == null)
    //    {
    //        throw new ArgumentNullException("Argument cannot be null.");
    //    }
    //    List<Car> result = new List<Car>();
    //    foreach (Car car in cars)
    //    {
    //        if (car.Color == "Yellow")
    //        {
    //            result.Add(car);
    //        }
    //    }
    //    return result;
    //}
    //public List<Car> GetAllWhereMarkIsBMW(List<Car> cars)
    //{
    //    if (cars == null)
    //    {
    //        throw new ArgumentNullException("Argument cannot be null.");
    //    }
    //    List<Car> result = new List<Car>();
    //    foreach (Car car in cars)
    //    {
    //        if (car.Mark == "BMW")
    //        {
    //            result.Add(car);
    //        }
    //    }
    //    return result;
    //}
    //public List<Car> Filter(List<Car> cars)
    //{
    //    if (cars == null)
    //    {
    //        throw new ArgumentNullException("Argument cannot be null.");
    //    }
    //    List<Car> result = new List<Car>();
    //    foreach (Car car in cars)
    //    {
    //        if (car.Mark == "BMW" && car.Color == "Yellow")
    //        {
    //            result.Add(car);
    //        }
    //    }
    //    return result;
    //}




    //    Develop an Employee Management System using C# that demonstrates
    //    the use of encapsulation, inheritance, polymorphism, abstraction, interfaces, and static classes.
    //    This system will manage employees, allowing the addition of new employees and the calculation
    //    and display of their salaries.
    //Functional Requirements
    //1.	Add New Employees
    //o   The system should allow adding new employees.
    //o There should be at least two types of employees: Full-Time and Part-Time.
    //2.	Display Employee Details
    //o   The system should display details of all employees, including their name, ID, department,
    //and monthly salary.
    //3.	Calculate Salary
    //o For full-time employees, the salary should be calculated based on an annual salary.
    //o For part-time employees, the salary should be calculated based on an hourly wage and
    //the number of hours worked.
    //4.	List All Employees
    //o   The system should list all employees with their respective details.
    //Technical Requirements
    //1.	Encapsulation
    //o   Use private fields and public properties in the Employee class.
    //2.	Inheritance
    //o   Create a base class Employee and derive classes FullTimeEmployee and PartTimeEmployee from it.
    //3.	Polymorphism
    //o   Use method overriding to display details for each type of employee.
    //4.	Abstraction
    //o   Use an abstract class Employee with abstract methods for calculating salary and displaying details.
    //5.	Interfaces
    //o   Implement an interface IPayable for salary calculation.
    //6.	Static Classes
    //o Use a static class EmployeeUtils for utility functions like adding and displaying employees.
    //Implementation Details
    //Classes and Interfaces
    //1.	IPayable Interface
    //o Method: decimal CalculateSalary()
    //2.	Abstract Class Employee
    //o   Private Fields: name, id, department
    //o   Public Properties: Name, Id, Department
    //o   Abstract Methods: decimal CalculateSalary(), void DisplayDetails()
    //3.	FullTimeEmployee Class
    //o Inherits from Employee
    //o Additional Property: AnnualSalary
    //o   Implements CalculateSalary to return the monthly salary
    //o   Implements DisplayDetails to display full-time employee details
    //4.	PartTimeEmployee Class
    //o Inherits from Employee
    //o Additional Properties: HourlyWage, HoursWorked
    //o   Implements CalculateSalary to return the salary based on hours worked
    //o Implements DisplayDetails to display part-time employee details
    //5.	Static Class EmployeeUtils
    //o   Method: void DisplayAllEmployees(List<Employee> employees)
    //o Method: void AddEmployee(List<Employee> employees, Employee employee)



    //Additional Mini Project Requirements for Interns(Without Code)
    //1. Online Store Inventory Management System
    //Objective: Develop an application to manage an online store's inventory, including adding products, updating stock, and calculating inventory value.
    //Features:
    //1.	Add new products to the inventory.
    //2.	Update the stock levels of products.
    //3.	Display product details.
    //4.	Calculate the total inventory value.
    //Concepts Covered:
    //•	Encapsulation: Use private fields and public properties in the Product class.
    //•	Inheritance: Create a base class Product and derive classes such as Electronics and Clothing.
    //•	Polymorphism: Override methods to display product details.
    //•	Abstraction: Use an abstract class Product.
    //•	Interfaces: Implement an interface IStockManagement for stock updates.
    //•	Static Classes: Create a static utility class InventoryUtils for inventory calculations and operations.
    //Classes and Interfaces:
    //1.	IStockManagement Interface:
    //o Methods for adding and updating stock.
    //2.	Abstract Class Product:
    //o Common properties like name, stock, and price.
    //o Abstract methods for displaying details.
    //o Methods for updating stock.
    //3.	Derived Classes Electronics and Clothing:
    //o Inherit from Product.
    //o Implement abstract methods for displaying details.
    //4.	Static Class InventoryUtils:
    //o Methods for displaying all products in the inventory.
    //o Methods for calculating the total inventory value.
    //________________________________________
    //2. School Management System
    //Objective: Create an application to manage students, teachers, and classes in a school.
    //Features:
    //1.	Add new students and teachers.
    //2.	Assign students to classes.
    //3.	Display details of students, teachers, and classes.
    //Concepts Covered:
    //•	Encapsulation: Use private fields and public properties in the Person class.
    //•	Inheritance: Create a base class Person and derive classes Student and Teacher.
    //•	Polymorphism: Override methods to display details.
    //•	Abstraction: Use an abstract class Person.
    //•	Interfaces: Implement an interface IAssignable for class assignments.
    //•	Static Classes: Create a static utility class SchoolUtils for school operations.
    //Classes and Interfaces:
    //1.	IAssignable Interface:
    //o Methods for assigning to classes.
    //2.	Abstract Class Person:
    //o Common properties like name and ID.
    //o Abstract methods for displaying details.
    //3.	Derived Classes Student and Teacher:
    //o Inherit from Person.
    //o Implement abstract methods for displaying details.
    //4.	Class Class:
    //o Manage class details and student assignments.
    //5.	Static Class SchoolUtils:
    //o Methods for adding students and teachers.
    //o   Methods for displaying details of students, teachers, and classes.
    //________________________________________
    //3. Hotel Booking System
    //Objective: Develop a system to manage hotel bookings, including room reservations and customer details.
    //Features:
    //1.	Add new customers.
    //2.	Make room reservations.
    //3.	Display booking details.
    //4.	Calculate total booking cost.
    //Concepts Covered:
    //•	Encapsulation: Use private fields and public properties in the Customer class.
    //•	Inheritance: Create a base class Booking and derive classes SingleRoomBooking and DoubleRoomBooking.
    //•	Polymorphism: Override methods to display booking details.
    //•	Abstraction: Use an abstract class Booking.
    //•	Interfaces: Implement an interface IBookable for booking operations.
    //•	Static Classes: Create a static utility class BookingUtils for booking calculations.
    //Classes and Interfaces:
    //1.	IBookable Interface:
    //o Methods for booking operations.
    //2.	Abstract Class Booking:
    //o Common properties like booking ID and date.
    //o Abstract methods for calculating cost and displaying details.
    //3.	Derived Classes SingleRoomBooking and DoubleRoomBooking:
    //o Inherit from Booking.
    //o Implement abstract methods for calculating cost and displaying details.
    //4.	Class Customer:
    //o Manage customer details like name and contact information.
    //5.	Static Class BookingUtils:
    //o Methods for adding bookings and calculating total booking costs.
    //________________________________________
    //4. Bank Account Management System
    //Objective: Create a system to manage bank accounts, including deposits, withdrawals, and account details.
    //Features:
    //1.	Add new accounts.
    //2.	Perform deposits and withdrawals.
    //3.	Display account details.
    //4.	Calculate account balance.
    //Concepts Covered:
    //•	Encapsulation: Use private fields and public properties in the BankAccount class.
    //•	Inheritance: Create a base class BankAccount and derive classes SavingsAccount and CheckingAccount.
    //•	Polymorphism: Override methods to display account details.
    //•	Abstraction: Use an abstract class BankAccount.
    //•	Interfaces: Implement an interface ITransaction for transactions.
    //•	Static Classes: Create a static utility class AccountUtils for account operations.
    //Classes and Interfaces:
    //1.	ITransaction Interface:
    //o Methods for deposits and withdrawals.
    //2.	Abstract Class BankAccount:
    //o Common properties like account number and balance.
    //o Abstract methods for displaying details.
    //3.	Derived Classes SavingsAccount and CheckingAccount:
    //o Inherit from BankAccount.
    //o Implement abstract methods for displaying details.
    //4.	Static Class AccountUtils:
    //o Methods for adding accounts and performing transactions.
    //________________________________________




    //5. Library Management System
    //Objective: Develop an application to manage a library's books, including adding new books, borrowing,
    //and returning.
    //Features:
    //1.	Add new books.
    //2.	Borrow and return books.
    //3.	Display book details.
    //4.	Track borrowed books.
    //Concepts Covered:
    //•	Encapsulation: Use private fields and public properties in the LibraryItem class.
    //•	Inheritance: Create a base class LibraryItem and derive classes Book and Magazine.
    //•	Polymorphism: Override methods to display item details.
    //•	Abstraction: Use an abstract class LibraryItem.
    //•	Interfaces: Implement an interface IBorrowable for borrowing operations.
    //•	Static Classes: Create a static utility class LibraryUtils for library operations.
    //Classes and Interfaces:
    //1.	IBorrowable Interface:
    //o Methods for borrowing and returning.
    //2.	Abstract Class LibraryItem:
    //o Common properties like title, author, and ID.
    //o Abstract methods for displaying details.
    //3.	Derived Classes Book and Magazine:
    //o Inherit from LibraryItem.
    //o Implement abstract methods for displaying details.
    //4.	Static Class LibraryUtils:
    //o Methods for adding and displaying library items.
    //o Methods for tracking borrowed items.



    interface IBorrowable
    {
        void Borrow(LibraryItem item);
        void Return(int id);
    }
    abstract class LibraryItem
    {
        public LibraryItem(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public abstract void DisplayDetails();
    }

    class Book : LibraryItem, IBorrowable
    {
        private bool _isBorrowed;
        public Book(int id, string title, string author) : base(id, title, author)
        {
          
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id} |Title:{Title} | Author: {Author}");
        }
        public void Borrow(LibraryItem item)
        {
            _isBorrowed = true;
        }



        public void Return(int id)
        {
            _isBorrowed = false;
        }
    }

    class Magazine : LibraryItem, IBorrowable
    {
        public bool _isBorrowed;
        public Magazine(int id, string title, string author) : base(id, title, author)
        {

        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id} |Title:{Title} | Author: {Author}");
        }
        public void Borrow(LibraryItem item)
        {
            _isBorrowed = true;
        }



        public void Return(int id)
        {
            _isBorrowed = false;
        }
    }

    static class LibraryUtils
    {
        private static List<LibraryItem> _libraryItems;
        static LibraryUtils()
        {
            _libraryItems = new List<LibraryItem>();
        }
        static void AddLibraryItem(LibraryItem item)
        {
            _libraryItems.Add(item);
        }

        static void DisplayLibraryItems()
        {
            foreach (LibraryItem item in _libraryItems)
            {
                Console.WriteLine(item.Title);
            }
        }

        static void TrackingBorrowedItems()
        {
            foreach (LibraryItem item in _libraryItems)
            {
                if (item._isBorrowed == true)
                {
                    Console.WriteLine(item.Title);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }


       




    }
}
