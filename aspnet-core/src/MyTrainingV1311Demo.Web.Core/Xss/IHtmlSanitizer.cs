using Abp.Dependency;

namespace MyTrainingV1311Demo.Web.Xss
{
    public interface IHtmlSanitizer: ITransientDependency
    {
        string Sanitize(string html);
    }
}