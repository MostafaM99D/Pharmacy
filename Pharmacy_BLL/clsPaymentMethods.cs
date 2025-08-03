using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsPaymentMethods
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int PaymentMethodID { get; set; }
        public string PayMethodName { get; set; }

        public clsPaymentMethods()
        {
            this.PaymentMethodID = default;
            this.PayMethodName = default;

            _Mode = enMode.AddNew;
        }

        private clsPaymentMethods(int PaymentMethodID, string PayMethodName)
        {
            this.PaymentMethodID = PaymentMethodID;
            this.PayMethodName = PayMethodName;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllPaymentMethods()
        {
            return clsPaymentMethodsData.GetAllPaymentMethodsData();
        }
        public static clsPaymentMethods Find(int PaymentMethodID)
        {

            string PayMethodName = default;


            if (!clsPaymentMethodsData.GetPaymentMethodByID(PaymentMethodID, ref PayMethodName))
                return null;
            else

                return new clsPaymentMethods(PaymentMethodID, PayMethodName);

        }
        private bool _AddNew()
        {
            this.PaymentMethodID = clsPaymentMethodsData.AddNewPaymentMethod(this.PayMethodName);
            return PaymentMethodID != -1;


        }
        private bool _Update()
        {
            return clsPaymentMethodsData.UpdatePaymentMethod(this.PaymentMethodID, this.PayMethodName);

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
        public static bool DeleteByID(int PaymentMethodID)
        {
            return clsPaymentMethodsData.DeletePaymentMethod(PaymentMethodID);

        }
        public static bool IsExist(int PaymentMethodID)
        {
            return clsPaymentMethodsData.IsExist(PaymentMethodID);

        }


    }


}
