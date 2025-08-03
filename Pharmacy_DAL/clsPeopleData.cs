using System;

using System.Data;

using System.Data.SqlClient;


namespace Pharmacy_DAL
{


    public class clsPeopleData
    {
        public static DataTable GetAllPeopleData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT       PersonID, FirstName+' '+ LastName as Name, Email, PhoneNumber, Address  FROM            People ";
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

        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string LastName, ref string Email, ref string PhoneNumber, ref string Address)
        {
            bool Is_Found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " select *from People where PersonID=@PersonID; ";

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

                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : (string)reader["Email"];
                                PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? null : (string)reader["PhoneNumber"];
                                Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : (string)reader["Address"];



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


        public static int AddNewPerson(string FirstName, string LastName, string Email, string PhoneNumber, string Address)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = " insert into People([FirstName], [LastName], [Email], [PhoneNumber], [Address]) values (@FirstName, @LastName, @Email, @PhoneNumber, @Address);select SCOPE_IDENTITY(); ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);

                    if (Email != null)
                        cmd.Parameters.AddWithValue("@Email", Email);
                    else
                        cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                    if (PhoneNumber != null)
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    else
                        cmd.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                    if (Address != null)
                        cmd.Parameters.AddWithValue("@Address", Address);
                    else
                        cmd.Parameters.AddWithValue("@Address", DBNull.Value);
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


        public static bool UpdatePerson(int PersonID, string FirstName, string LastName, string Email, string PhoneNumber, string Address)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "update People set FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address where PersonID=@PersonID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);

                    if (Email != null)
                        cmd.Parameters.AddWithValue("@Email", Email);
                    else
                        cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                    if (PhoneNumber != null)
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    else
                        cmd.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                    if (Address != null)
                        cmd.Parameters.AddWithValue("@Address", Address);
                    else
                        cmd.Parameters.AddWithValue("@Address", DBNull.Value);
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


        public static bool DeletePerson(int PersonID)
        {
            int rows_affected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from People where PersonID=@PersonID; ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
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


        public static bool IsExist(int PersonID)
        {
            bool IsFound = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select found=1 from People where PersonID=@PersonID; ";

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




    }


}
