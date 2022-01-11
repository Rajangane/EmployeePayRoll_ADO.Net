// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Welcome To Employee Payroll Service ********************");

using EmployeePayRoll_ADO.Net;
Console.Write("Select Number:\n1)GetAllEmployeeDetails\n2)AddEmployeeDetails");
int option = Convert.ToInt32(Console.ReadLine());
EmployeeModel employee = new EmployeeModel();
EmployeeRepo repo = new EmployeeRepo();

switch (option)
{
    case 1:
        repo.GetAllEmployee();
        break;
    case 2:
        employee.EmployeeName = "Ruhi";
        employee.PhoneNumber = "6363123485";
        employee.Address = "Goa";
        employee.Department = "IT";
        employee.Gender = 'F';
        employee.BasicPay = 10.000000;
        employee.Deduction = 11.20;
        employee.TaxablePay = 2000.525;
        employee.Tax = 200.000;
        employee.NetPay = 56.0000;
        employee.City = "Goa";
        employee.Country = "India";
        repo.AddEmployee(employee);

        break;
    default:
        Console.WriteLine("\nInvalid Option");
        break;
}