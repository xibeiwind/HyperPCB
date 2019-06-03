using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

namespace HyperPCB.Services
{
    /// <summary>
    ///     PressFlow查询服务
    /// </summary>
    public interface IPressFlowQueryService
    {
        /// <summary>
        ///     获取PressFlow列表
        /// </summary>
        [Display(Name = "获取PressFlow列表")]
        Task<List<PressFlowVM>> GetList();

        /// <summary>
        ///     获取PressFlow
        /// </summary>
        [Display(Name = "获取PressFlow")]
        Task<PressFlowVM> Get(Guid id);

        /// <summary>
        ///     查询PressFlow
        /// </summary>
        [Display(Name = "查询PressFlow")]
        Task<PagingList<PressFlowVM>> Query(PressFlowQueryOption option);
    }
}