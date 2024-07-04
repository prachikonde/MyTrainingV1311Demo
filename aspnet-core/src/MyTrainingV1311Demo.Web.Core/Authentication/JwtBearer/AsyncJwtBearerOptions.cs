using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace MyTrainingV1311Demo.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly MyTrainingV1311DemoAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new MyTrainingV1311DemoAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
