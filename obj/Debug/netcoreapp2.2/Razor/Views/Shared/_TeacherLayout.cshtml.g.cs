#pragma checksum "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Shared\_TeacherLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfaa4104bdf74cf3dde75dc09f830dd31391f4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TeacherLayout), @"mvc.1.0.view", @"/Views/Shared/_TeacherLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TeacherLayout.cshtml", typeof(AspNetCore.Views_Shared__TeacherLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfaa4104bdf74cf3dde75dc09f830dd31391f4ad", @"/Views/Shared/_TeacherLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d8bf91a5f6a393a315f8b59f4718185ae39203", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TeacherLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n    \r\n");
            EndContext();
            BeginContext(35, 1339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfaa4104bdf74cf3dde75dc09f830dd31391f4ad3448", async() => {
                BeginContext(41, 176, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(218, 13, false);
#line 10 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Shared\_TeacherLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(231, 1136, true);
                WriteLiteral(@"</title>
    <!-- Favicon -->
    <link href=""img/favicon.ico"" rel=""shortcut icon"" />

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Raleway:400,400i,500,500i,600,600i,700,700i,800,800i"" rel=""stylesheet"">

    <!-- Stylesheets -->
    <!-- Favicon -->
    <link href=""img/favicon.ico"" rel=""shortcut icon"" />

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Raleway:400,400i,500,500i,600,600i,700,700i,800,800i"" rel=""stylesheet"">

    <!-- Stylesheets -->
    <link rel=""stylesheet"" href=""../assets/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""../assets/icon-fonts/material-design-icons/material-design-icons.css"">
    <link rel=""stylesheet"" href=""../assets/css/font-awesome.min.css"" />
    <link rel=""stylesheet"" href=""../assets/css/owl.carousel.css"" />
    <link rel=""stylesheet"" href=""../assets/style/style.css"" />


    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"">");
                WriteLiteral("</script>\r\n      <script src=\"https://oss.maxcdn.com/respond/1.4.2/respond.min.js\"></script>\r\n    <![endif]-->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1374, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1378, 6051, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfaa4104bdf74cf3dde75dc09f830dd31391f4ad6398", async() => {
                BeginContext(1384, 2979, true);
                WriteLiteral(@"
    <div id=""wrapper"">
        <!-- Sidebar -->
        <div class=""bg-dark border-right text-white"" id=""sidebar-wrapper"">
            <div class=""sidebar-heading text-dark mb-5"">
                <button class=""btn btn-dark ml-2 mt-3 d-md-none ml-md-auto menu-toggle""><i class=""fas fa-angle-double-left""></i></button>
            </div>
            <div class=""list-group list-group-flush"">
                <a href=""#"" class=""list-group-item list-group-item-action bg-light""><i class=""fas fa-book-open""></i></a>
                <a href=""#"" class=""list-group-item list-group-item-action bg-light""><i class=""fas fa-edit"" aria-hidden=""true""></i></a>
                <a href=""#"" class=""list-group-item list-group-item-action bg-light""><i class=""fas fa-folder-open""></i></a>
                <a href=""#"" class=""list-group-item list-group-item-action bg-light""><span class=""material-icons"">message</span></a>
            </div>
        </div>
        <!-- /#sidebar-wrapper -->
        <!-- Page Content -->
      ");
                WriteLiteral(@"  <div id=""page-content-wrapper"">

            <nav class=""navbar navbar-expand-lg navbar-light bg-light border-bottom box-shadow"">
                <a class=""navbar-brand"" href=""#"">
                    <img src=""../assets/img/logo.png"" width=""120"" height=""45"" class=""d-inline-block align-top"" alt="""">
                </a>

                <ul class=""nav ml-auto mt-2 mt-lg-0"">
                    <li class=""nav-item mr-2"">
                        <a class=""nav-link nav-link-icons"" href=""#""><i class=""fas fa-cog""></i></a>
                    </li>
                    <li class=""nav-item mr-2"">
                        <a class=""nav-link nav-link-icons"" href=""#""><i class=""fas fa-bell""></i></a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle mt-1"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <img class=""rounded-circle avata");
                WriteLiteral(@"r"" src=""../assets/img/authors/3.jpg"" alt=""avatar"">
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdown"">
                            <h6 class=""dropdown-header"">Profile</h6>
                            <a class=""dropdown-item dropdown-item-sl"" href=""#"">Edit Profile</a>
                            <a class=""dropdown-item dropdown-item-sl"" href=""#"">Billing</a>
                            <a class=""dropdown-item dropdown-item-sl"" href=""#"">Payments</a>
                            <a class=""dropdown-item dropdown-item-sl"" href=""#"">Log Out</a>
                        </div>
                    </li>
                </ul>
                <button class=""btn btn-light mt-2 d-md-none menu-toggle""><i class=""fas fa-angle-double-right""></i></button>
            </nav>

            <main role=""main"" class=""mt-5 pb-5"">
                    ");
                EndContext();
                BeginContext(4364, 12, false);
#line 85 "C:\Users\Nonso\source\repos\NewSoftlearn\NewSoftlearn\Views\Shared\_TeacherLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4376, 3046, true);
                WriteLiteral(@"
            </main>


        </div>
        <!-- /#page-content-wrapper -->

    </div>
    <!-- /#wrapper -->


    <!-- Modal -->
    <div class=""modal fade"" id=""courseDescriptionModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""courseDescriptionModalTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-lg-3"">
                                <img class="""" src=""../assets/img/courses/angularjs.jpg"" />
                            </div>
                            <div class=""col-lg-9 pt-4"">
                                <h2 class=""c-h3"">UI Design with Adobe XD</h2>
                                <p>by Stephen Oloto</p>
                            </div>
                        </div>
                        <div>
          ");
                WriteLiteral(@"                  <p>Learn the fundamentals of Adobe XD and how to create basic prototypes.</p>
                        </div>
                        <div>
                            <p class=""mb-0 mt-0""><i class=""fas fa-check""></i> &nbsp; Fundamentals of working with Angular</p>
                            <p class=""mb-0 mt-0""><i class=""fas fa-check""></i> &nbsp; Create complete Angular Applications</p>
                            <p class=""mb-0 mt-0""><i class=""fas fa-check""></i> &nbsp; Working with Angular CLI.</p>
                            <p class=""mb-0 mt-0""><i class=""fas fa-check""></i> &nbsp; Understanding Dependency Injection</p>
                            <p class=""mb-0 mt-0""><i class=""fas fa-check""></i> &nbsp; Testing with Angular</p>
                        </div>
                        <div class=""row mt-3 mb-4"">
                            <div class=""col-lg-6"">
                                <div>
                                    <p class=""mb-0""><i class=""fas fa-clock""></i> &");
                WriteLiteral(@"nbsp; 6 Hours</p>
                                    <p class=""mb-0""><i class=""fas fa-play-circle""></i> &nbsp; 12 Lessons</p>
                                    <p class=""mb-0""><i class=""fas fa-chart-bar""></i> &nbsp; Beginner</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 pt-5"">
                                <button class=""btn btn-sl-green float-right"">Edit Course</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    <script src=""../assets/js/jquery-3.2.1.min.js""></script>
    <script src=""../assets/js/bootstrap.min.js""></script>
    <script src=""../assets/js/mixitup.min.js""></script>
    <script src=""../assets/js/circle-progress.min.js""></script>
    <script src=""../assets/js/owl.carousel.min.js""></script>
    <script src=""../assets/js/main.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7429, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
