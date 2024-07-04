using System.Threading.Tasks;
using Abp.Dependency;

namespace MyTrainingV1311Demo.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}