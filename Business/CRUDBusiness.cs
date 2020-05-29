using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

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
            using (var staffContext = new storage_managementEntities())
            {
                foreach (var employee in staffContext.staffs)
                {
                    if (employee.username.Equals(username))
                    {
                        staffContext.staffs.Remove(employee);
                        return true;
                    }
                    
                }
                return false;
            }
        }
        //Ако върне тру значи служителя е премахнат успешно
        public bool DeleteEmployee(int id)
        {
            using (var staffContext = new storage_managementEntities())
            {
                foreach (var employee in staffContext.staffs)
                {
                    if (employee.id_staff.Equals(id))
                    {
                        staffContext.staffs.Remove(employee);
                        return true;
                    }

                }
                return false;
            }
        }
        
        //Ако върне тру значи е създадено ново депо, ако върне фалс значи такова депо съществува
        public bool CreateNewStorage(string name) 
        {
            using (var depotContext = new storage_managementEntities()) 
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.name.Equals(name))
                    {
                        return false;
                    }
                }
                depotContext.storages.Add(new storage(name));
                return true;
            }
        }

        public bool DeleteDepot(int id) 
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.id_storage.Equals(id))
                    {
                        depotContext.storages.Remove(depot);
                        return true;
                    }
                }                
                return false;
            }
        }

        public bool DeleteDepot(string Name) 
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.name.Equals(Name))
                    {
                        depotContext.storages.Remove(depot);
                        return true;
                    }
                }
                return false;
            }
        }

        //За гетовете ако искаш да върне bool махаш коментарите от тялото и сменяш Depot със bool
        public storage GetDepot(int id) 
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.id_storage.Equals(id))
                    {
                        return depot;
                        //return true;
                    }
                }
                return null;
                //return false;
            }
        }

        public storage GetDepot(string Name) 
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.name.Equals(Name))
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
