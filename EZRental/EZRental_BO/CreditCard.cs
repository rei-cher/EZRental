using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZRental_DA;
using System.IO;

namespace EZRental_BO
{
    public class CreditCard
    {
        //Private Data
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private string m_CreditCardIssuingCompany;
        private byte m_MerchantCode;
        private DateTime m_ExpDate;
        private string m_AddressLine1;
        private string m_AddressLine2;
        private string m_City;
        private string m_State;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditCardLimit;
        private decimal m_CreditCardBalance;
        private bool m_ActivationStatus;

        //Public Properties
        public string CreditCardNumber
        {
            get
            {
                return m_CreditCardNumber;
            }
            set
            {
                m_CreditCardNumber = value;
            }
        }

        public string CreditCardOwnerName
        {
            get
            {
                return m_CreditCardOwnerName;
            }
            set
            {
                m_CreditCardOwnerName = value;
            }
        }

        public string CreditCardIssuingCompany
        {
            get
            {
                return m_CreditCardIssuingCompany;
            }
            set
            {
                m_CreditCardIssuingCompany = value;
            }
        }

        public byte MerchantCode
        {
            get
            {
                return m_MerchantCode;
            }
            set
            {
                m_MerchantCode = value;
            }
        }

        public DateTime ExpDate
        {
            get
            {
                return m_ExpDate;
            }
            set
            {
                m_ExpDate = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return m_AddressLine1;
            }
            set
            {
                m_AddressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return m_AddressLine2;
            }
            set
            {
                m_AddressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return m_City;
            }
            set
            {
                m_City = value;
            }
        }

        public string State
        {
            get
            {
                return m_State;
            }
            set
            {
                m_State = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return m_ZipCode;
            }
            set
            {
                m_ZipCode = value;
            }
        }

        public string Country
        {
            get
            {
                return m_Country;
            }
            set
            {
                m_Country = value;
            }
        }

        public decimal CreditCardLimit
        {
            get
            {
                return m_CreditCardLimit;
            }
            set
            {
                m_CreditCardLimit = value;
            }
        }

        public decimal CreditCardBalance
        {
            get
            {
                return m_CreditCardBalance;
            }
            set
            {
                m_CreditCardBalance = value;
            }
        }

        public bool ActivationStatus
        {
            get
            {
                return m_ActivationStatus;
            }
        }
        

        //Public Constructor and Destructor
        public CreditCard()
        {

        }

        public CreditCard(string cn, string con, string ccic ,byte mc, string exd, string add1, string add2, string c, string s, string z, string co, decimal ccl = 3000.00M, decimal ccb = 3000.00M)
        {
            this.CreditCardNumber = cn;
            this.CreditCardOwnerName = con;
            this.CreditCardIssuingCompany = ccic;
            this.MerchantCode = mc;
            this.ExpDate = Convert.ToDateTime(exd);
            this.AddressLine1 = add1;
            this.AddressLine2 = add2;
            this.City = c;
            this.State = s;
            this.ZipCode = z;
            this.Country = co;
            this.CreditCardLimit = ccl;
            this.CreditCardBalance = ccb;
            m_ActivationStatus = true;
        }

        ~CreditCard()
        {

        }


