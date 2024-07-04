﻿using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyTrainingV1311Demo
{
    public class MyTrainingV1311DemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTrainingV1311DemoClientModule).GetAssembly());
        }
    }
}