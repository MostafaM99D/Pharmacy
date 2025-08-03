using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsRoles
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public clsRoles()
        {
            this.RoleID = default;
            this.RoleName = default;

            _Mode = enMode.AddNew;
        }

        private clsRoles(int RoleID, string RoleName)
        {
            this.RoleID = RoleID;
            this.RoleName = RoleName;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllRoles()
        {
            return clsRolesData.GetAllRolesData();
        }
        public static clsRoles Find(int RoleID)
        {

            string RoleName = default;


            if (!clsRolesData.GetRoleByID(RoleID, ref RoleName))
                return null;
            else

                return new clsRoles(RoleID, RoleName);

        }

        public static clsRoles Find(string RoleName)
        {

            int ID = default;


            if (!clsRolesData.GetRoleByName(ref ID,  RoleName))
                return null;
            else

                return new clsRoles(ID, RoleName);

        }
        private bool _AddNew()
        {
            this.RoleID = clsRolesData.AddNewRole(this.RoleName);
            return RoleID != -1;


        }
        private bool _Update()
        {
            return clsRolesData.UpdateRole(this.RoleID, this.RoleName);

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
        public static bool DeleteByID(int RoleID)
        {
            return clsRolesData.DeleteRole(RoleID);

        }
        public static bool IsExist(int RoleID)
        {
            return clsRolesData.IsExist(RoleID);

        }


    }


}
