﻿using MyTrainingV1311Demo.Core.Dependency;
using MyTrainingV1311Demo.Mobile.MAUI.Services.UI;

namespace MyTrainingV1311Demo.Mobile.MAUI.Shared
{
    public partial class PageHeaderComponent
    {
        protected PageHeaderService PageHeaderService { get; set; }

        public PageHeaderComponent()
        {
            PageHeaderService = DependencyResolver.Resolve<PageHeaderService>();
            PageHeaderService.TitleChanged += (s, e) => StateHasChanged();
            PageHeaderService.HeaderButtonChanged += (s, e) => StateHasChanged();
        }

        public async Task HandleButtonOnClick(HeaderButtonInfo HeaderButtonInfo)
        {
            if (HeaderButtonInfo == null)
            {
                return;
            }

            await HeaderButtonInfo.OnClick();
        }
    }
}
