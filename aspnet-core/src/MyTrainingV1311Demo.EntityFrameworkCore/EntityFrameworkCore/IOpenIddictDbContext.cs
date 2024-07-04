using Microsoft.EntityFrameworkCore;
using MyTrainingV1311Demo.OpenIddict.Applications;
using MyTrainingV1311Demo.OpenIddict.Authorizations;
using MyTrainingV1311Demo.OpenIddict.Scopes;
using MyTrainingV1311Demo.OpenIddict.Tokens;

namespace MyTrainingV1311Demo.EntityFrameworkCore
{
    public interface IOpenIddictDbContext
    {
        DbSet<OpenIddictApplication> Applications { get; }

        DbSet<OpenIddictAuthorization> Authorizations { get; }

        DbSet<OpenIddictScope> Scopes { get; }

        DbSet<OpenIddictToken> Tokens { get; }
    }

}