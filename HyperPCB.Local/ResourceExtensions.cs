using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HyperPCB.Core;

namespace HyperPCB.Local
{
    public static class ResourceExtensions
    {
        public static IProcessNodeOutput<TResource> ToOutput<TResource>(this TResource resource) where TResource : IResource
        {
            return new ProcessNodeOutput<TResource>(resource);
        }

        public static IProcessNodeInput<TResource> ToInput<TResource>(this TResource resource)
            where TResource : IResource
        {
            return new ProcessNodeOutput<TResource>(resource);
        }
    }
}
