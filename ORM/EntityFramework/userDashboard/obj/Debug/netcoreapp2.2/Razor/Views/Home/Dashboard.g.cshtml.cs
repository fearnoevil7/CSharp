#pragma checksum "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19b187bd9f76a5a48ba9555f3a526c981580d69e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/_ViewImports.cshtml"
using userDashboard;

#line default
#line hidden
#line 2 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/_ViewImports.cshtml"
using userDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19b187bd9f76a5a48ba9555f3a526c981580d69e", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53898703dbbd66082c70aa627a2bd7849268bdc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<html lang=\"en\">\n");
            EndContext();
            BeginContext(17, 411, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19b187bd9f76a5a48ba9555f3a526c981580d69e4229", async() => {
                BeginContext(23, 135, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Document</title>\n    ");
                EndContext();
                BeginContext(158, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19b187bd9f76a5a48ba9555f3a526c981580d69e4747", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(204, 217, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
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
            BeginContext(428, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(429, 3197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19b187bd9f76a5a48ba9555f3a526c981580d69e7066", async() => {
                BeginContext(435, 966, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <a class=""navbar-brand"" href=""/"" style=""margin: 0px 0px 0px 20px;"">Test App</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
            <ul class=""navbar-nav"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""/dashboard"">Dashboard <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/users/edit"">Profile</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/signout"">Sign Out</a>
                </li>
");
                EndContext();
                BeginContext(1998, 369, true);
                WriteLiteral(@"            </ul>
        </div>
    </nav>

    <h3 class=""Dashboardh3"">All Users</h3>
    <table class=""table table-striped"">
        <thead>
            <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">User Level</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 49 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
                BeginContext(2422, 57, true);
                WriteLiteral("                <tr>\n                    <th scope=\"row\">");
                EndContext();
                BeginContext(2480, 11, false);
#line 52 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
                               Write(user.UserId);

#line default
#line hidden
                EndContext();
                BeginContext(2491, 32, true);
                WriteLiteral("</th>\n                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2523, "\"", 2554, 2);
                WriteAttributeValue("", 2530, "/users/show/", 2530, 12, true);
#line 53 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2542, user.UserId, 2542, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2555, 4, true);
                WriteLiteral("><u>");
                EndContext();
                BeginContext(2560, 14, false);
#line 53 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
                                                         Write(user.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2574, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2576, 13, false);
#line 53 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
                                                                         Write(user.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(2589, 38, true);
                WriteLiteral("</u></a></td>\n                    <td>");
                EndContext();
                BeginContext(2628, 10, false);
#line 54 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
                   Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2638, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 55 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
                      
                        if (user.IsAdmin == true)
                        {

#line default
#line hidden
                BeginContext(2743, 43, true);
                WriteLiteral("                            <td>Admin</td>\n");
                EndContext();
#line 59 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2867, 44, true);
                WriteLiteral("                            <td>Normal</td>\n");
                EndContext();
#line 63 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
                        }
                    

#line default
#line hidden
                BeginContext(2959, 22, true);
                WriteLiteral("                </tr>\n");
                EndContext();
#line 66 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/userDashboard/Views/Home/Dashboard.cshtml"
            }

#line default
#line hidden
                BeginContext(2995, 624, true);
                WriteLiteral(@"    </tbody>
</table>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
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
            BeginContext(3626, 8, true);
            WriteLiteral("\n</html>");
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