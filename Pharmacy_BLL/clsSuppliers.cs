using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsSuppliers
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int SupplierID { get; set; }
        public int PersonID { get; set; }

        public clsPeople PeronInfo { get; set; }
        public clsSuppliers()
        {
            this.SupplierID = default;
            this.PersonID = default;

            _Mode = enMode.AddNew;
        }

        private clsSuppliers(int SupplierID, int PersonID)
        {
            this.SupplierID = SupplierID;
            this.PersonID = PersonID;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllSuppliers()
        {
            return clsSuppliersData.GetAllSuppliersData();
        }
        public static clsSuppliers Find(int SupplierID)
        {

            int PersonID = default;


            if (!clsSuppliersData.GetSupplierByID(SupplierID, ref PersonID))
                return null;
            else
            {
                clsSuppliers s = new clsSuppliers(SupplierID, PersonID);
                s.PeronInfo=clsPeople.Find(PersonID);
                return s;
            }

        }
        private bool _AddNew()
        {
            this.SupplierID = clsSuppliersData.AddNewSupplier(this.PersonID);
            return SupplierID != -1;


        }
        private bool _Update()
        {
            return clsSuppliersData.UpdateSupplier(this.SupplierID, this.PersonID);

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
        public static bool DeleteByID(int SupplierID)
        {
            return clsSuppliersData.DeleteSupplier(SupplierID);

        }
        public static bool IsExist(int SupplierID)
        {
            return clsSuppliersData.IsExist(SupplierID);

        }
        public static int Count()
        {
            return clsSuppliersData.Count();
        }


    }


}
