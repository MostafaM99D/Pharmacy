using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsPurchases
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int PurchaseID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalCost { get; set; }
        public int SupplierID { get; set; }
        public int UserID { get; set; }
        
        public clsSuppliers SupplierInfo { get; set; }
        

        public clsPurchases()
        {
            this.PurchaseID = default;
            this.PurchaseDate = default;
            this.TotalCost = default;
            this.SupplierID = default;
            this.UserID = default;

            _Mode = enMode.AddNew;
        }

        private clsPurchases(int PurchaseID, DateTime PurchaseDate, decimal TotalCost, int SupplierID, int UserID)
        {
            this.PurchaseID = PurchaseID;
            this.PurchaseDate = PurchaseDate;
            this.TotalCost = TotalCost;
            this.SupplierID = SupplierID;
            this.UserID = UserID;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllPurchases()
        {
            return clsPurchasesData.GetAllPurchasesData();
        }
        public static clsPurchases Find(int PurchaseID)
        {

            DateTime PurchaseDate = default;
            decimal TotalCost = default;
            int SupplierID = default;
            int UserID = default;


            if (!clsPurchasesData.GetPurchaseByID(PurchaseID, ref PurchaseDate, ref TotalCost, ref SupplierID, ref UserID))
                return null;
            else
            {
                clsPurchases p= new clsPurchases(PurchaseID, PurchaseDate, TotalCost, SupplierID, UserID);
                p.SupplierInfo=clsSuppliers.Find(SupplierID);
                return p;
            }
        }
        private bool _AddNew()
        {
            this.PurchaseID = clsPurchasesData.AddNewPurchase(this.PurchaseDate, this.TotalCost, this.SupplierID, this.UserID);
            return PurchaseID != -1;


        }
        private bool _Update()
        {
            return clsPurchasesData.UpdatePurchase(this.PurchaseID, this.PurchaseDate, this.TotalCost, this.SupplierID, this.UserID);

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
        public static bool DeleteByID(int PurchaseID)
        {
            return clsPurchasesData.DeletePurchase(PurchaseID);

        }
        public static bool IsExist(int PurchaseID)
        {
            return clsPurchasesData.IsExist(PurchaseID);

        }


    }


}
