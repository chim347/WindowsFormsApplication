using ManagerCoffeeShop.DAO;
using ManagerCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        #region Method
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
            foreach (ManagerCoffeeShop.DTO.Menu item in listBillInfo) {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                lstBill.Items.Add(lsvItem);
                
            }
        }
        #endregion



        #region Events
        private void lstBill_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).Id;
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

        #endregion
    }
}
