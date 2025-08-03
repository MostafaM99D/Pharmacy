using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsOrdersData
    {
        public static DataTable GetAllOrdersData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Orders ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error", ex);

                        //return null;
                    }
                }
            }
            return dt;
        }

        public static bool GetOrderByID(int OrderID, ref int CustomerID, ref int UserID, ref DateTime OrderDate, ref decimal TotalAmount, ref decimal PaidAmount, ref decimal DueAmount, ref int PaymentMethodID)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Orders where OrderID=@OrderID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                CustomerID = (int)reader["CustomerID"];
                                UserID = (int)reader["UserID"];
                                OrderDate = (DateTime)reader["OrderDate"];
                                TotalAmount = (decimal)reader["TotalAmount"];
                                PaidAmount = (decimal)reader["PaidAmount"];
                                DueAmount = reader.IsDBNull(reader.GetOrdinal("DueAmount")) ? -999 : (decimal)reader["DueAmount"];
                                PaymentMethodID = (int)reader["PaymentMethodID"];



                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);
                        //Is_Found=false;

                    }



                    return Is_Found;
                }


            }


        }


        public static int AddNewOrder(int CustomerID, int UserID, DateTime OrderDate, decimal TotalAmount, decimal PaidAmount, decimal? DueAmount, int PaymentMethodID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into Orders([CustomerID], [UserID], [OrderDate], [TotalAmount], [PaidAmount], [DueAmount], [PaymentMethodID]) values (@CustomerID, @UserID, @OrderDate, @TotalAmount, @PaidAmount, @DueAmount, @PaymentMethodID);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);

                    if (DueAmount != null)
                        cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                    else
                        cmd.Parameters.AddWithValue("@DueAmount", DBNull.Value); cmd.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

                    try
                    {

                        conn.Open();
                        object obj = cmd.ExecuteScalar();

                        if (obj != null && int.TryParse(Convert.ToString(obj), out int r))
                            rows_affected = r;

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Erro.", ex);

                        //rows_affected=-1;

                    }


                }


            }


            return rows_affected;
        }


        public static bool UpdateOrder(int OrderID, int CustomerID, int UserID, DateTime OrderDate, decimal TotalAmount, decimal PaidAmount, decimal? DueAmount, int PaymentMethodID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update Orders set CustomerID = @CustomerID, UserID = @UserID, OrderDate = @OrderDate, TotalAmount = @TotalAmount, PaidAmount = @PaidAmount, DueAmount = @DueAmount, PaymentMethodID = @PaymentMethodID where OrderID=@OrderID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);

                    if (DueAmount != null)
                        cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                    else
                        cmd.Parameters.AddWithValue("@DueAmount", DBNull.Value); cmd.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

                    try
                    {

                        conn.Open();
                        rows_affected = cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);

                        //rows_affected=-1;

                    }


                }


            }


            return rows_affected != 0;
        }


        public static bool DeleteOrder(int OrderID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from Orders where OrderID=@OrderID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    try
                    {

                        conn.Open();
                        rows_affected = cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);
                        //rows_affected=-1;

                    }


                }


            }


            return rows_affected != 0;
        }


        public static bool IsExist(int OrderID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from Orders where OrderID=@OrderID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    try
                    {

                        conn.Open();
                        object obj = cmd.ExecuteScalar();
                        if (obj != null)
                            IsFound = true;

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);

                        //IsFound=false;

                    }


                }


            }


            return IsFound;
        }




    }


}
