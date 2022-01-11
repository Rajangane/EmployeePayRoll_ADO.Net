// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Welcome To Employee Payroll Service ********************");

using EmployeePayRoll_ADO.Net;
Console.Write("Select Number:\n1)GetAllEmployeeDetails");
int option = Convert.ToInt32(Console.ReadLine());
EmployeeModel employee = new EmployeeModel();
EmployeeRepo repo = new EmployeeRepo();

switch (option)
{
    case 1:
       repo.GetAllEmployee();
        break;
    default:
        Console.WriteLine("\nInvalid Option");
        break;
}
