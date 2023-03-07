using ManagerCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffeeShop.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance 
        { 
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        /// <summary>
        /// Success: bill ID
        /// Failed: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIdByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from dbo.Bill where idTable = " + id + " and status = 1");
            if(data.Rows.Count > 0) {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIdBill()
        {
            try {
                return (int)DataProvider.Instance.ExcuteScalar("");
            }
            catch {
                return 1;
            }
            
        }
    }
}
