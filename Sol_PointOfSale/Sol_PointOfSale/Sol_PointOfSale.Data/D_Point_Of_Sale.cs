using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sol_PointOfSale.Entities;
using System.Data;

namespace Sol_PointOfSale.Data
{
    public class D_Point_Of_Sale
    {
        public DataTable List_ps(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Command = new SqlCommand("USP_List_ps", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@cText", SqlDbType.VarChar).Value= cText;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {   
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();               
            }
        }

        public string Save_ps(int nOption, E_Point_Of_Sale oPropertie)
        {
            string Answer = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Command = new SqlCommand("UPS_Save_ps", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@nOption", SqlDbType.Int).Value = nOption;
                Command.Parameters.Add("@nCode", SqlDbType.Int).Value = oPropertie.code_ps;
                Command.Parameters.Add("@nDescription", SqlDbType.VarChar).Value = oPropertie.description_ps;
                SqlCon.Open();
                Answer = Command.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registo";
            }
            catch (Exception ex)
            {
                Answer = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Answer;
        }
        public string Delete_ps(int nCode)
        {
            string Answer = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Command = new SqlCommand("USP_Delete_ps", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@nCode", SqlDbType.Int).Value= nCode;
                SqlCon.Open();
                Answer = Command.ExecuteNonQuery()>=1 ? "OK" : "No se pudo eliminar el registo";
            }
            catch (Exception ex)
            {

                Answer = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Answer;
        }
    }
}
