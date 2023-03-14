using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sol_PointOfSale.Data
{
    public class Connection
    {
        private string Base;
        private string Server;
        public static Connection Con = null;

        private Connection()
        {
            this.Base = "BD_PointOfSale";
            this.Server = "XI028\\MSSQLSERVER01";
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection Text = new SqlConnection();
            try
            {
                Text.ConnectionString = "Server=" + this.Server +
                                          "; Database=" + this.Base;  
            }
            catch (Exception ex)
            {
                Text = null;
                throw ex;
            }
            return Text;
        }

        public static Connection GetInstance()
        {
            if (Con == null)
            {
                Con = new Connection();
            }
            return Con;
        }



    }
}
