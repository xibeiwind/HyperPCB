using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using HyperPCB.Core;
using Yunyong.Core;
using Yunyong.Core.ViewModels;

namespace HyperPCB.Services
{
    public interface IPinQueryService
    {
        /// <summary>
        ///     当前PressFlowId
        /// </summary>
        [Display(Name = "当前PressFlowId")]
        Guid ProcessFlowId { get; set; }

        void Register(IPin pin);
        void UnRegister(IPin pin);
        IEnumerable<IPin> FindByResource<TResource>();
        IEnumerable<IPin> Find(Func<IPin, bool> predicate);
    }

    /// <summary>
    ///     PinConnection操作服务
    /// </summary>
    public interface IPinConnectionActionService
    {
        /// <summary>
        ///     当前PressFlowId
        /// </summary>
        [Display(Name = "当前PressFlowId")]
        Guid ProcessFlowId { get; set; }

        /// <summary>
        ///     创建PinConnection
        /// </summary>
        [Display(Name = "创建PinConnection")]
        Task<AsyncTaskTResult<PinConnectionVM>> CreateAsync(CreatePinConnectionVM vm);

        /// <summary>
        ///     更新PinConnection
        /// </summary>
        [Display(Name = "更新PinConnection")]
        Task<AsyncTaskTResult<PinConnectionVM>> UpdateAsync(UpdatePinConnectionVM vm);

        /// <summary>
        ///     删除PinConnection
        /// </summary>
        [Display(Name = "删除PinConnection")]
        Task<AsyncTaskResult> DeleteAsync(DeletePinConnectionVM vm);
    }

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

    /// <summary>
    ///     引脚连接
    /// </summary>
    [Display(Name = "引脚连接")]
    public class PinConnectionVM : VMBase
    {
    }

    /// <summary>
    ///     创建引脚连接
    /// </summary>
    [Display(Name = "创建引脚连接")]
    public class CreatePinConnectionVM : CreateVM
    {
    }

    /// <summary>
    ///     更新引脚连接
    /// </summary>
    [Display(Name = "更新引脚连接")]
    public class UpdatePinConnectionVM : UpdateVM
    {
    }

    /// <summary>
    ///     删除引脚连接
    /// </summary>
    [Display(Name = "删除引脚连接")]
    public class DeletePinConnectionVM : DeleteVM
    {
    }

    /// <summary>
    ///     查询引脚连接
    /// </summary>
    [Display(Name = "查询引脚连接")]
    public class PinConnectionQueryOption : PagingQueryOption
    {
    }
}