using System;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTrainingV1311Demo.Notifications;

namespace MyTrainingV1311Demo.Web.Controllers;

public class BrowserCacheCleanerController : MyTrainingV1311DemoControllerBase
{
    private readonly INotificationAppService _notificationAppService;

    public BrowserCacheCleanerController(INotificationAppService notificationAppService)
    {
        _notificationAppService = notificationAppService;
    }
    
    public async Task<IActionResult> Clear()
    {
        var result = await _notificationAppService.SetAllAvailableVersionNotificationAsRead();
        
        HttpContext.Response.Headers.Append("Clear-Site-Data", "\"cache\"");

        return Json(new {Result = result});
    }
}