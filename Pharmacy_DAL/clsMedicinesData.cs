using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsMedicinesData
    {
        public static DataTable GetAllMedicinesData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM vw_medicineDetails ";
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

        public static bool GetMedicineByID(int MedicineID, ref string MedicineName, ref string Description, ref string Dosage, ref decimal SalePrice, ref int CategoryID)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Medicines where MedicineID=@MedicineID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicineID", MedicineID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                MedicineName = (string)reader["MedicineName"];
                                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : (string)reader["Description"];
                                Dosage = reader.IsDBNull(reader.GetOrdinal("Dosage")) ? null : (string)reader["Dosage"];
                                SalePrice = (decimal)reader["SalePrice"];
                                CategoryID = (int)reader["CategoryID"];



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


        public static int AddNewMedicine(string MedicineName, string Description, string Dosage, decimal SalePrice, int CategoryID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into Medicines([MedicineName], [Description], [Dosage], [SalePrice], [CategoryID]) values (@MedicineName, @Description, @Dosage, @SalePrice, @CategoryID);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicineName", MedicineName);

                    if (Description != null)
                        cmd.Parameters.AddWithValue("@Description", Description);
                    else
                        cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    if (Dosage != null)
                        cmd.Parameters.AddWithValue("@Dosage", Dosage);
                    else
                        cmd.Parameters.AddWithValue("@Dosage", DBNull.Value); cmd.Parameters.AddWithValue("@SalePrice", SalePrice);
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);

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


        public static bool UpdateMedicine(int MedicineID, string MedicineName, string Description, string Dosage, decimal SalePrice, int CategoryID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update Medicines set MedicineName = @MedicineName, Description = @Description, Dosage = @Dosage, SalePrice = @SalePrice, CategoryID = @CategoryID where MedicineID=@MedicineID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
                    cmd.Parameters.AddWithValue("@MedicineName", MedicineName);

                    if (Description != null)
                        cmd.Parameters.AddWithValue("@Description", Description);
                    else
                        cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    if (Dosage != null)
                        cmd.Parameters.AddWithValue("@Dosage", Dosage);
                    else
                        cmd.Parameters.AddWithValue("@Dosage", DBNull.Value); cmd.Parameters.AddWithValue("@SalePrice", SalePrice);
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);

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


        public static bool DeleteMedicine(int MedicineID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from Medicines where MedicineID=@MedicineID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
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


        public static bool IsExist(int MedicineID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from Medicines where MedicineID=@MedicineID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
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
