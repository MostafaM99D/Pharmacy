using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsPurchaseDetailsData
    {
        public static DataTable GetAllPurchaseDetailsData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM PurchaseDetails ";
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

        public static bool GetPurchaseDetailByID(int PurchaseDetailID, ref int PurchaseID, ref int MedicineID, ref int Quantity, ref decimal UnitCost)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from PurchaseDetails where PurchaseDetailID=@PurchaseDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseDetailID", PurchaseDetailID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                PurchaseID = (int)reader["PurchaseID"];
                                MedicineID = (int)reader["MedicineID"];
                                Quantity = (int)reader["Quantity"];
                                UnitCost = (decimal)reader["UnitCost"];



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


        public static int AddNewPurchaseDetail(int PurchaseID, int MedicineID, int Quantity, decimal UnitCost)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into PurchaseDetails([PurchaseID], [MedicineID], [Quantity], [UnitCost]) values (@PurchaseID, @MedicineID, @Quantity, @UnitCost);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                    cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@UnitCost", UnitCost);

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


        public static bool UpdatePurchaseDetail(int PurchaseDetailID, int PurchaseID, int MedicineID, int Quantity, decimal UnitCost)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update PurchaseDetails set PurchaseID = @PurchaseID, MedicineID = @MedicineID, Quantity = @Quantity, UnitCost = @UnitCost where PurchaseDetailID=@PurchaseDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseDetailID", PurchaseDetailID);
                    cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                    cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@UnitCost", UnitCost);

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


        public static bool DeletePurchaseDetail(int PurchaseDetailID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from PurchaseDetails where PurchaseDetailID=@PurchaseDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseDetailID", PurchaseDetailID);
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


        public static bool IsExist(int PurchaseDetailID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from PurchaseDetails where PurchaseDetailID=@PurchaseDetailID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseDetailID", PurchaseDetailID);
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
