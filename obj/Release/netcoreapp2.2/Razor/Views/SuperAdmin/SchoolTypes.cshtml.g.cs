#pragma checksum "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\SuperAdmin\SchoolTypes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "899d13dea0a0497ea31040c29a94cbee8cbdd956"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_SchoolTypes), @"mvc.1.0.view", @"/Views/SuperAdmin/SchoolTypes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/SchoolTypes.cshtml", typeof(AspNetCore.Views_SuperAdmin_SchoolTypes))]
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
#line 1 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\_ViewImports.cshtml"
using SoftLearnFrontEnd;

#line default
#line hidden
#line 2 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\_ViewImports.cshtml"
using SoftLearnFrontEnd.Models;

#line default
#line hidden
#line 8 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\SuperAdmin\SchoolTypes.cshtml"
using SoftLearnFrontEnd.ResponseModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899d13dea0a0497ea31040c29a94cbee8cbdd956", @"/Views/SuperAdmin/SchoolTypes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d8bf91a5f6a393a315f8b59f4718185ae39203", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_SchoolTypes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolTypes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\SuperAdmin\SchoolTypes.cshtml"
  
    ViewData["Title"] = "School Types";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(120, 240, true);
            WriteLiteral("\r\n\r\n<h2>All School Types From Softlearn API</h2>\r\n\r\n<table class=\"table table-sm table-striped table-bordered m-2\">\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Name</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\SuperAdmin\SchoolTypes.cshtml"
         foreach (var r in Model.Data)
        {

#line default
#line hidden
            BeginContext(411, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(450, 4, false);
#line 27 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\SuperAdmin\SchoolTypes.cshtml"
               Write(r.Id);

#line default
#line hidden
            EndContext();
            BeginContext(454, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(482, 16, false);
#line 28 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\SuperAdmin\SchoolTypes.cshtml"
               Write(r.SchoolTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(498, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\SuperAdmin\SchoolTypes.cshtml"
        }

#line default
#line hidden
            BeginContext(537, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolTypes> Html { get; private set; }
    }
}
#pragma warning restore 1591