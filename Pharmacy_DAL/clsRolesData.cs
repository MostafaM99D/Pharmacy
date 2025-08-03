using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsRolesData
    {
        public static DataTable GetAllRolesData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Roles ";
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

        public static bool GetRoleByID(int RoleID, ref string RoleName)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Roles where RoleID=@RoleID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                RoleName = (string)reader["RoleName"];



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
        public static bool GetRoleByName(ref int RoleID, string RoleName)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Roles where RoleName=@RoleName; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleName", RoleName);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                RoleID = (int)reader["RoleID"];



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

        public static int AddNewRole(string RoleName)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into Roles([RoleName]) values (@RoleName);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleName", RoleName);

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


        public static bool UpdateRole(int RoleID, string RoleName)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update Roles set RoleName = @RoleName where RoleID=@RoleID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);
                    cmd.Parameters.AddWithValue("@RoleName", RoleName);

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


        public static bool DeleteRole(int RoleID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from Roles where RoleID=@RoleID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);
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


        public static bool IsExist(int RoleID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from Roles where RoleID=@RoleID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);
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
