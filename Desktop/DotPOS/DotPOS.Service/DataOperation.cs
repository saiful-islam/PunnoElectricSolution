using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace DotPOS.Service
{
    public class DataOperation
    {
        SqlConnection sqlConn;
        public DataOperation()
        {
                string connStr = File.ReadAllText("connection.txt") +
                                    "Password=s01917282835;";
                sqlConn = new SqlConnection(connStr);
        }
        public DataTable GetDataTable(string _query)
        {
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(_query, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                sqlConn.Close();
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public DataSet GetDataSet(string _query)
        {
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(_query, sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            sqlConn.Close();
            return ds;
        }
        public string ExecuteNonQuery(string _query)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }
                SqlCommand cmd = new SqlCommand(_query, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string ExecuteOrderDetails(string customerName, string address, string mobile, string total, string discount, DataTable items , bool isWholesale, string paymentStatus, string paymentMethod, string card, string payment, DateTime ExpectedDuePaymentDate, string OrderId, int customerId)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }
                SqlCommand cmd = new SqlCommand("desktop.InsertOrderDetails", sqlConn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@CustomerAddress", address);
                cmd.Parameters.AddWithValue("@Mobile", mobile);
                cmd.Parameters.AddWithValue("@OrderTotal", total);
                cmd.Parameters.AddWithValue("@Discount", discount==""? "0.00":discount);
                cmd.Parameters.AddWithValue("@isWholeSale", isWholesale);
                cmd.Parameters.AddWithValue("@Items", items).SqlDbType = SqlDbType.Structured;
                cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus);
                cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@CardNumber", card);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@cash", payment == "" ? "0.00" : payment);
                if (OrderId != string.Empty)
                {
                    cmd.Parameters.AddWithValue("@OrderId", OrderId);
                }
                SqlParameter newOrderId = new SqlParameter();
                newOrderId.ParameterName = "@newOrderId";
                newOrderId.DbType = DbType.Int32;
                newOrderId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newOrderId);

                if (paymentStatus == "Due")
                {
                    cmd.Parameters.AddWithValue("@ExpectedDuePaymentDate", ExpectedDuePaymentDate);
                }
                string orderId = "";
                if(cmd.ExecuteNonQuery()>0)
                {
                    orderId = cmd.Parameters["@newOrderId"].Value.ToString();
                }
                sqlConn.Close();
                return "1-"+orderId;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
