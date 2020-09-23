#pragma checksum "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\ViewCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbdd368d0cf2bb3e8a9dabd2ffbc156eb7518620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facilitator_ViewCourse), @"mvc.1.0.view", @"/Views/Facilitator/ViewCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Facilitator/ViewCourse.cshtml", typeof(AspNetCore.Views_Facilitator_ViewCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbdd368d0cf2bb3e8a9dabd2ffbc156eb7518620", @"/Views/Facilitator/ViewCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d8bf91a5f6a393a315f8b59f4718185ae39203", @"/Views/_ViewImports.cshtml")]
    public class Views_Facilitator_ViewCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Facilitator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Facilitator\ViewCourse.cshtml"
   
    Layout = "_TeacherLayout";

#line default
#line hidden
            BeginContext(40, 100, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"d-flex\">\r\n        <h1 class=\"c-h1\">Courses</h1>\r\n        ");
            EndContext();
            BeginContext(140, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbdd368d0cf2bb3e8a9dabd2ffbc156eb75186204522", async() => {
                BeginContext(226, 38, true);
                WriteLiteral("New Course <i class=\"fas fa-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(268, 5065, true);
            WriteLiteral(@"
    </div>
    <div class=""row mt-5"">
        <div class=""col-lg-4 col-md-6"">
            <div class=""card"">
                <figure>
                    <img class=""card-img-top"" src=""../assets/img/courses/angularjs.jpg"" alt=""Angular"">
                    <figcaption class=""project-description-overlay"">
                        <a href=""#"" role=""button"" class=""text-white"" data-toggle=""modal"" data-target=""#courseDescriptionModal""><i class=""fas fa-pencil-alt""></i> &nbsp;Edit</a>
                    </figcaption>
                </figure>
                <div class=""card-body card-body-courses"">
                    <div class=""d-flex"">
                        <p>Angular JS</p>
                        <p class=""ml-auto""><i class=""fas fa-pencil-alt""></i></span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6 mb-3"">
            <div class=""card"">
                <figure>
                    <img class=""card-img-top"" src");
            WriteLiteral(@"=""../assets/img/courses/photoshop.jpg"" alt=""Photoshop"">
                    <figcaption class=""project-description-overlay"">
                        <a href=""#"" role=""button"" class=""text-white"" data-toggle=""modal"" data-target=""#courseDescriptionModal""><i class=""fas fa-pencil-alt""></i> &nbsp;Edit</a>
                    </figcaption>
                </figure>
                <div class=""card-body card-body-courses"">
                    <div class=""d-flex"">
                        <p>Photoshop</p>
                        <p class=""ml-auto""><i class=""fas fa-pencil-alt""></i></span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6 mb-3"">
            <div class=""card"">
                <figure>
                    <img class=""card-img-top"" src=""../assets/img/courses/reactjs.jpg"" alt=""React JS"">
                    <figcaption class=""project-description-overlay"">
                        <a href=""#"" role=""button"" class=""text-whi");
            WriteLiteral(@"te"" data-toggle=""modal"" data-target=""#courseDescriptionModal""><i class=""fas fa-pencil-alt""></i> &nbsp;Edit</a>
                    </figcaption>
                </figure>
                <div class=""card-body card-body-courses"">
                    <div class=""d-flex"">
                        <p>React JS</p>
                        <p class=""ml-auto""><i class=""fas fa-pencil-alt""></i></span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6 mb-3"">
            <div class=""card"">
                <figure>
                    <img class=""card-img-top"" src=""../assets/img/courses/webdesign.jpg"" alt=""Web Design"">
                    <figcaption class=""project-description-overlay"">
                        <a href=""#"" role=""button"" class=""text-white"" data-toggle=""modal"" data-target=""#courseDescriptionModal""><i class=""fas fa-pencil-alt""></i> &nbsp;Edit</a>
                    </figcaption>
                </figure>
               ");
            WriteLiteral(@" <div class=""card-body card-body-courses"">
                    <div class=""d-flex"">
                        <p>Web Design</p>
                        <p class=""ml-auto""><i class=""fas fa-pencil-alt""></i></span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6 mb-3"">
            <div class=""card"">
                <figure>
                    <img class=""card-img-top"" src=""../assets/img/courses/wordpress.jpg"" alt=""Wordpress"">
                    <figcaption class=""project-description-overlay"">
                        <a href=""#"" role=""button"" class=""text-white"" data-toggle=""modal"" data-target=""#courseDescriptionModal""><i class=""fas fa-pencil-alt""></i> &nbsp;Edit</a>
                    </figcaption>
                </figure>
                <div class=""card-body card-body-courses"">
                    <div class=""d-flex"">
                        <p>Wordpress</p>
                        <p class=""ml-auto""><i class=""fas fa-");
            WriteLiteral(@"pencil-alt""></i></span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6 mb-3"">
            <div class=""card"">
                <figure>
                    <img class=""card-img-top"" src=""../assets/img/courses/javascript.jpg"" alt=""JavaScript"">
                    <figcaption class=""project-description-overlay"">
                        <a href=""#"" role=""button"" class=""text-white"" data-toggle=""modal"" data-target=""#courseDescriptionModal""><i class=""fas fa-pencil-alt""></i> &nbsp;Edit</a>
                    </figcaption>
                </figure>
                <div class=""card-body card-body-courses"">
                    <div class=""d-flex"">
                        <p>JavaScript</p>
                        <p class=""ml-auto""><i class=""fas fa-pencil-alt""></i></span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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