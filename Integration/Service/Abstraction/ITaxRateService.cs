using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Service.Abstraction
{
    public interface ITaxRateService
    {
        Task<decimal> GetTaxRateByZipCodeAsync(string zipCode);
    }
}
