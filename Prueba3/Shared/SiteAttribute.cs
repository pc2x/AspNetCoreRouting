using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Prueba3.Shared
{
    /// <inheritdoc />
    /// <summary>  
    /// this is simillar to this https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Core/AreaAttribute.cs  
    /// </summary>  
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class SiteAttribute : RouteValueAttribute
    {
        public SiteAttribute(string name)
            : base("site", name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("site name cannot be null or empty", nameof(name));
            }
        }
    }
}
