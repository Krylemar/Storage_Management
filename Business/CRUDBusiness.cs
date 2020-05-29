using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace Business
{
    class CRUDBusiness
    {
        //public Employee GetEmployee(int id) 
        //{
        //    using (var staffContext = new Storage_ManagementContext()) 
        //    {
        //        foreach (var employee in staffContext.Staff)
        //        {
        //            if (employee.Id.Equals(id))
        //            {
        //                return employee;
        //            }
        //            return null;
        //        }

        //    }
        //}
        //Ако върне тру значи служителя е премахнат успешно
        public bool DeleteEmployee(string username) 
        {
            using (var staffContext = new Storage_ManagementContext())
            {
                foreach (var employee in staffContext.Staff)
                {
                    if (employee.Username.Equals(username))
                    {
                        staffContext.Staff.Remove(employee);
                        return true;
                    }
                    
                }
                return false;
            }
        }
        //Ако върне тру значи служителя е премахнат успешно
        public bool DeleteEmployee(int id)
        {
            using (var staffContext = new Storage_ManagementContext())
            {
                foreach (var employee in staffContext.Staff)
                {
                    if (employee.Id.Equals(id))
                    {
                        staffContext.Staff.Remove(employee);
                        return true;
                    }

                }
                return false;
            }
        }
        
        //Ако върне тру значи е създадено ново депо, ако върне фалс значи такова депо съществува
        public bool CreateNewStorage(string name) 
        {
            using (var depotContext = new Storage_ManagementContext()) 
            {
                foreach (var depot in depotContext.Depots)
                {
                    if (depot.Name.Equals(name))
                    {
                        return false;
                    }
                }
                depotContext.Depots.Add(new Depot(name));
                return true;
            }
        }

        public bool DeleteDepot(int id) 
        {
            using (var depotContext = new Storage_ManagementContext())
            {
                foreach (var depot in depotContext.Depots)
                {
                    if (depot.Id.Equals(id))
                    {
                        depotContext.Depots.Remove(depot);
                        return true;
                    }
                }                
                return false;
            }
        }

        public bool DeleteDepot(string Name) 
        {
            using (var depotContext = new Storage_ManagementContext())
            {
                foreach (var depot in depotContext.Depots)
                {
                    if (depot.Name.Equals(Name))
                    {
                        depotContext.Depots.Remove(depot);
                        return true;
                    }
                }
                return false;
            }
        }

        //За гетовете ако искаш да върне bool махаш коментарите от тялото и сменяш Depot със bool
        public Depot GetDepot(int id) 
        {
            using (var depotContext = new Storage_ManagementContext())
            {
                foreach (var depot in depotContext.Depots)
                {
                    if (depot.Id.Equals(id))
                    {
                        return depot;
                        //return true;
                    }
                }
                return null;
                //return false;
            }
        }

        public Depot GetDepot(string Name) 
        {
            using (var depotContext = new Storage_ManagementContext())
            {
                foreach (var depot in depotContext.Depots)
                {
                    if (depot.Name.Equals(Name))
                    {                       
                        return depot;
                        //return true;
                    }
                }
                return null;
                //return false;
            }
        }
    }
}
