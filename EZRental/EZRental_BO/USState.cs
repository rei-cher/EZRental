using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZRental_DA;
using System.IO;

namespace EZRental_BO
{
    public class USState
    {
        //Public Properties
        public int StateID { get; set; }

        public string StateCode { get; set; }

        public string StateName { get; set; }


        //Public Constructor and Destructor
        public USState()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }

        public USState(int state_id, string state_code, string state_name)
        {
            this.StateID = state_id;
            this.StateCode = state_code;
            this.StateName = state_name;
        }

        ~USState()
        {

        }


        //Public Methods
        public void Print()
        {
            StreamWriter writer = new StreamWriter("Network_Printer.txt", true);

            writer.WriteLine("US State Information:");
            writer.WriteLine("US State ID = {0}", StateID);
            writer.WriteLine("US State Code = {0}", StateCode);
            writer.WriteLine("US State Name = {0}", StateName);

            writer.WriteLine();
            writer.WriteLine();

            writer.Close();
        }

        public static List<USState> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
        }


        //Protected Methods
        protected static List<USState> DALayer_GetAllUSStates()
        {
            try
            {
                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                USStateDAO objUSStateDAO = objDAOFactory.GetUSStateDAO();

                List<USStateDTO> objUSStateDTOList = objUSStateDAO.GetAllRecords();


                if (objUSStateDTOList != null)
                {

                    List<USState> objUSStateList = new List<USState>();

                    foreach (USStateDTO objDTO in objUSStateDTOList)
                    {

                        USState objUSState = new USState();

                        objUSState.StateID = objDTO.StateID;
                        objUSState.StateCode = objDTO.StateCode;
                        objUSState.StateName = objDTO.StateName;

                        objUSStateList.Add(objUSState);

                    }

                    return objUSStateList;

                }

                else
                {
                    return null;
                }

            }
 
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_GetAllUSState(key) Method: {0} " + objE.Message);

            }
        }
    }
}
