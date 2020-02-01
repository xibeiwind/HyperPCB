using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

namespace HyperPCB.Services
{
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
}