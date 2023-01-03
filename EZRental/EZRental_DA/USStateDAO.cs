using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EZRental_DA
{
    public class USStateDAO : IUserInterfaceDAO<USStateDTO>
    {
        public List<USStateDTO> GetAllRecords()
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strsql = "Select * from USSTATES;";

                SqlCommand objCmd = new SqlCommand(strsql, objConn);

                objCmd.CommandType = CommandType.Text;

                SqlDataReader objDR = objCmd.ExecuteReader();

                if (objDR.HasRows)
                {
                    List<USStateDTO> colRecordList = new List<USStateDTO>();

                    while (objDR.Read())
                    {
                        USStateDTO objDTO = new USStateDTO();

                        objDTO.StateID = objDR.GetByte(0);
                        objDTO.StateCode = objDR.GetString(1);
                        objDTO.StateName = objDR.GetString(2);

                        colRecordList.Add(objDTO);

                    }

                    return colRecordList;
                }

                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;

                return null;
            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in USState GetAllRecords Method: {0} " + objE.Message);
            }

            finally
            {
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }
    }
}
