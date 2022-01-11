using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll_ADO.Net
{
    public class EmployeeRepo
    {
        public static string connectionString = @"Data source=(localdb)\MSSQLLocalDB; Initial Catalog=PayRollService; Integrated Security=True;";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel();
                using (this.connection)
                {
                    string query = @"Select id,name,BasicPay,Start_Date,Gender,phone_no,Address,dept,Deduction,TaxablePay,NetPay from Employee_PayRoll";
                    //define sql command object
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    //check if there are records
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModel.id = dr.GetInt32(0);
                            employeeModel.name = dr.GetString(1);
                            employeeModel.BasicPay = dr.GetDouble(2);
                            employeeModel.StartDate = dr.GetDateTime(3);
                            employeeModel.Gender = Convert.ToChar(dr.GetString(4));
                            employeeModel.phone_no = dr.GetString(5);
                            employeeModel.Address = dr.GetString(6);
                            employeeModel.dept = dr.GetString(7);
                            employeeModel.Deduction = dr.GetDouble(8);
                            employeeModel.TaxablePay = dr.GetDouble(8);
                            employeeModel.NetPay = dr.GetDouble(10);

                            //display retrived record
                            System.Console.WriteLine(employeeModel.name + " " + employeeModel.BasicPay + " " + employeeModel.StartDate + " " + employeeModel.Gender + " " + employeeModel.phone_no + " " + employeeModel.Address + " " + employeeModel.dept + " " + employeeModel.Deduction + " " + employeeModel.TaxablePay + " " + " " + employeeModel.NetPay);
                            System.Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                    //close data reader
                    dr.Close();

                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}