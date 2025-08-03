using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsOrders
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal? DueAmount { get; set; }
        public int PaymentMethodID { get; set; }

        public clsPaymentMethods PaymentMethodInfo { get; set; }

        public clsOrders()
        {
            this.OrderID = default;
            this.CustomerID = default;
            this.UserID = default;
            this.OrderDate = default;
            this.TotalAmount = default;
            this.PaidAmount = default;
            this.DueAmount = default;
            this.PaymentMethodID = default;

            _Mode = enMode.AddNew;
        }

        private clsOrders(int OrderID, int CustomerID, int UserID, DateTime OrderDate, decimal TotalAmount, decimal PaidAmount, decimal DueAmount, int PaymentMethodID)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.UserID = UserID;
            this.OrderDate = OrderDate;
            this.TotalAmount = TotalAmount;
            this.PaidAmount = PaidAmount;
            this.DueAmount = DueAmount;
            this.PaymentMethodID = PaymentMethodID;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllOrders()
        {
            return clsOrdersData.GetAllOrdersData();
        }
        public static clsOrders Find(int OrderID)
        {

            int CustomerID = default;
            int UserID = default;
            DateTime OrderDate = default;
            decimal TotalAmount = default;
            decimal PaidAmount = default;
            decimal DueAmount = default;
            int PaymentMethodID = default;


            if (!clsOrdersData.GetOrderByID(OrderID, ref CustomerID, ref UserID, ref OrderDate, ref TotalAmount, ref PaidAmount, ref DueAmount, ref PaymentMethodID))
                return null;
            else
            {
                clsOrders o = new clsOrders(OrderID, CustomerID, UserID, OrderDate, TotalAmount, PaidAmount, DueAmount, PaymentMethodID);
                o.PaymentMethodInfo = clsPaymentMethods.Find(PaymentMethodID);
                return o;

            }
        }
        private bool _AddNew()
        {
            this.OrderID = clsOrdersData.AddNewOrder(this.CustomerID, this.UserID, this.OrderDate, this.TotalAmount, this.PaidAmount, this.DueAmount, this.PaymentMethodID);
            return OrderID != -1;


        }
        private bool _Update()
        {
            return clsOrdersData.UpdateOrder(this.OrderID, this.CustomerID, this.UserID, this.OrderDate, this.TotalAmount, this.PaidAmount, this.DueAmount, this.PaymentMethodID);

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
        public static bool DeleteByID(int OrderID)
        {
            return clsOrdersData.DeleteOrder(OrderID);

        }
        public static bool IsExist(int OrderID)
        {
            return clsOrdersData.IsExist(OrderID);

        }


    }


}