        //Public Methods
        public void Print()
        {
            StreamWriter writer = new StreamWriter("Network_Printer.txt", true);

            writer.WriteLine("The Credit Card Information:");
            writer.WriteLine("Credit Card Number = {0}", m_CreditCardNumber);
            writer.WriteLine("Credit Card Owner Name = {0}", m_CreditCardOwnerName);
            writer.WriteLine("Credit Card Issuing Company = {0}", m_CreditCardIssuingCompany);
            writer.WriteLine("Merchant Code = {0}", m_MerchantCode);
            writer.WriteLine("Expiration Date = {0}", m_ExpDate);
            writer.WriteLine("Billing Address Line 1 = {0}", m_AddressLine1);
            writer.WriteLine("Billing Address Line 2 = {0}", m_AddressLine2);
            writer.WriteLine("Billing City = {0}", m_City);
            writer.WriteLine("Billing State = {0}", m_State);
            writer.WriteLine("Billing Zipcode = {0}", m_ZipCode);
            writer.WriteLine("Billing Country = {0}", m_Country);
            writer.WriteLine("Credit Card Limit = {0}", m_CreditCardLimit);
            writer.WriteLine("Credit Card Balance = {0}", m_CreditCardBalance);
            writer.WriteLine("Activation Status = {0}", m_ActivationStatus);

            writer.WriteLine();
            writer.WriteLine();

            writer.Close();
        }

        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }

        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }

        public bool Load(string key)
        {
            return DALayer_Load(key);
        }

        public bool Insert()
        {
            return DALayer_Insert();
        }

        public bool Update()
        {
            return DALayer_Update();
        }

        public bool Delete(string key)
        {
            return DALayer_Delete(key);
        }

        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();
        }


        //Protected Methods
        protected bool DALayer_Load(string key)
        {
            try
            {
                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                CreditCardDTO objCreditCardDTO = objCreditCardDAO.GetRecordByID(key);

                if (objCreditCardDTO != null)
                {
                    this.CreditCardNumber = objCreditCardDTO.CreditCardNumber;
                    this.CreditCardOwnerName = objCreditCardDTO.CreditCardOwnerName;
                    this.CreditCardIssuingCompany = objCreditCardDTO.CreditCardIssuingCompany;
                    this.MerchantCode = objCreditCardDTO.MerchantCode;
                    this.ExpDate = objCreditCardDTO.ExpDate;
                    this.AddressLine1 = objCreditCardDTO.AddressLine1;
                    this.AddressLine2 = objCreditCardDTO.AddressLine2;
                    this.City = objCreditCardDTO.City;
                    this.State = objCreditCardDTO.State;
                    this.ZipCode = objCreditCardDTO.ZipCode;
                    this.Country = objCreditCardDTO.Country;
                    this.CreditCardLimit = objCreditCardDTO.CreditCardLimit;
                    this.CreditCardBalance = objCreditCardDTO.CreditCardBalance;

                    if (objCreditCardDTO.ActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();

                    return true;
                }
                else
                {
                    return false;
                }

            } 
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }

        protected bool DALayer_Insert()
        {
            try
            {
                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.CreditCardIssuingCompany = this.CreditCardIssuingCompany;
                objCreditCardDTO.MerchantCode = this.MerchantCode;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.State = this.State;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;

                bool inserted = objCreditCardDAO.Insert(objCreditCardDTO);

                if (inserted == true)
                {

                    return true;
                }
                else
                {
                    return false;

                }



            } 
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);

            }

        }

        protected bool DALayer_Update()
        {
            try
            {
                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.CreditCardIssuingCompany = this.CreditCardIssuingCompany;
                objCreditCardDTO.MerchantCode = this.MerchantCode;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.State = this.State;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;


                bool updated = objCreditCardDAO.Update(objCreditCardDTO);

                if (updated == true)
                {

                    return true;
                }
                else
                {
                    return false;

                }

            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);

            }

        }

        protected bool DALayer_Delete(string key)
        {
            try
            {
                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                bool deleted = objCreditCardDAO.Delete(key);


                if (deleted == true)
                {

                    return true;
                }
                else
                {
                    return false;

                }

            }  
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);

            }

        }

        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {
            try
            {
                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                List<CreditCardDTO> objCreditCardDTOList = objCreditCardDAO.GetAllRecords();


                if (objCreditCardDTOList != null)
                {

                    List<CreditCard> objCreditCardList = new List<CreditCard>();

                    foreach (CreditCardDTO objDTO in objCreditCardDTOList)
                    {

                        CreditCard objCreditCard = new CreditCard();


                        objCreditCard.CreditCardNumber = objDTO.CreditCardNumber;
                        objCreditCard.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                        objCreditCard.CreditCardIssuingCompany = objDTO.CreditCardIssuingCompany;
                        objCreditCard.MerchantCode = objDTO.MerchantCode;
                        objCreditCard.ExpDate = objDTO.ExpDate;
                        objCreditCard.AddressLine1 = objDTO.AddressLine1;
                        objCreditCard.AddressLine2 = objDTO.AddressLine2;
                        objCreditCard.City = objDTO.City;
                        objCreditCard.State = objDTO.State;
                        objCreditCard.ZipCode = objDTO.ZipCode;
                        objCreditCard.Country = objDTO.Country;
                        objCreditCard.CreditCardLimit = objDTO.CreditCardLimit;
                        objCreditCard.CreditCardBalance = objDTO.CreditCardBalance;

                        if (objDTO.ActivationStatus == true)
                            objCreditCard.Activate();
                        else
                            objCreditCard.Deactivate();
 
                        objCreditCardList.Add(objCreditCard);

                    }

                    return objCreditCardList;

                }


                else
                {
                    return null;
                }

            }
 
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCards(key) Method: {0} " + objE.Message);

            }

        }
    }
}
