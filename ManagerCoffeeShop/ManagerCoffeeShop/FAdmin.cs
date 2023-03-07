using ManagerCoffeeShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCoffeeShop
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }


        // de test thoi
        /*void LoadAccountList()
        {
            string query = "exec dbo.USP_GetAccountByUsername1 @Username";

            dtgvAccount.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] {"thanh"});
        }*/
    }
}
