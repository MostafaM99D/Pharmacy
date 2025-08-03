using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsCategories
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public clsCategories()
        {
            this.CategoryID = default;
            this.CategoryName = default;

            _Mode = enMode.AddNew;
        }

        private clsCategories(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllCategories()
        {
            return clsCategoriesData.GetAllCategoriesData();
        }
        public static clsCategories Find(int CategoryID)
        {

            string CategoryName = default;


            if (!clsCategoriesData.GetCategoryByID(CategoryID, ref CategoryName))
                return null;
            else

                return new clsCategories(CategoryID, CategoryName);

        }
        public static clsCategories Find(string CategoryName)
        {

            int ID = default;


            if (!clsCategoriesData.GetCategoryByName(ref ID,  CategoryName))
                return null;
            else

                return new clsCategories(ID, CategoryName);

        }
        private bool _AddNew()
        {
            this.CategoryID = clsCategoriesData.AddNewCategory(this.CategoryName);
            return CategoryID != -1;


        }
        private bool _Update()
        {
            return clsCategoriesData.UpdateCategory(this.CategoryID, this.CategoryName);

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
        public static bool DeleteByID(int CategoryID)
        {
            return clsCategoriesData.DeleteCategory(CategoryID);

        }
        public static bool IsExist(int CategoryID)
        {
            return clsCategoriesData.IsExist(CategoryID);

        }


    }


}
