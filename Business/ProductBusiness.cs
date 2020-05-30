using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class ProductBusiness
    {
        public bool CreateProduct(string name, string brand, double price, int quantity, bool isAvailable, int storageId)
        {
            using (var productContext = new storage_managementEntities())
            {
                foreach (var product in productContext.items)
                {
                    if (product.name.Equals(name))
                    {
                        return false;
                    }
                }
                item item = new item(name, brand, price, quantity, isAvailable, storageId);
                productContext.items.Add(item);
                productContext.SaveChanges();
                return true;
            }
        }

        public bool DeleteProduct(string name)
        {
            int id;
            if (int.TryParse(name, out id))
            {
                if (DeleteProductById(id))
                    return true;
                else
                    return false;
            }
            else
            {
                if (DeleteProductByName(name))
                    return true;
                else
                    return false;
            }
        }
        private bool DeleteProductById(int id)
        {
            using (var productContext = new storage_managementEntities())
            {
                foreach (var product in productContext.items)
                {
                    if (product.id_item.Equals(id))
                    {
                        productContext.items.Remove(product);
                        productContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
        }
        private bool DeleteProductByName(string name)
        {
            using (var productContext = new storage_managementEntities())
            {
                foreach (var product in productContext.items)
                {
                    if (product.name.Equals(name))
                    {
                        productContext.items.Remove(product);
                        productContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
        }

        public item GetProduct(string param)
        {
            int id;
            if (int.TryParse(param, out id))
            {
                return GetProductById(id);
            }
            else
            {
                return GetProductByName(param);
            }
        }
        private item GetProductById(int id)
        {
            using (var productContext = new storage_managementEntities())
            {
                foreach (var product in productContext.items)
                {
                    if (product.id_item.Equals(id))
                    {
                        return product;
                    }
                }
                return null;
            }
        }
        private item GetProductByName(string name)
        {
            using (var productContext = new storage_managementEntities())
            {
                foreach (var product in productContext.items)
                {
                    if (product.name.Equals(name))
                    {
                        return product;
                    }
                }
                return null;
            }
        }
    }
}
