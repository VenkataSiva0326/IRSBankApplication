using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Application.Common.Interfaces.Persistence
{
    public interface IDispositionRepository
    {
        Task<int?> GetCustomerIdFromDisposition(Guid userId);
    }
}
