using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSv4
{
   interface ICRUD
    {
        void AddItem(Inventory item);
        void DeleteItem(Inventory item);
        ICollection<Inventory> GetAll();
        Inventory FindStockNumber(int id);
        void UpdateItem(int id, Inventory item);
    }

    class CRUD : ICRUD
    { 
    IMSv3Entities entities;
        public CRUD()
        {
            entities = new IMSv3Entities();
        }

            public void AddItem(Inventory item)
        {
            entities.Inventories.Add(item);
            entities.SaveChanges();
        }

        public void DeleteItem(Inventory item)
        {
            entities.Inventories.Remove(item);
            entities.SaveChanges();
        }

        public Inventory FindStockNumber(int id)
        {
            return entities.Inventories.Find(id);
        }

        public ICollection<Inventory> GetAll()
        {
            return entities.Inventories.ToList();
        }

        public void UpdateItem(int id, Inventory item)
        {
            var itemtoupdate = entities.Inventories.Find(id);
            itemtoupdate.Stock_Number = item.Stock_Number;
            itemtoupdate.Item_Name = item.Item_Name;
            itemtoupdate.Quantity = item.Quantity;
            itemtoupdate.Description = item.Description;
            itemtoupdate.Unit_Price = item.Unit_Price;
            itemtoupdate.Department = item.Department;            
            entities.SaveChanges();
        }
    }
}

