#pragma checksum "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb703be6719e5966b161e91c52758e8c193626e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facilitator_AddVideoContent), @"mvc.1.0.view", @"/Views/Facilitator/AddVideoContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Facilitator/AddVideoContent.cshtml", typeof(AspNetCore.Views_Facilitator_AddVideoContent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb703be6719e5966b161e91c52758e8c193626e2", @"/Views/Facilitator/AddVideoContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d8bf91a5f6a393a315f8b59f4718185ae39203", @"/Views/_ViewImports.cshtml")]
    public class Views_Facilitator_AddVideoContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewSoftlearn.Models.CourseAddVideoContent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
   
    Layout = "_DashboardLayout";

#line default
#line hidden
            BeginContext(96, 157, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"c-h1\">Add Course Topic</h1>\r\n    <div class=\"row mt-4\">\r\n        <div class=\"col-md-8 col-lg-8 mb-3\">\r\n            ");
            EndContext();
            BeginContext(253, 1286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb703be6719e5966b161e91c52758e8c193626e25022", async() => {
                BeginContext(303, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
                 if (ViewBag.Message != null)
                {

#line default
#line hidden
                BeginContext(371, 24, true);
                WriteLiteral("                    <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 395, "\"", 445, 3);
                WriteAttributeValue("", 403, "alert", 403, 5, true);
#line 15 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
WriteAttributeValue(" ", 408, TempData["alert"], 409, 18, false);

#line default
#line hidden
                WriteAttributeValue(" ", 427, "alert-dismissible", 428, 18, true);
                EndWriteAttribute();
                BeginContext(446, 129, true);
                WriteLiteral(">\r\n                        <a class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n                        <strong>");
                EndContext();
                BeginContext(576, 15, false);
#line 17 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
                           Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(591, 39, true);
                WriteLiteral("</strong>\r\n                    </div>\r\n");
                EndContext();
#line 19 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
                }

#line default
#line hidden
                BeginContext(649, 110, true);
                WriteLiteral("                <div class=\"form-group\">\r\n                    <div class=\"col-lg-6\">\r\n                        ");
                EndContext();
                BeginContext(759, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb703be6719e5966b161e91c52758e8c193626e27282", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CourseId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
                                             WriteLiteral(ViewData["courseid"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(831, 164, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"col-lg-6\">\r\n                        ");
                EndContext();
                BeginContext(995, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb703be6719e5966b161e91c52758e8c193626e29968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 27 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CourseTopicId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\AddVideoContent.cshtml"
                                                  WriteLiteral(ViewData["coursetopicid"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1077, 455, true);
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-lg-6"">
                        <label for=""description"">Upload Course Video</label>
                        <input asp type=""file"" name=""materialFile"" class=""form-control"" />
                    </div>
                </div>
                <button class=""btn btn-dark"">Add Course Topic Material</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1539, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewSoftlearn.Models.CourseAddVideoContent> Html { get; private set; }
    }
}
#pragma warning restore 1591
