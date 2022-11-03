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
        bool IsIdentifyCheck(int Identify, string firstName, string lastName, DateTime birthDate);
    }
}
