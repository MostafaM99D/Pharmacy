using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsOrderDetails
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int OrderDetailID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderID { get; set; }
        public int MedicineID { get; set; }
        public clsOrders OrderInfo { get; set; }
        public clsMedicines MedicineInfo { get; set; }

        public clsOrderDetails()
        {
            this.OrderDetailID = default;
            this.Quantity = default;
            this.UnitPrice = default;
            this.OrderID = default;
            this.MedicineID = default;

            _Mode = enMode.AddNew;
        }

        private clsOrderDetails(int OrderDetailID, int Quantity, decimal UnitPrice, int OrderID, int MedicineID)
        {
            this.OrderDetailID = OrderDetailID;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.OrderID = OrderID;
            this.MedicineID = MedicineID;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllOrderDetails()
        {
            return clsOrderDetailsData.GetAllOrderDetailsData();
        }
        public static clsOrderDetails Find(int OrderDetailID)
        {

            int Quantity = default;
            decimal UnitPrice = default;
            int OrderID = default;
            int MedicineID = default;


            if (!clsOrderDetailsData.GetOrderDetailByID(OrderDetailID, ref Quantity, ref UnitPrice, ref OrderID, ref MedicineID))
                return null;
            else
            {
               clsOrderDetails od= new clsOrderDetails(OrderDetailID, Quantity, UnitPrice, OrderID, MedicineID);
                od.OrderInfo=clsOrders.Find(OrderID);
                od.MedicineInfo=clsMedicines.Find(MedicineID);
                return od;
            }
        }
        private bool _AddNew()
        {
            this.OrderDetailID = clsOrderDetailsData.AddNewOrderDetail(this.Quantity, this.UnitPrice, this.OrderID, this.MedicineID);
            return OrderDetailID != -1;


        }
        private bool _Update()
        {
            return clsOrderDetailsData.UpdateOrderDetail(this.OrderDetailID, this.Quantity, this.UnitPrice, this.OrderID, this.MedicineID);

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
        public static bool DeleteByID(int OrderDetailID)
        {
            return clsOrderDetailsData.DeleteOrderDetail(OrderDetailID);

        }
        public static bool IsExist(int OrderDetailID)
        {
            return clsOrderDetailsData.IsExist(OrderDetailID);

        }


    }


}
