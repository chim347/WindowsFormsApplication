using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffeeShop.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "") {
                this.dateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            this.Status = (int)row["status"];
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
