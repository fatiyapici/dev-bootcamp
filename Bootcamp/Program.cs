// See https://aka.ms/new-console-template for more information
using Bootcamp.Business;
using Bootcamp.DataAccess.Concretes;
using Bootcamp.Entities;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

string message = "Loans";
Console.WriteLine(message);

int term = 12;
double amount = 100000.0;

// Variables --> camelCase
bool isAuthenticated = false;

// Conditions
if (isAuthenticated)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Log in.");
}

// Loops
string loan1 = "Loan 1";
string loan2 = "Loan 2";
string loan3 = "Loan 3";

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3" };
string[] loans2 = new string[3];
loans2[0] = "Kredi 1";

//    _start_     _condition_  _increment_
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

// OOP
CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price + " $ ");
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.CustomerNumber = 111;
customer1.NationalIdentityNumber = "11111111111";
customer1.FirstName = "Ali";
customer1.LastName = "Veli";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.CustomerNumber = 222;
customer2.NationalIdentityNumber = "22222222222";
customer2.FirstName = "Ahmet";
customer2.LastName = "Mehmet";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.CustomerNumber = 333;
customer3.TaxNumber = "33333333333";
customer3.Name = "Kodlamaio";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.CustomerNumber = 444;
customer4.TaxNumber = "44444444444";
customer4.Name = "Oiamaldok";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}