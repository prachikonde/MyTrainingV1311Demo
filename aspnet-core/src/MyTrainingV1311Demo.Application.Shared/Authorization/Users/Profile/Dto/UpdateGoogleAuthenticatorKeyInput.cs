using System.Collections.Generic;

namespace MyTrainingV1311Demo.Authorization.Users.Profile.Dto
{
    public class UpdateGoogleAuthenticatorKeyInput
    {
        public string GoogleAuthenticatorKey { get; set; }
        public string AuthenticatorCode { get; set; }
    }
}
