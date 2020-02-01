using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HyperPCB.Core;

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
}