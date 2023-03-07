using ManagerCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffeeShop.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        } 
        public FoodDAO() { }
    
        public List<Food> GetFoodByIdCategory(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from dbo.Food where idCategory = " + id; 

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows) {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
    }
}
