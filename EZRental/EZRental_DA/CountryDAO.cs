using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EZRental_DA
{
    public class CountryDAO : IUserInterfaceDAO<CountryDTO>
    {
        public List<CountryDTO> GetAllRecords()
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strsql = "Select * from COUNTRY;";

                SqlCommand objCmd = new SqlCommand(strsql, objConn);

                objCmd.CommandType = CommandType.Text;

                SqlDataReader objDR = objCmd.ExecuteReader();

                if (objDR.HasRows)
                {
                    List<CountryDTO> colRecordList = new List<CountryDTO>();

                    while (objDR.Read())
                    {
                        CountryDTO objDTO = new CountryDTO();

                        objDTO.CountryID = objDR.GetByte(0);
                        objDTO.CountryCode2 = objDR.GetString(1);
                        objDTO.CountryCode3 = objDR.GetString(2);
                        objDTO.CountryName = objDR.GetString(3);

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
