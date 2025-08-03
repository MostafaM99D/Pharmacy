using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsCustomers
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int CustomerID { get; set; }
        public int PersonID { get; set; }

        public clsPeople PersonInfo { get; set; }
        public clsCustomers()
        {
            this.CustomerID = default;
            this.PersonID = default;

            _Mode = enMode.AddNew;
        }

        private clsCustomers(int CustomerID, int PersonID)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomersData.GetAllCustomersData();
        }
        public static clsCustomers Find(int CustomerID)
        {

            int PersonID = default;


            if (!clsCustomersData.GetCustomerByID(CustomerID, ref PersonID))
                return null;

            else
            {
                clsCustomers cs= new clsCustomers(CustomerID, PersonID);
                cs.PersonInfo=clsPeople.Find(PersonID);
                return cs;
            }

        }
        private bool _AddNew()
        {
            this.CustomerID = clsCustomersData.AddNewCustomer(this.PersonID);
            return CustomerID != -1;


        }
        private bool _Update()
        {
            return clsCustomersData.UpdateCustomer(this.CustomerID, this.PersonID);

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
        public static bool DeleteByID(int CustomerID)
        {
            return clsCustomersData.DeleteCustomer(CustomerID);

        }
        public static bool IsExist(int CustomerID)
        {
            return clsCustomersData.IsExist(CustomerID);

        }

        public static int Count()
        {
            return clsCustomersData.Count();
        }

    }


}
