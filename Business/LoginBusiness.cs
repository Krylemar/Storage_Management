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
        //private Storage_ManagementContext staffContext;

        //Add desc...
        public bool Login(string username, string password)
        {
            using (var staffContext = new Storage_ManagementContext())
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
        public void Register(string first_name, string last_name, string email, string username, string password, int storage_id)
        {
            //using (staffContext = new staffContext)
            {
                //Employee emp = new Employee(first_name,last_name,email,username,password,storage_id);
                //foreach(var employee in staffContext)
                //{
                //  if(employee.email.Equals(o =>o.email))
                {
                    
                }
                //}
                //staffContext.Add(emp);

            }

        }

    }
}
