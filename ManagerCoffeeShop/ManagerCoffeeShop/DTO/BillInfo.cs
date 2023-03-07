using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffeeShop.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int idBill, int idFood, int count)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.IdFood = idFood;
            this.Count = count;
        }
        public BillInfo(DataRow row) 
        {
            this.Id = (int)row["id"];
            this.IdBill = (int)row["idBill"];
            this.IdFood = (int)row["idFood"];
            this.Count = (int)row["count"];
        }
        
        private int idFood;
        public int IdFood
        {
            get { return idFood; }
            set { idFood = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int idBill;
        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }
        private int id;
        public int Id 
        {
            get { return id; }
            set { id = value; } 
        }
    }
}
