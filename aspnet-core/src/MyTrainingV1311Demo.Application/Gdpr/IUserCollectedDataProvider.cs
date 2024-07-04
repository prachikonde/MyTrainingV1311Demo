using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
