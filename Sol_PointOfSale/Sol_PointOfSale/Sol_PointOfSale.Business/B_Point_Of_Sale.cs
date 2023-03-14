using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PointOfSale.Entities;
using Sol_PointOfSale.Data;

namespace Sol_PointOfSale.Business
{
    public class B_Point_Of_Sale
    {
        public static DataTable List_ps(string cText)
        {
            D_Point_Of_Sale Data = new D_Point_Of_Sale();

            return Data.List_ps(cText);
        }

        public static string Save_ps(int nOption, E_Point_Of_Sale oPropertie) {

            D_Point_Of_Sale Data = new D_Point_Of_Sale();
            return Data.Save_ps(nOption, oPropertie);
        }

        public static string Delete_ps(int nCodigo) {
            D_Point_Of_Sale Data = new D_Point_Of_Sale();
            return Data.Delete_ps(nCodigo);
        }
    }
}
