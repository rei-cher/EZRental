using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZRental_DA
{
    class SQLServerDAOFactory : DALObjectFactoryBase
    {
        public static string ConnectionString()
        {
            return "Data Source = .\\SQLExpress; Initial Catalog = EZRentalDB; Integrated Security = True";
        }

        public override CreditCardDAO GetCreditCardDAO()
        {
            return new CreditCardDAO();
        }
        public override USStateDAO GetUSStateDAO()
        {
            return new USStateDAO();
        }

        public override CountryDAO GetCountryDAO()
        {
            return new CountryDAO();
        }

    }
}
