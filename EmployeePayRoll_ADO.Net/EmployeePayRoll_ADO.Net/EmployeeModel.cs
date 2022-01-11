using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll_ADO.Net
{
    //Encapsulation
    public class EmployeeModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public double BasicPay { get; set; }
        public DateTime StartDate { get; set; }
        public char Gender { get; set; }
        public string phone_no { get; set; }
        public string Address { get; set; }
        public string dept { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double NetPay { get; set; }
    }
}
