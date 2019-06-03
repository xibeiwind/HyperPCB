using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

namespace HyperPCB.Services
{
    /// <summary>
    ///     Plugin查询服务
    /// </summary>
    public interface IPluginQueryService
    {
        /// <summary>
        ///     获取Plugin列表
        /// </summary>
        [Display(Name = "获取Plugin列表")]
        Task<List<PluginVM>> GetList();

        /// <summary>
        ///     获取Plugin
        /// </summary>
        [Display(Name = "获取Plugin")]
        Task<PluginVM> Get(Guid id);

        /// <summary>
        ///     查询Plugin
        /// </summary>
        [Display(Name = "查询Plugin")]
        Task<PagingList<PluginVM>> Query(PluginQueryOption option);
    }
}