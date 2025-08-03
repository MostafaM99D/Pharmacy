using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsUsersData
    {
        public static DataTable GetAllUsersData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM vw_Users ";
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

        public static bool GetUserByID(int UserID, ref int PersonID, ref int RoleID, ref string Username, ref string Password, ref bool IsActive)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Users where UserID=@UserID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                PersonID = (int)reader["PersonID"];
                                RoleID = (int)reader["RoleID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];



                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);
                        //Is_Found=false;

                    }



                }


            }
                    return Is_Found;


        }
        public static bool GetUserByPersonID(ref int UserID, int PersonID, ref int RoleID, ref string Username, ref string Password, ref bool IsActive)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Users where PersonID=@PersonID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;

                                UserID = (int)reader["UserID"];
                                RoleID = (int)reader["RoleID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];



                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);
                        //Is_Found=false;

                    }



                }
            }
                    return Is_Found;
        }
        public static bool GetUserByUsernameAndPassword(ref int UserID, ref int PersonID, ref int RoleID,  string Username,  string Password, ref bool IsActive)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from Users where Username=@Username and Password=@Password; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Is_Found = true;
                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                RoleID = (int)reader["RoleID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];



                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);
                        //Is_Found=false;

                    }



                }
            }
                    return Is_Found;
        }






        public static int AddNewUser(int PersonID, int RoleID, string Username, string Password, bool IsActive)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into Users([PersonID], [RoleID], [Username], [Password], [IsActive]) values (@PersonID, @RoleID, @Username, @Password, @IsActive);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);

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


        public static bool UpdateUser(int UserID, int PersonID, int RoleID, string Username, string Password, bool IsActive)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update Users set PersonID = @PersonID, RoleID = @RoleID, Username = @Username, Password = @Password, IsActive = @IsActive where UserID=@UserID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);

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


        public static bool DeleteUser(int UserID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from Users where UserID=@UserID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
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


        public static bool IsExist(int UserID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from Users where UserID=@UserID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
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

        public static bool IsExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from Users where PersonID=@PersonID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static bool IsExist(string Username)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from Users where Username=@Username; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
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







        public static int Count(int RoleID)
        {
            int rows_affected = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select count(*) from users where RoleID=@RoleID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {                
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);
                    try
                    {

                        conn.Open();
                        object obj = cmd.ExecuteScalar();

                        if (obj != null && int.TryParse(Convert.ToString(obj), out int r))
                            rows_affected = r;

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error.", ex);

                        //rows_affected=-1;

                    }


                }


            }


            return rows_affected;
        }






    }

}
