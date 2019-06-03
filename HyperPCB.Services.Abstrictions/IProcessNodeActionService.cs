using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

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
}