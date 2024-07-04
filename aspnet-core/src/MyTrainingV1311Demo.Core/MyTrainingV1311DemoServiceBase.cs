using Abp;

namespace MyTrainingV1311Demo
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="MyTrainingV1311DemoDomainServiceBase"/>.
    /// For application services inherit MyTrainingV1311DemoAppServiceBase.
    /// </summary>
    public abstract class MyTrainingV1311DemoServiceBase : AbpServiceBase
    {
        protected MyTrainingV1311DemoServiceBase()
        {
            LocalizationSourceName = MyTrainingV1311DemoConsts.LocalizationSourceName;
        }
    }
}