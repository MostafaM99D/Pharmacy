using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsMedicineInventoriesData
    {
        public static DataTable GetAllMedicineInventoriesData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM MedicineInventories ";
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

        public static bool GetMedicineInventoryByID(int MedInventoryID, ref int Quantity, ref DateTime ExpirationDate, ref decimal PurchasePrice, ref int MedicineID)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from MedicineInventories where MedInventoryID=@MedInventoryID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedInventoryID", MedInventoryID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                Quantity = (int)reader["Quantity"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                PurchasePrice = (decimal)reader["PurchasePrice"];
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


        public static int AddNewMedicineInventory(int Quantity, DateTime ExpirationDate, decimal PurchasePrice, int MedicineID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into MedicineInventories([Quantity], [ExpirationDate], [PurchasePrice], [MedicineID]) values (@Quantity, @ExpirationDate, @PurchasePrice, @MedicineID);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
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


        public static bool UpdateMedicineInventory(int MedInventoryID, int Quantity, DateTime ExpirationDate, decimal PurchasePrice, int MedicineID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update MedicineInventories set Quantity = @Quantity, ExpirationDate = @ExpirationDate, PurchasePrice = @PurchasePrice, MedicineID = @MedicineID where MedInventoryID=@MedInventoryID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedInventoryID", MedInventoryID);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
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


        public static bool DeleteMedicineInventory(int MedInventoryID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from MedicineInventories where MedInventoryID=@MedInventoryID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedInventoryID", MedInventoryID);
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


        public static bool IsExist(int MedInventoryID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from MedicineInventories where MedInventoryID=@MedInventoryID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedInventoryID", MedInventoryID);
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

        public static int CountExpirats(char ComparerSign)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = $" select count(*)from vw_medicineDetails where ExpirationDate {ComparerSign}= GETDATE();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

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


        public static int GetValidMedicinsCount()
        {
            return CountExpirats('>');
        }

        public static int GetExpirationsMedicinsCount()
        {
            return CountExpirats('<');
        }

    }

 

}
