#pragma checksum "C:\Users\techworks1\source\repos\lab2\lab2\Views\Messages\ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30fee9d07b8310995513fe1be637d990031cd126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_ShowMessage), @"mvc.1.0.view", @"/Views/Messages/ShowMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/ShowMessage.cshtml", typeof(AspNetCore.Views_Messages_ShowMessage))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30fee9d07b8310995513fe1be637d990031cd126", @"/Views/Messages/ShowMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_ShowMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\techworks1\source\repos\lab2\lab2\Views\Messages\ShowMessage.cshtml"
  
    ViewData["Title"] = "ShowMessage";

#line default
#line hidden
            BeginContext(51, 27, true);
            WriteLiteral("\r\n\r\n<h1 class=\"title is-1\">");
            EndContext();
            BeginContext(79, 19, false);
#line 8 "C:\Users\techworks1\source\repos\lab2\lab2\Views\Messages\ShowMessage.cshtml"
                  Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(98, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
