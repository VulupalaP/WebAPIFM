using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIFM.Models;

namespace WebAPIFM.Controllers
{
    public class EmployeeController : ApiController
    {
        //This the method to return the employees
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            TestDBEntities testDBEntities = new TestDBEntities();
            employees = testDBEntities.Employees.ToList();
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            TestDBEntities testDBEntities = new TestDBEntities();
            Employee employee = testDBEntities.Employees.Find(1);
            return employee;
        }

        public string PostEmployee(Employee employee)
        {
            TestDBEntities testDBEntities = new TestDBEntities();
            Employee emp = new Employee();
            emp.Id = employee.Id;
            emp.Name = employee.Name;
            emp.Age = employee.Age;
            emp.Qualification = employee.Qualification;
            emp.Location = employee.Location;
            testDBEntities.Employees.Add(emp);
            testDBEntities.SaveChanges();
            return "The EMployee is created";


        }

        public string PutEmployee(Employee employee)
        {
            TestDBEntities testDBEntities = new TestDBEntities();
            Employee emp = testDBEntities.Employees.Find(employee.Id);
            emp.Id = employee.Id;
            emp.Name = employee.Name;
            emp.Age = employee.Age;
            emp.Qualification = employee.Qualification;
            emp.Location = employee.Location;
            testDBEntities.SaveChanges();
            return "The EMployee is created";

        }

        public string DeleteEmployee(int id)
        {
            TestDBEntities testDBEntities = new TestDBEntities();
            Employee emp = testDBEntities.Employees.Find(id);
            testDBEntities.Employees.Remove(emp);
            testDBEntities.SaveChanges();
            return "The EMployee is created";

        }

    }
}
