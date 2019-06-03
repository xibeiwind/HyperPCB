using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

namespace HyperPCB.Services
{
    /// <summary>
    ///     PinConnection查询服务
    /// </summary>
    public interface IPinConnectionQueryService
    {
        Guid ProcessFlowId { get; set; }

        /// <summary>
        ///     获取PinConnection列表
        /// </summary>
        [Display(Name = "获取PinConnection列表")]
        Task<List<PinConnectionVM>> GetList();

        /// <summary>
        ///     获取PinConnection
        /// </summary>
        [Display(Name = "获取PinConnection")]
        Task<PinConnectionVM> Get(Guid id);

        /// <summary>
        ///     查询PinConnection
        /// </summary>
        [Display(Name = "查询PinConnection")]
        Task<PagingList<PinConnectionVM>> Query(PinConnectionQueryOption option);
    }
}