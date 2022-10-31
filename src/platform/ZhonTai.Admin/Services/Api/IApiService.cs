﻿using ZhonTai.Admin.Core.Dto;
using System.Threading.Tasks;
using ZhonTai.Admin.Services.Api.Dto;
using ZhonTai.Admin.Domain.Api.Dto;
using System.Collections.Generic;
using ZhonTai.Admin.Domain.Api;

namespace ZhonTai.Admin.Services.Api;

/// <summary>
/// api接口
/// </summary>
public interface IApiService
{
    Task<ApiGetOutput> GetAsync(long id);

    Task<List<ApiListOutput>> GetListAsync(string key);

    Task<PageOutput<ApiEntity>> GetPageAsync(PageInput<ApiGetPageDto> input);

    Task<long> AddAsync(ApiAddInput input);

    Task UpdateAsync(ApiUpdateInput input);

    Task<IResultOutput> DeleteAsync(long id);

    Task<IResultOutput> SoftDeleteAsync(long id);

    Task<IResultOutput> BatchSoftDeleteAsync(long[] ids);

    Task<IResultOutput> SyncAsync(ApiSyncInput input);
}