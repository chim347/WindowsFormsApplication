using ManagerCoffeeShop.DAO;
using ManagerCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCoffeeShop
{
    public partial class FTableManager : Form
    {
        public FTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        #region Method

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";

        }

        void LoadFoodListCategoryById(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByIdCategory(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList) {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += lstBill_Click;
                btn.Tag = table;
                switch (table.Status) {
                    case "Empty":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                floPanelTable.Controls.Add(btn);
            }
        }

        void showBill(int id)
        {
            lstBill.Items.Clear();
            List<ManagerCoffeeShop.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (ManagerCoffeeShop.DTO.Menu item in listBillInfo) {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lstBill.Items.Add(lsvItem);
                
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        #endregion




        #region Events
        private void lstBill_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).Id;
            lstBill.Tag = (sender as Button).Tag;
            showBill(tableId);
        }

        private void numFoodCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void invidualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAccountProfile fAccountProfile = new FAccountProfile();
            fAccountProfile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin f = new FAdmin();
            f.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListCategoryById(id);
        }

        private void btAddFood_Click(object sender, EventArgs e)
        {
            Table table = lstBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIdByTableID(table.Id);

            if(idBill == -1) {
                BillDAO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InserBillInfo(idBill, table.Id, 1);
            }
        }

        #endregion

    }
}
