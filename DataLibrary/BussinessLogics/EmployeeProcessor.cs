using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BussinessLogics
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName
            };

            string sql = @"INSERT into dbo.Employee (EmployeeId, FirstName, LastName)
                           values (@employeeId, @firstName, @lastName);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, FirstName, LastName
                            FROM dbo.Employee";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);

                
        }
    }
}
