using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsPurchasesData
    {
        public static DataTable GetAllPurchasesData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Purchases ";
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

        public static bool GetPurchaseByID(int PurchaseID, ref DateTime PurchaseDate, ref decimal TotalCost, ref int SupplierID, ref int UserID)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Purchases where PurchaseID=@PurchaseID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                PurchaseDate = (DateTime)reader["PurchaseDate"];
                                TotalCost = (decimal)reader["TotalCost"];
                                SupplierID = (int)reader["SupplierID"];
                                UserID = (int)reader["UserID"];



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


        public static int AddNewPurchase(DateTime PurchaseDate, decimal TotalCost, int SupplierID, int UserID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into Purchases([PurchaseDate], [TotalCost], [SupplierID], [UserID]) values (@PurchaseDate, @TotalCost, @SupplierID, @UserID);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);
                    cmd.Parameters.AddWithValue("@TotalCost", TotalCost);
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                    cmd.Parameters.AddWithValue("@UserID", UserID);

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


        public static bool UpdatePurchase(int PurchaseID, DateTime PurchaseDate, decimal TotalCost, int SupplierID, int UserID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update Purchases set PurchaseDate = @PurchaseDate, TotalCost = @TotalCost, SupplierID = @SupplierID, UserID = @UserID where PurchaseID=@PurchaseID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                    cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);
                    cmd.Parameters.AddWithValue("@TotalCost", TotalCost);
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                    cmd.Parameters.AddWithValue("@UserID", UserID);

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


        public static bool DeletePurchase(int PurchaseID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from Purchases where PurchaseID=@PurchaseID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
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


        public static bool IsExist(int PurchaseID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from Purchases where PurchaseID=@PurchaseID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
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
