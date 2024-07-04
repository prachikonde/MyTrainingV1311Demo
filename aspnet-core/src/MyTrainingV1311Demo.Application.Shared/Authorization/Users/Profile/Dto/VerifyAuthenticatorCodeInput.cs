namespace MyTrainingV1311Demo.Authorization.Users.Profile.Dto
{
    public class VerifyAuthenticatorCodeInput
    {
        public string Code { get; set; }
        public string GoogleAuthenticatorKey { get; set; }
    }
}