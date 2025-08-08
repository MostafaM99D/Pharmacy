using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsMedicines
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }
        public string Dosage { get; set; }
        public decimal SalePrice { get; set; }
        public int CategoryID { get; set; }
        public clsCategories CategoryInfo { get; set; }

        public clsMedicines()
        {
            this.MedicineID = default;
            this.MedicineName = default;
            this.Description = default;
            this.Dosage = default;
            this.SalePrice = default;
            this.CategoryID = default;

            _Mode = enMode.AddNew;
        }

        private clsMedicines(int MedicineID, string MedicineName, string Description, string Dosage, decimal SalePrice, int CategoryID)
        {
            this.MedicineID = MedicineID;
            this.MedicineName = MedicineName;
            this.Description = Description;
            this.Dosage = Dosage;
            this.SalePrice = SalePrice;
            this.CategoryID = CategoryID;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllMedicines()
        {
            return clsMedicinesData.GetAllMedicinesData();
        }
        public static clsMedicines Find(int MedicineID)
        {

            string MedicineName = default;
            string Description = default;
            string Dosage = default;
            decimal SalePrice = default;
            int CategoryID = default;


            if (!clsMedicinesData.GetMedicineByID(MedicineID, ref MedicineName, ref Description, ref Dosage, ref SalePrice, ref CategoryID))
                return null;
            else
            {
                clsMedicines m= new clsMedicines(MedicineID, MedicineName, Description, Dosage, SalePrice, CategoryID);
                m.CategoryInfo=clsCategories.Find(CategoryID);

                return m;
            }

        }
        private bool _AddNew()
        {
            this.MedicineID = clsMedicinesData.AddNewMedicine(this.MedicineName, this.Description, this.Dosage, this.SalePrice, this.CategoryID);
            return MedicineID != -1;


        }
        private bool _Update()
        {
            return clsMedicinesData.UpdateMedicine(this.MedicineID, this.MedicineName, this.Description, this.Dosage, this.SalePrice, this.CategoryID);

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
        public static bool DeleteByID(int MedicineID)
        {
            return clsMedicinesData.DeleteMedicine(MedicineID);

        }
        public static bool IsExist(int MedicineID)
        {
            return clsMedicinesData.IsExist(MedicineID);

        }

        public static bool IsExist(string MedicineName)
        {
            return clsMedicinesData.IsExist(MedicineName);

        }
    }


}
