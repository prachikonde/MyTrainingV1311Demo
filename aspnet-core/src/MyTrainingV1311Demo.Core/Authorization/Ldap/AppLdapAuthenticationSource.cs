using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using MyTrainingV1311Demo.Authorization.Users;
using MyTrainingV1311Demo.MultiTenancy;

namespace MyTrainingV1311Demo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}