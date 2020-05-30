using System;
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
        

        //
        public bool Login(string username, string password)
        {
            using (var staffContext = new storage_managementEntities())
            {
                foreach(var employee in staffContext.staffs)
                {
                 if(employee.username.Equals(username))
                 {
                   if(employee.password.Equals(password))
                   {
                     return true;
                   }                 
                 }
                }
                staffContext.SaveChanges();
            }            
            return false;
        }

        

        //Add desc...
        public bool Register(string first_name, string last_name, string email, string username, string password, int storage_id)
        {
            using (var staffContext = new storage_managementEntities())
            {
                staff emp = new staff(first_name,last_name,email,username,password,storage_id);
                foreach(var employee in staffContext.staffs)
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
        //To be implemented
        public void Greeting() { }
        

    }
}
