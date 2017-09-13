using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Prueba3.Shared.TagHelper
{
    [HtmlTargetElement("a", Attributes = "asp-area")]
    public class AreaTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    { 
        [HtmlAttributeName("asp-area")]
        public string AspArea { get; set; }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //// base.Process(context, output);
            //var site = ViewContext.HttpContext.Request.Path.Value.Split('/')[1];

            //if (output.Attributes.ContainsName("href"))
            //{
            //    output.Attributes.Remove(output.Attributes["href"]);
            //    output.Attributes.Add("href", 
            //        $"/{site}/{context.AllAttributes["asp-area"].Value}/" +
            //        $"{context.AllAttributes["asp-controller"].Value}/" +
            //        $"{context.AllAttributes["asp-action"].Value}");
            //}
                

        }
    }
}
