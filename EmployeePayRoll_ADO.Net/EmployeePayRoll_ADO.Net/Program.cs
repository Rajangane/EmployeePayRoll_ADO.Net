// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Welcome To Employee Payroll Service ********************");

using EmployeePayRoll_ADO.Net;
Console.Write("Select Number:\n1)GetAllEmployeeDetails");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        new EmployeeRepo().GetAllEmployee();
        break;
    default:
        Console.WriteLine("\nInvalid Option");
        break;
}
