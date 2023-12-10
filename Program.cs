using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_and_Skip_Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            CompanyList companyList = new CompanyList();
            IEnumerable<Company> take = companyList.Take();
            companyList.Print(take);

            IEnumerable<Company> skip = companyList.Skip();
            companyList.Print(skip);
        }
    }
}
