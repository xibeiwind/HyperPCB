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
    ///     PressFlow操作服务
    /// </summary>
    public interface IPressFlowActionService
    {
        /// <summary>
        ///     创建PressFlow
        /// </summary>
        [Display(Name = "创建PressFlow")]
        Task<AsyncTaskTResult<PressFlowVM>> CreateAsync(CreatePressFlowVM vm);
        /// <summary>
        ///     更新PressFlow
        /// </summary>
        [Display(Name = "更新PressFlow")]
        Task<AsyncTaskTResult<PressFlowVM>> UpdateAsync(UpdatePressFlowVM vm);
        /// <summary>
        ///     删除PressFlow
        /// </summary>
        [Display(Name = "删除PressFlow")]
        Task<AsyncTaskResult> DeleteAsync(DeletePressFlowVM vm);



    }
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

    /// <summary>
    ///     PressFlow
    /// </summary>
    [Display(Name = "PressFlow")]
    public class PressFlowVM : VMBase
    {

    }
    /// <summary>
    ///     创建PressFlow
    /// </summary>
    [Display(Name = "创建PressFlow")]
    public class CreatePressFlowVM : CreateVM
    {

    }
    /// <summary>
    ///     更新PressFlow
    /// </summary>
    [Display(Name = "更新PressFlow")]
    public class UpdatePressFlowVM : UpdateVM
    {

    }
    /// <summary>
    ///     删除PressFlow
    /// </summary>
    [Display(Name = "删除PressFlow")]
    public class DeletePressFlowVM : DeleteVM
    {

    }
    /// <summary>
    ///     查询PressFlow
    /// </summary>
    [Display(Name = "查询PressFlow")]
    public class PressFlowQueryOption : PagingQueryOption
    {

    }
}
