using MyTrainingV1311Demo.Models.NavigationMenu;

namespace MyTrainingV1311Demo.Services.Navigation
{
    public interface IMenuProvider
    {
        List<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}