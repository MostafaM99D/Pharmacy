using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsPurchaseDetails
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int PurchaseDetailID { get; set; }
        public int PurchaseID { get; set; }
        public int MedicineID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public clsMedicines MedicineInfo { get; set; }
        public clsPurchases PurchaseInfo { get; set; }

        public clsPurchaseDetails()
        {
            this.PurchaseDetailID = default;
            this.PurchaseID = default;
            this.MedicineID = default;
            this.Quantity = default;
            this.UnitCost = default;

            _Mode = enMode.AddNew;
        }

        private clsPurchaseDetails(int PurchaseDetailID, int PurchaseID, int MedicineID, int Quantity, decimal UnitCost)
        {
            this.PurchaseDetailID = PurchaseDetailID;
            this.PurchaseID = PurchaseID;
            this.MedicineID = MedicineID;
            this.Quantity = Quantity;
            this.UnitCost = UnitCost;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllPurchaseDetails()
        {
            return clsPurchaseDetailsData.GetAllPurchaseDetailsData();
        }
        public static clsPurchaseDetails Find(int PurchaseDetailID)
        {

            int PurchaseID = default;
            int MedicineID = default;
            int Quantity = default;
            decimal UnitCost = default;


            if (!clsPurchaseDetailsData.GetPurchaseDetailByID(PurchaseDetailID, ref PurchaseID, ref MedicineID, ref Quantity, ref UnitCost))
                return null;
            else
            {
                clsPurchaseDetails pd= new clsPurchaseDetails(PurchaseDetailID, PurchaseID, MedicineID, Quantity, UnitCost);
                pd.PurchaseInfo=clsPurchases.Find(PurchaseID);
                pd.MedicineInfo=clsMedicines.Find(MedicineID);
                return pd;
            }
        }
        private bool _AddNew()
        {
            this.PurchaseDetailID = clsPurchaseDetailsData.AddNewPurchaseDetail(this.PurchaseID, this.MedicineID, this.Quantity, this.UnitCost);
            return PurchaseDetailID != -1;


        }
        private bool _Update()
        {
            return clsPurchaseDetailsData.UpdatePurchaseDetail(this.PurchaseDetailID, this.PurchaseID, this.MedicineID, this.Quantity, this.UnitCost);

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
        public static bool DeleteByID(int PurchaseDetailID)
        {
            return clsPurchaseDetailsData.DeletePurchaseDetail(PurchaseDetailID);

        }
        public static bool IsExist(int PurchaseDetailID)
        {
            return clsPurchaseDetailsData.IsExist(PurchaseDetailID);

        }


    }


}
