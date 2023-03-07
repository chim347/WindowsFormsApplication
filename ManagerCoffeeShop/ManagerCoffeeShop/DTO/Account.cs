using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffeeShop.DTO
{
    public class Account
    {
        private string userName;
        private string displayName; 
        private string password;
        private int type;

        public Account(string userName, string displayName, string password, int type)
        {
            this.userName = userName;
            this.displayName = displayName;
            this.password = password;
            this.type = type;
        }
        public Account() { }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string DisplayName
        {
            get { return this.displayName; }
            set { this.displayName = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public int Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
