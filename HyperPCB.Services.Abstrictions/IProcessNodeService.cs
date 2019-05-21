using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yunyong.Core;
using Yunyong.Core.ViewModels;

namespace HyperPCB.Services
{
    /// <summary>
    ///     IProcessNode操作服务
    /// </summary>
    public interface IProcessNodeActionService
    {
        /// <summary>
        ///     创建IProcessNode
        /// </summary>
        [Display(Name = "创建IProcessNode")]
        Task<AsyncTaskTResult<ProcessNodeVM>> CreateAsync(CreateProcessNodeVM vm);
        /// <summary>
        ///     更新IProcessNode
        /// </summary>
        [Display(Name = "更新IProcessNode")]
        Task<AsyncTaskTResult<ProcessNodeVM>> UpdateAsync(UpdateProcessNodeVM vm);
        /// <summary>
        ///     删除IProcessNode
        /// </summary>
        [Display(Name = "删除IProcessNode")]
        Task<AsyncTaskResult> DeleteAsync(DeleteProcessNodeVM vm);



    }
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

    /// <summary>
    ///     ProcessNode
    /// </summary>
    [Display(Name = "ProcessNode")]
    public class ProcessNodeVM : VMBase
    {

    }
    /// <summary>
    ///     创建ProcessNode
    /// </summary>
    [Display(Name = "创建ProcessNode")]
    public class CreateProcessNodeVM : CreateVM
    {

    }
    /// <summary>
    ///     更新ProcessNode
    /// </summary>
    [Display(Name = "更新ProcessNode")]
    public class UpdateProcessNodeVM : UpdateVM
    {

    }
    /// <summary>
    ///     删除ProcessNode
    /// </summary>
    [Display(Name = "删除ProcessNode")]
    public class DeleteProcessNodeVM : DeleteVM
    {

    }
    /// <summary>
    ///     查询ProcessNode
    /// </summary>
    [Display(Name = "查询ProcessNode")]
    public class ProcessNodeQueryOption : PagingQueryOption
    {

    }
}
