﻿
using CodeMonkeys.CMS.Public.Shared.Entities;

namespace CodeMonkeys.CMS.Public.Shared.Repository
{
    public interface IPageStatsRepository
    {
        Task<IEnumerable<PageStats>> GetPageStatsAsync();
        Task<int> GetPageVisitsAsync(string pageUrl);
        Task UpdatePageCountAsync(string pageUrl);
    }
}