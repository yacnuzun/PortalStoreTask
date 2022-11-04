using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.SoapService.Abstract
{
    public interface IIdentifyCheckService
    {
        public Task<bool> IsIdentifyCheck(long Identify, string firstName, string lastName, DateTime birthDate);
    }
}
