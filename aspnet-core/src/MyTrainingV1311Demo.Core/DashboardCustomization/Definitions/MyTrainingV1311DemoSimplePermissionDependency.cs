using System.Threading.Tasks;
using Abp.Authorization;

// TODO: Remove this class when we upgrade to ABP 8.4.1
namespace MyTrainingV1311Demo.DashboardCustomization.Definitions
{
    
/// <summary>
/// Most simple implementation of <see cref="IPermissionDependency"/>.
/// It checks one or more permissions if they are granted.
/// </summary>
public class MyTrainingV1311DemoSimplePermissionDependency : IPermissionDependency
{
    /// <summary>
    /// A list of permissions to be checked if they are granted.
    /// </summary>
    public string[] Permissions { get; set; }

    /// <summary>
    /// If this property is set to true, all of the <see cref="Permissions"/> must be granted.
    /// If it's false, at least one of the <see cref="Permissions"/> must be granted.
    /// Default: false.
    /// </summary>
    public bool RequiresAll { get; set; }

    /// <summary>
    /// Needed for serialization.
    /// </summary>
    public MyTrainingV1311DemoSimplePermissionDependency()
    {
            
    }
        
    /// <summary>
    /// Initializes a new instance of the <see cref="SimplePermissionDependency"/> class.
    /// </summary>
    /// <param name="permissions">The permissions.</param>
    public MyTrainingV1311DemoSimplePermissionDependency(params string[] permissions)
    {
        Permissions = permissions;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SimplePermissionDependency"/> class.
    /// </summary>
    /// <param name="requiresAll">
    /// If this is set to true, all of the <see cref="Permissions"/> must be granted.
    /// If it's false, at least one of the <see cref="Permissions"/> must be granted.
    /// </param>
    /// <param name="permissions">The permissions.</param>
    public MyTrainingV1311DemoSimplePermissionDependency(bool requiresAll, params string[] permissions)
        : this(permissions)
    {
        RequiresAll = requiresAll;
    }

    /// <inheritdoc/>
    public Task<bool> IsSatisfiedAsync(IPermissionDependencyContext context)
    {
        return context.User != null
            ? context.PermissionChecker.IsGrantedAsync(context.User, RequiresAll, Permissions)
            : context.PermissionChecker.IsGrantedAsync(RequiresAll, Permissions);
    }

    /// <inheritdoc/>
    public bool IsSatisfied(IPermissionDependencyContext context)
    {
        return context.User != null
            ? context.PermissionChecker.IsGranted(context.User, RequiresAll, Permissions)
            : context.PermissionChecker.IsGranted(RequiresAll, Permissions);
    }
}
}