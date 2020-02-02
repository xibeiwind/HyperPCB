using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;

namespace HyperPCB.Services
{
    /// <summary>
    ///     Plugin操作服务
    /// </summary>
    public interface IPluginActionService
    {
        /// <summary>
        ///     创建Plugin
        /// </summary>
        [Display(Name = "创建Plugin")]
        Task<AsyncTaskTResult<PluginVM>> CreateAsync(CreatePluginVM vm);

        /// <summary>
        ///     更新Plugin
        /// </summary>
        [Display(Name = "更新Plugin")]
        Task<AsyncTaskTResult<PluginVM>> UpdateAsync(UpdatePluginVM vm);

        /// <summary>
        ///     删除Plugin
        /// </summary>
        [Display(Name = "删除Plugin")]
        Task<AsyncTaskResult> DeleteAsync(DeletePluginVM vm);
    }
}