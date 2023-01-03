using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EZRental_DA
{
    public class CreditCardDAO : ICreditCardDAO
    {
        public CreditCardDTO GetRecordByID(string key)
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strsql = "Select * from CreditCard where CreditCardNumber = @CreditCardNumber;";
                SqlCommand objCmd = new SqlCommand(strsql, objConn);

                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;

                SqlDataReader objDR = objCmd.ExecuteReader();

                if (objDR.HasRows)
                {
                    CreditCardDTO objDTO = new CreditCardDTO();

                    objDR.Read();

                    objDTO.CreditCardNumber = objDR.GetString(0);
                    objDTO.CreditCardOwnerName = objDR.GetString(1);
                    objDTO.CreditCardIssuingCompany = objDR.GetString(2);
                    objDTO.MerchantCode = objDR.GetByte(3);
                    objDTO.ExpDate = objDR.GetDateTime(4);
                    objDTO.AddressLine1 = objDR.GetString(5);
                    objDTO.AddressLine2 = objDR.GetString(6);
                    objDTO.City = objDR.GetString(7);
                    objDTO.State = objDR.GetString(8);
                    objDTO.ZipCode = objDR.GetString(9);
                    objDTO.Country = objDR.GetString(10);
                    objDTO.CreditCardLimit = objDR.GetDecimal(11);
                    objDTO.CreditCardBalance = objDR.GetDecimal(12);
                    objDTO.ActivationStatus = objDR.GetBoolean(13);

                    return objDTO;
                }

                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;

                return null;
            }

            catch(Exception objE)
            {
                throw new Exception("Unexpected Error in CreditCardADO GetRecordByID(key) Method: {0} " + objE.Message);
            }

            finally
            {
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }

        public bool Insert(CreditCardDTO objDTO)
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strSQL;

                strSQL = "INSERT INTO CreditCard (CreditCardNumber,CreditCardOwnerName,CreditCardIssuingCompany,MerchantCode,ExpDate,";
                strSQL = strSQL + "AddressLine1,AddressLine2,City,StateCode,ZipCode,Country,";
                strSQL = strSQL + "CreditCardBalance,CreditCardLimit,ActivationStatus)";
                strSQL = strSQL + "VALUES(@CreditCardNumber,@CreditCardOwnerName,@CreditCardIssuingCompany,@MerchantCode,@ExpDate,";
                strSQL = strSQL + "@AddressLine1,@AddressLine2,@City,@StateCode,@ZipCode,@Country,";
                strSQL = strSQL + "@CreditCardLimit,@CreditCardBalance,@ActivationStatus);";

                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = objDTO.CreditCardNumber;
                objCmd.Parameters.Add("@CreditCardOwnerName", SqlDbType.VarChar).Value = objDTO.CreditCardOwnerName;
                objCmd.Parameters.Add("@CreditCardIssuingCompany", SqlDbType.VarChar).Value = objDTO.CreditCardIssuingCompany;
                objCmd.Parameters.Add("@MerchantCode", SqlDbType.TinyInt).Value = objDTO.MerchantCode;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.DateTime).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = objDTO.AddressLine1;
                objCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = objDTO.AddressLine2;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.State.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditCardLimit", SqlDbType.Decimal).Value = objDTO.CreditCardLimit;
                objCmd.Parameters.Add("@CreditCardBalance", SqlDbType.Decimal).Value = objDTO.CreditCardBalance;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;

                int intRecordsAffected = objCmd.ExecuteNonQuery();



                if (intRecordsAffected == 1)
                {
                    return true;
                }

                objCmd.Dispose();
                objCmd = null;

                return false;

            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in CreditCardADO Insert(CreditCardDTO objDTO) Method: {0} " + objE.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }

        public bool Update(CreditCardDTO objDTO)
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strSQL;

                strSQL = "UPDATE CreditCard";
                strSQL = strSQL + " SET CreditCardOwnerName=@CreditCardOwnerName,";
                strSQL = strSQL + "CreditCardIssuingCompany=@CreditCardIssuingCompany,";
                strSQL = strSQL + "MerchantCode=@MerchantCode,";
                strSQL = strSQL + "ExpDate=@ExpDate,";
                strSQL = strSQL + "AddressLine1=@AddressLine1,";
                strSQL = strSQL + "AddressLine2=@AddressLine2,";
                strSQL = strSQL + "City=@City,";
                strSQL = strSQL + "StateCode=@State,";
                strSQL = strSQL + "ZipCode=@ZipCode,";
                strSQL = strSQL + "Country=@Country,";
                strSQL = strSQL + "CreditCardLimit=@CreditCardLimit,";
                strSQL = strSQL + "CreditCardBalance=@CreditCardBalance,";
                strSQL = strSQL + "ActivationStatus=@ActivationStatus";
                strSQL = strSQL + " WHERE CreditCardNumber=@CreditCardNumber;";

                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.Add("@CreditCardOwnerName", SqlDbType.VarChar).Value = objDTO.CreditCardOwnerName;
                objCmd.Parameters.Add("@CreditCardIssuingCompany", SqlDbType.VarChar).Value = objDTO.CreditCardIssuingCompany;
                objCmd.Parameters.Add("@MerchantCode", SqlDbType.TinyInt).Value = objDTO.MerchantCode;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.VarChar).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = objDTO.AddressLine1;
                objCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = objDTO.AddressLine2;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@State", SqlDbType.Char).Value = objDTO.State.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditCardLimit", SqlDbType.Decimal).Value = objDTO.CreditCardLimit;
                objCmd.Parameters.Add("@CreditCardBalance", SqlDbType.Decimal).Value = objDTO.CreditCardBalance;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = objDTO.CreditCardNumber;


                int intRecordsAffected = objCmd.ExecuteNonQuery();



                if (intRecordsAffected == 1)
                {
                    return true;
                }

                objCmd.Dispose();
                objCmd = null;

                return false;

            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in CreditCardADO Update(CreditCardDTO objDTO) Method: {0} " + objE.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }

        public bool Delete(string key)
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strSQL = "DELETE FROM CreditCard WHERE CreditCardNumber = @CreditCardNumber;";


                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;


                int intRecordsAffected = objCmd.ExecuteNonQuery();



                if (intRecordsAffected == 1)
                {
                    return true;
                }

                objCmd.Dispose();
                objCmd = null;

                return false;

            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in CreditCardADO Delete(key) Method: {0} " + objE.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }

        public List<CreditCardDTO> GetAllRecords()
        {

            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strSQL = "SELECT * FROM CreditCard;";

                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                objCmd.CommandType = CommandType.Text;


                SqlDataReader objDR = objCmd.ExecuteReader();

                if (objDR.HasRows)
                {
                    List<CreditCardDTO> colRecordList = new List<CreditCardDTO>();

                    while (objDR.Read())
                    {
                        CreditCardDTO objDTO = new CreditCardDTO();

                        objDTO.CreditCardNumber = objDR.GetString(0);
                        objDTO.CreditCardOwnerName = objDR.GetString(1);
                        objDTO.CreditCardIssuingCompany = objDR.GetString(2);
                        objDTO.MerchantCode = objDR.GetByte(3);
                        objDTO.ExpDate = objDR.GetDateTime(4);
                        objDTO.AddressLine1 = objDR.GetString(5);
                        objDTO.AddressLine2 = objDR.GetString(6);
                        objDTO.City = objDR.GetString(7);
                        objDTO.State = objDR.GetString(8);
                        objDTO.ZipCode = objDR.GetString(9);
                        objDTO.Country = objDR.GetString(10);
                        objDTO.CreditCardLimit = objDR.GetDecimal(11);
                        objDTO.CreditCardBalance = objDR.GetDecimal(12);
                        objDTO.ActivationStatus = objDR.GetBoolean(13);

                        colRecordList.Add(objDTO);

                    }

                    return colRecordList;
                }
                else
                {
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;

                    return null;

                }
            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in CreditCardADO GetAllRecords() Method: {0} " + objE.Message);
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
