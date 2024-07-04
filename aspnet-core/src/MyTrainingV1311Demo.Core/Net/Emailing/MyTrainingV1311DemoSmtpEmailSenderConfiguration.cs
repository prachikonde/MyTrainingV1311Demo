using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace MyTrainingV1311Demo.Net.Emailing
{
    public class MyTrainingV1311DemoSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public MyTrainingV1311DemoSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}