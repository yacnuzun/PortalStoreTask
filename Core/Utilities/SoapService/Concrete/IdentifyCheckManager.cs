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

        

        public async Task<bool> IsIdentifyCheck(long Identify,string firstName,string lastName,DateTime birthDate)
        {
            Service.KPSPublicSoapClient _client = new Service.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result= await _client.TCKimlikNoDogrulaAsync(Identify, firstName, lastName, birthDate.Year);
            var responce=result.Body.TCKimlikNoDogrulaResult;

            return responce;
        }
    }
}
