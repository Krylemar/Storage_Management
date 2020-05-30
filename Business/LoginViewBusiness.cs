using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class LoginViewBusiness
    {
        

        //Catch ArgumentNullException а случай, където може да има празно поле
        public bool Login(string username, string password)
        {
            if (username.Equals("") || password.Equals(""))
            {throw new ArgumentNullException();}
            else
            {
                using (var staffContext = new storage_managementEntities())
                {
                    foreach (var employee in staffContext.staffs)
                    {
                        if (employee.username.Equals(username))
                        {
                            if (employee.password.Equals(password))
                            {
                                return true;
                            }
                        }
                    }
                    staffContext.SaveChanges();
                }
                return false;
            }
        }

        

        //Catch ArgumentNullException and FormatException за случай където може да има празни полета
        public bool Register(string first_name, string last_name, string email, string username, string password, int storage_id)
        {
            if (first_name.Equals("") || last_name.Equals("") || email.Equals("") || username.Equals("") || password.Equals("") || storage_id.Equals(0))
            {
                throw new ArgumentNullException();
            }
            else
            {
                using (var staffContext = new storage_managementEntities())
                {
                    staff emp = new staff(staffContext.staffs.Count(),first_name, last_name, email, username, password, storage_id);
                    foreach (var employee in staffContext.staffs)
                    {
                        if (employee.email.Equals(email))
                        {
                            return false;
                        }
                        else if (employee.username.Equals(username))
                        {
                            return false;
                        }
                    }
                    
                    staffContext.staffs.Add(emp);
                    staffContext.SaveChanges();
                    return true;
                }
            }
        }
        
    }
}
