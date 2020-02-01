using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

namespace HyperPCB.Services
{
    /// <summary>
    ///     IProcessNode查询服务
    /// </summary>
    public interface IProcessNodeQueryService
    {
        /// <summary>
        ///     获取IProcessNode列表
        /// </summary>
        [Display(Name = "获取IProcessNode列表")]
        Task<List<ProcessNodeVM>> GetList();

        /// <summary>
        ///     获取IProcessNode
        /// </summary>
        [Display(Name = "获取IProcessNode")]
        Task<ProcessNodeVM> Get(Guid id);

        /// <summary>
        ///     查询IProcessNode
        /// </summary>
        [Display(Name = "查询IProcessNode")]
        Task<PagingList<ProcessNodeVM>> Query(ProcessNodeQueryOption option);
    }
}