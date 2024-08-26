﻿using CodeMonkeys.CMS.Public.Shared.Entities;

namespace CodeMonkeys.CMS.Public.Shared.Services
{
    public class WebPageService : IWebPageService
    {
        public WebPageService(IWebPageRepository repository)
        {
            Repository = repository;
        }

        public IWebPageRepository Repository { get; }

        public async Task CreateWebPageAsync(WebPage webPage)
        {
            await Repository.CreateWebPageAsync(webPage);
        }
        public async Task<IEnumerable<WebPage>> GetSiteWebPagesAsync(int siteId, int pageIndex = 0, int pageSize = 10)
        {
            if (pageIndex < 0) throw new ArgumentOutOfRangeException("PageIndex must be a positive number.");
            if (pageSize <= 0) throw new ArgumentOutOfRangeException("PageSize must be greater than zero.");

            return await Repository.GetSiteWebPagesAsync(siteId, pageIndex, pageSize);
        }
    }
}