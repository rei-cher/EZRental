using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZRental_DA
{
    public abstract class DALObjectFactoryBase
    {
        public const int SQLSERVER = 1;
        public const int ORACLE = 2;
        public const int MYSQL = 3;

        public static DALObjectFactoryBase GetDataSourceDAOFactory(int targetDataSourceFactory)
        {
            switch (targetDataSourceFactory)
            {
                case 1:
                    return new SQLServerDAOFactory();
                case 2:
                    throw new NotImplementedException();
                case 3:
                    throw new NotImplementedException();
                default:
                    return null;
            }
        }

        public abstract CreditCardDAO GetCreditCardDAO();
        public abstract USStateDAO GetUSStateDAO();
        public abstract CountryDAO GetCountryDAO();
    }
}
