using System;
using Abp.Authorization;
using Abp.Runtime.Validation;
using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.Authorization.Users.Dto
{
    public class GetLoginAttemptsInput: PagedAndSortedInputDto, IGetLoginAttemptsInput, IShouldNormalize
    {
        public string Filter { get; set; }
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public AbpLoginResultType? Result { get; set; }
        
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "CreationTime DESC";
            }

            Filter = Filter?.Trim();
        }
    }
}
