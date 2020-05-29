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
        

        //Add desc...
        public bool Login(string username, string password)
        {
            using (var staffContext = new Storage_ManagerContext())
            {foreach(var employee in staffContext.Staff)
               {
                 if(employee.Username.Equals(username))
                 {
                   if(employee.Password.Equals(password))
                   {
                     return true;
                   }
                   else return false;
                 }
                  else return false;
               } 
            }
            return false;
        }

        

        //Add desc...
        public bool Register(string first_name, string last_name, string email, string username, string password, int storage_id)
        {
            using (var staffContext = new Storage_ManagementContext())
            {
                Employee emp = new Employee(first_name,last_name,email,username,password,storage_id);
                foreach(var employee in staffContext.Staff)
                {
                    if (employee.Email.Equals(email))
                    {
                        return false;
                    }
                    else if (employee.Username.Equals(username))
                    {
                        return false;
                    }
                    else 
                    { 
                        return true; 
                    }
                    
                }

                return false;
            }

        }
        public void Greeting() { }
        public void EmailIncorrectHandler() { }
        public void UsernameIncorrectHandler() { }

    }
}
