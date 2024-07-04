using Abp.Application.Services.Dto;

namespace MyTrainingV1311Demo.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}