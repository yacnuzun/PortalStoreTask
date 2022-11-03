using Core.Utilities.SoapService.Abstract;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Core.Utilities.SoapService.Concrete
{
    public class IdentifyCheckManager:IIdentifyCheckService
    {

        KPSPublicSoapClient _client;

        public IdentifyCheckManager(KPSPublicSoapClient client)
        {
            _client = client;
        }

        public bool IsIdentifyCheck(int Identify,string firstName,string lastName,DateTime birthDate)
        {

            var result= _client.TCKimlikNoDogrulaAsync(Identify, firstName, lastName, Convert.ToInt32(birthDate));
            if (result.IsCompletedSuccessfully == true)
            {
                return true;
            }
            return false;
        }
    }
}
