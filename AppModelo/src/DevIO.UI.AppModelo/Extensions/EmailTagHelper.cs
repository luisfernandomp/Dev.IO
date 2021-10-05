using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.AppModelo.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public string EmailDomain { get; set; } = "desenvolvedor.io";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //Context -> explorado em outras situações
            //Output -> obtém as informações do tagHelper e faz uma devolutiva
            output.TagName = "a";
            var content = await output.GetChildContentAsync(); //Indo buscar o que está no email
            var target = content.GetContent() + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}
