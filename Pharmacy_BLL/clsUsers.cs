using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsUsers
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public int RoleID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsPeople PersonInfo { get; set; }
        public clsRoles RoleInfo { get; set; }


        public clsUsers()
        {
            this.UserID = default;
            this.PersonID = default;
            this.RoleID = default;
            this.Username = default;
            this.Password = default;
            this.IsActive = default;

            _Mode = enMode.AddNew;
        }

        private clsUsers(int UserID, int PersonID, int RoleID, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.RoleID = RoleID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsersData();
        }
        public static clsUsers Find(int UserID)
        {

            int PersonID = default;
            int RoleID = default;
            string Username = default;
            string Password = default;
            bool IsActive = default;


            if (!clsUsersData.GetUserByID(UserID, ref PersonID, ref RoleID, ref Username, ref Password, ref IsActive))
                return null;
            else
            {
                clsUsers U= new clsUsers(UserID, PersonID, RoleID, Username, Password, IsActive);
                U.PersonInfo=clsPeople.Find(PersonID);
                U.RoleInfo=clsRoles.Find(RoleID);
                return U;
            }

        }
        public static clsUsers FindByPersonID(int PersonID)
        {

            int UserID = default;
            int RoleID = default;
            string Username = default;
            string Password = default;
            bool IsActive = default;


            if (!clsUsersData.GetUserByPersonID(ref UserID, PersonID, ref RoleID, ref Username, ref Password, ref IsActive))
                return null;
            else
            {
                clsUsers U = new clsUsers(UserID, PersonID, RoleID, Username, Password, IsActive);
                U.PersonInfo = clsPeople.Find(PersonID);
                U.RoleInfo = clsRoles.Find(RoleID);
                return U;
            }

        }
        public static clsUsers Find(string Username,string Password)
        {
            int UserID = default;
            int PersonID = default;
            int RoleID = default;
          //  string Username = default;
           // string Password = default;
            bool IsActive = default;


            if (!clsUsersData.GetUserByUsernameAndPassword(ref UserID, ref PersonID, ref RoleID,  Username,  Password, ref IsActive))
                return null;
            else
            {
                clsUsers U = new clsUsers(UserID, PersonID, RoleID, Username, Password, IsActive);
                U.PersonInfo = clsPeople.Find(PersonID);
                U.RoleInfo = clsRoles.Find(RoleID);
                return U;
            }

        }
        private bool _AddNew()
        {
            this.UserID = clsUsersData.AddNewUser(this.PersonID, this.RoleID, this.Username, this.Password, this.IsActive);
            return UserID != -1;


        }
        private bool _Update()
        {
            return clsUsersData.UpdateUser(this.UserID, this.PersonID, this.RoleID, this.Username, this.Password, this.IsActive);

        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _Update();

            }
            return false;
        }
        public static bool DeleteByID(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);

        }
        public static bool IsExist(int UserID)
        {
            return clsUsersData.IsExist(UserID);

        }
        public static bool IsExistByPersonID(int PersonID)
        {
            return clsUsersData.IsExistByPersonID(PersonID);

        }
        public static bool IsExist(string Username)
        {
            return clsUsersData.IsExist(Username);

        }

        public static int Count(int RoleID)
        {
            return clsUsersData.Count(RoleID);
        }

    }


}
