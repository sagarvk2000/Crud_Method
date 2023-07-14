using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Method
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
    }
    public class EmployeeCRUD
    {
        private List<Employee> emp;
        public EmployeeCRUD()
        {
            emp = new List<Employee>();
        }
        public void AddEmp(Employee e)
        {
            emp.Add(e);
        }

        public void UpdateEmp(Employee e)
        {
            foreach (Employee e1 in emp)
            {
                if (e.Id ==e1.Id )
                {
                    e1.Name = e.Name;
                    e1.salary = e.salary;
                    break;
                }
            }
        }
        public void DeleteEmp(int id)
        {
            foreach (Employee e in emp)
            {
                if(e.Id==id)
                {
                    emp.Remove(e);
                    break;
                }
            }
        }
        public List<Employee> GetEmp()
        {
            return emp;
        }
    }
}
