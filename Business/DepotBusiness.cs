using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    class DepotBusiness
    {
        //Ако върне тру значи е създадено ново депо, ако върне фалс значи такова депо съществува
        public bool CreateDepot(string name)
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
                depotContext.SaveChanges();
                return true;
            }
        }

        public bool DeleteDepot(string param)
        {
            int id;
            if (int.TryParse(param, out id) == true)
            {
                if (DeleteDepotById(id) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                if (DeleteDepotByName(param) == true)
                    return true;
                else
                    return false;
            }
        }

        private bool DeleteDepotById(int id)
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.id_storage.Equals(id))
                    {
                        depotContext.storages.Remove(depot);
                        depotContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
        }

        private bool DeleteDepotByName(string Name)
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.name.Equals(Name))
                    {
                        depotContext.storages.Remove(depot);
                        depotContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
        }

        public storage GetDepot(string param)
        {
            int id;
            if (int.TryParse(param, out id) == true)
            {
                return GetDepotById(id);
            }
            else
            {
                return GetDepotByName(param);
            }
        }
        private storage GetDepotById(int id)
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.id_storage.Equals(id))
                    {
                        return depot;
                    }
                }
                return null;
            }
        }

        private storage GetDepotByName(string Name)
        {
            using (var depotContext = new storage_managementEntities())
            {
                foreach (var depot in depotContext.storages)
                {
                    if (depot.name.Equals(Name))
                    {
                        return depot;
                    }
                }
                return null;
            }
        }
    }
}
