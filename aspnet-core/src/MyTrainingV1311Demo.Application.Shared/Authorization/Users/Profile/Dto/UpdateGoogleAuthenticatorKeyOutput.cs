using System.Collections.Generic;

namespace MyTrainingV1311Demo.Authorization.Users.Profile.Dto
{
    public class UpdateGoogleAuthenticatorKeyOutput
    {
        public IEnumerable<string> RecoveryCodes { get; set; }
    }
}
