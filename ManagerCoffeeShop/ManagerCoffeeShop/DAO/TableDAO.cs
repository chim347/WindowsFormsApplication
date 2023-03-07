using ManagerCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffeeShop.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            
            DataTable dataTable= DataProvider.Instance.ExcuteQuery("USP_GetTableList");
            foreach (DataRow row in dataTable.Rows) {
                Table table = new Table(row);
                tableList.Add(table);
            }

            return tableList;
        }


    }
}
