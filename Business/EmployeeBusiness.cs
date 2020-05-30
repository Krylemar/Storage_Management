using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    class EmployeeBusiness
    {
        public staff GetEmployee(int id)
        {
            using (var staffContext = new storage_managementEntities())
            {
                foreach (var employee in staffContext.staffs)
                {
                    if (employee.id_staff.Equals(id))
                    {
                        return employee;
                    }
                }
                staffContext.SaveChanges();
                return null;
            }
        }

        //Ако върне тру значи служителя е премахнат успешно
        public bool DeleteEmployee(string param)
        {
            using (var staffContext = new storage_managementEntities())
            {
                int id;
                if (int.TryParse(param, out id) == true)
                {
                    if (DeleteEmployeeById(id) == true)
                    {
                        return true;
                    }
                    else
                        return false;

                }
                else
                {
                    if (DeleteEmployeeByName(param) == true)
                        return true;
                    else
                        return false;

                }
            }
        }
        //Вътрешни методи
        private bool DeleteEmployeeByName(string username)
        {
            using (var staffContext = new storage_managementEntities())
            {
                foreach (var employee in staffContext.staffs)
                {
                    if (employee.username.Equals(username))
                    {
                        staffContext.staffs.Remove(employee);
                        staffContext.SaveChanges();
                        return true;
                    }

                }
                return false;
            }
        }

        private bool DeleteEmployeeById(int id)
        {
            using (var staffContext = new storage_managementEntities())
            {
                foreach (var employee in staffContext.staffs)
                {
                    if (employee.id_staff.Equals(id))
                    {
                        staffContext.staffs.Remove(employee);
                        staffContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
        }

    }
}
