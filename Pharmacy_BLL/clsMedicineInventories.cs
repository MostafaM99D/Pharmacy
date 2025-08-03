using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsMedicineInventories
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int MedInventoryID { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public int MedicineID { get; set; }

        public clsMedicines MedicineInfo {  get; set; }
        public clsMedicineInventories()
        {
            this.MedInventoryID = default;
            this.Quantity = default;
            this.ExpirationDate = default;
            this.PurchasePrice = default;
            this.MedicineID = default;

            _Mode = enMode.AddNew;
        }

        private clsMedicineInventories(int MedInventoryID, int Quantity, DateTime ExpirationDate, decimal PurchasePrice, int MedicineID)
        {
            this.MedInventoryID = MedInventoryID;
            this.Quantity = Quantity;
            this.ExpirationDate = ExpirationDate;
            this.PurchasePrice = PurchasePrice;
            this.MedicineID = MedicineID;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllMedicineInventories()
        {
            return clsMedicineInventoriesData.GetAllMedicineInventoriesData();
        }
        public static clsMedicineInventories Find(int MedInventoryID)
        {

            int Quantity = default;
            DateTime ExpirationDate = default;
            decimal PurchasePrice = default;
            int MedicineID = default;


            if (!clsMedicineInventoriesData.GetMedicineInventoryByID(MedInventoryID, ref Quantity, ref ExpirationDate, ref PurchasePrice, ref MedicineID))
                return null;
            else
            {
                
                clsMedicineInventories mi= new clsMedicineInventories(MedInventoryID, Quantity, ExpirationDate, PurchasePrice, MedicineID);
                mi.MedicineInfo=clsMedicines.Find(MedicineID);
                return mi;
            }

        }
        private bool _AddNew()
        {
            this.MedInventoryID = clsMedicineInventoriesData.AddNewMedicineInventory(this.Quantity, this.ExpirationDate, this.PurchasePrice, this.MedicineID);
            return MedInventoryID != -1;


        }
        private bool _Update()
        {
            return clsMedicineInventoriesData.UpdateMedicineInventory(this.MedInventoryID, this.Quantity, this.ExpirationDate, this.PurchasePrice, this.MedicineID);

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
        public static bool DeleteByID(int MedInventoryID)
        {
            return clsMedicineInventoriesData.DeleteMedicineInventory(MedInventoryID);

        }
        public static bool IsExist(int MedInventoryID)
        {
            return clsMedicineInventoriesData.IsExist(MedInventoryID);

        }

        public static int CountExpirationMedicines()
        {
            return clsMedicineInventoriesData.GetExpirationsMedicinsCount();
        }

        public static int CountValidMedicines()
        {
            return clsMedicineInventoriesData.GetValidMedicinsCount();
        }
    }


}
