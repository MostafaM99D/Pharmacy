using System;

using System.Data;

using System.Data.SqlClient;

using Pharmacy_DAL;


namespace BLL
{


    public class clsPeople
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public clsPeople()
        {
            this.PersonID = default;
            this.FirstName = default;
            this.LastName = default;
            this.Email = default;
            this.PhoneNumber = default;
            this.Address = default;

            _Mode = enMode.AddNew;
        }

        private clsPeople(int PersonID, string FirstName, string LastName, string Email, string PhoneNumber, string Address)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;


            _Mode = enMode.Update;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeopleData();
        }
        public static clsPeople Find(int PersonID)
        {

            string FirstName = default;
            string LastName = default;
            string Email = default;
            string PhoneNumber = default;
            string Address = default;


            if (!clsPeopleData.GetPersonByID(PersonID, ref FirstName, ref LastName, ref Email, ref PhoneNumber, ref Address))
                return null;
            else

                return new clsPeople(PersonID, FirstName, LastName, Email, PhoneNumber, Address);

        }
        private bool _AddNew()
        {
            this.PersonID = clsPeopleData.AddNewPerson(this.FirstName, this.LastName, this.Email, this.PhoneNumber, this.Address);
            return PersonID != -1;


        }
        private bool _Update()
        {
            return clsPeopleData.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.Email, this.PhoneNumber, this.Address);

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
        public static bool DeleteByID(int PersonID)
        {
            return clsPeopleData.DeletePerson(PersonID);

        }
        public static bool IsExist(int PersonID)
        {
            return clsPeopleData.IsExist(PersonID);

        }


    }


}
