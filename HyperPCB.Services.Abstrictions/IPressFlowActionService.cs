using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

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
}