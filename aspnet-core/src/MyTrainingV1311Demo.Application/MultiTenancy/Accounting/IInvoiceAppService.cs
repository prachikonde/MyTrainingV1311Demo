using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using MyTrainingV1311Demo.MultiTenancy.Accounting.Dto;

namespace MyTrainingV1311Demo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
