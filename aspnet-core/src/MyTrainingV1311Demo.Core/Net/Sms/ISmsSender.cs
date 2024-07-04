using System.Threading.Tasks;

namespace MyTrainingV1311Demo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}