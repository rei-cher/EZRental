using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZRental_DA;
using System.IO;

namespace EZRental_BO
{
    public class Country
    {
        //Public Properties
        public int CountryID { get; set; }

        public string CountryCode2 { get; set; }

        public string CountryCode3 { get; set; }

        public string CountryName { get; set; }


        //Public Constructor and Destructor
        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2 = "";
            this.CountryCode3 = "";
            this.CountryName = "";
        }

        public Country(int country_id, string country_code_2, string country_code_3, string country_name)
        {
            this.CountryID = country_id;
            this.CountryCode2 = country_code_2;
            this.CountryCode3 = country_code_3;
            this.CountryName = country_name;
        }

        ~Country()
        {

        }


        //Public Methods
        public void Print()
        {
            StreamWriter writer = new StreamWriter("Network_Printer.txt", true);

            writer.WriteLine("Country Information:");
            writer.WriteLine("Country ID = {0}", CountryID);
            writer.WriteLine("Country Code 2 Characters = {0}", CountryCode2);
            writer.WriteLine("Country Code 3 Characters = {0}", CountryCode3);
            writer.WriteLine("Country Name = {0}", CountryName);

            writer.WriteLine();
            writer.WriteLine();

            writer.Close();
        }

        public static List<Country> GetAllCountries()
        {
            return DALayer_GetAllCountries();
        }

        public static List<Country> DALayer_GetAllCountries()
        {
            try
            {
                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                List<CountryDTO> objCountryDTOList = objCountryDAO.GetAllRecords();


                if (objCountryDTOList != null)
                {

                    List<Country> objCountryList = new List<Country>();

                    foreach (CountryDTO objDTO in objCountryDTOList)
                    {

                        Country objCountry = new Country();

                        objCountry.CountryID = objDTO.CountryID;
                        objCountry.CountryCode2 = objDTO.CountryCode2;
                        objCountry.CountryCode3 = objDTO.CountryCode3;
                        objCountry.CountryName = objDTO.CountryName;

                        objCountryList.Add(objCountry);

                    }

                    return objCountryList;

                }//End of if

                else
                {
                    return null;
                }

            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_GetAllCountries(key) Method: {0} " + objE.Message);

            }
        }
    }
}
