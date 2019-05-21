using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Yunyong.Core;
using Yunyong.Core.ViewModels;

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
    /// <summary>
    ///     Plugin查询服务
    /// </summary>
    public interface IPluginQueryService
    {
        /// <summary>
        ///     获取Plugin列表
        /// </summary>  
        [Display(Name = "获取Plugin列表")]
        Task<List<PluginVM>> GetList();
        /// <summary>
        ///     获取Plugin
        /// </summary>
        [Display(Name = "获取Plugin")]
        Task<PluginVM> Get(Guid id);
        /// <summary>
        ///     查询Plugin
        /// </summary>
        [Display(Name = "查询Plugin")]
        Task<PagingList<PluginVM>> Query(PluginQueryOption option);
    }

    /// <summary>
    ///     Plugin
    /// </summary>
    [Display(Name = "Plugin")]
    public class PluginVM : VMBase
    {

    }
    /// <summary>
    ///     创建Plugin
    /// </summary>
    [Display(Name = "创建Plugin")]
    public class CreatePluginVM : CreateVM
    {

    }
    /// <summary>
    ///     更新Plugin
    /// </summary>
    [Display(Name = "更新Plugin")]
    public class UpdatePluginVM : UpdateVM
    {

    }
    /// <summary>
    ///     删除Plugin
    /// </summary>
    [Display(Name = "删除Plugin")]
    public class DeletePluginVM : DeleteVM
    {

    }
    /// <summary>
    ///     查询Plugin
    /// </summary>
    [Display(Name = "查询Plugin")]
    public class PluginQueryOption : PagingQueryOption
    {

    }
}
