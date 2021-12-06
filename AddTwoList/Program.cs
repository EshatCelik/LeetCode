using System;
using System.Collections.Generic;
using System.Linq;

namespace AddTwoList
{
    class Program
    {
        //* Definition for singly-linked list.
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }

            List<Employee> list;
            public Employee()
            {

            }
            public List<Employee> GetAll()
            {
                list = new List<Employee>() {

                    new Employee{Id=1,Name="Eshat",LastName="Çelikk"},
                    new Employee{Id=2,Name="ali",LastName="Çelikk"},
                    new Employee{Id=3,Name="Ahhat",LastName="Çelikk"},
                    new Employee{Id=4,Name="Serkan",LastName="Çelikk"},
               };
                return list.ToList();
            }

        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            //List<string> list = new List<string>() { "elma", "armut", "portakal", "kivi" };
            DBContext db = new DBContext();
            

            IQueryable<Employee> list2 = db.Employees;
            IQueryable<Employee> listQ = list2;
            IEnumerable<Employee> list = emp.GetAll().Where(x => x.Id > 2).ToList();

        }


    }
}
