using Abp.Domain.Services;

namespace MyTrainingV1311Demo
{
    public abstract class MyTrainingV1311DemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected MyTrainingV1311DemoDomainServiceBase()
        {
            LocalizationSourceName = MyTrainingV1311DemoConsts.LocalizationSourceName;
        }
    }
}
