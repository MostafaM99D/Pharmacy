using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsOrderDetailsData
    {
        public static DataTable GetAllOrderDetailsData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM OrderDetails ";
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

        public static bool GetOrderDetailByID(int OrderDetailID, ref int Quantity, ref decimal UnitPrice, ref int OrderID, ref int MedicineID)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from OrderDetails where OrderDetailID=@OrderDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                Quantity = (int)reader["Quantity"];
                                UnitPrice = (decimal)reader["UnitPrice"];
                                OrderID = (int)reader["OrderID"];
                                MedicineID = (int)reader["MedicineID"];



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


        public static int AddNewOrderDetail(int Quantity, decimal UnitPrice, int OrderID, int MedicineID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into OrderDetails([Quantity], [UnitPrice], [OrderID], [MedicineID]) values (@Quantity, @UnitPrice, @OrderID, @MedicineID);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@MedicineID", MedicineID);

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


        public static bool UpdateOrderDetail(int OrderDetailID, int Quantity, decimal UnitPrice, int OrderID, int MedicineID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update OrderDetails set Quantity = @Quantity, UnitPrice = @UnitPrice, OrderID = @OrderID, MedicineID = @MedicineID where OrderDetailID=@OrderDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@MedicineID", MedicineID);

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


        public static bool DeleteOrderDetail(int OrderDetailID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from OrderDetails where OrderDetailID=@OrderDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
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


        public static bool IsExist(int OrderDetailID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from OrderDetails where OrderDetailID=@OrderDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
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
