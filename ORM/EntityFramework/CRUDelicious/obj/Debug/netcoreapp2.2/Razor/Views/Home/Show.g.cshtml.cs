#pragma checksum "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207d568c2e12e7b36ea09f522756c3da6e0bc765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
#line 1 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207d568c2e12e7b36ea09f522756c3da6e0bc765", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc21f8895b0e387cd9cc11523f6778b5176911eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 18, true);
            WriteLiteral("\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(18, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "207d568c2e12e7b36ea09f522756c3da6e0bc7653614", async() => {
                BeginContext(24, 131, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Document</title>\n");
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
            BeginContext(162, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(163, 472, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "207d568c2e12e7b36ea09f522756c3da6e0bc7654911", async() => {
                BeginContext(169, 35, true);
                WriteLiteral("\n    <a href = \"/\"><u>Home</u></a>\n");
                EndContext();
                BeginContext(211, 12, true);
                WriteLiteral("        <h1>");
                EndContext();
                BeginContext(224, 10, false);
#line 11 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml"
       Write(Model.name);

#line default
#line hidden
                EndContext();
                BeginContext(234, 18, true);
                WriteLiteral("</h1>\n        <h3>");
                EndContext();
                BeginContext(253, 10, false);
#line 12 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml"
       Write(Model.chef);

#line default
#line hidden
                EndContext();
                BeginContext(263, 27, true);
                WriteLiteral("</h3>\n        <p>Calories: ");
                EndContext();
                BeginContext(291, 14, false);
#line 13 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml"
                Write(Model.calories);

#line default
#line hidden
                EndContext();
                BeginContext(305, 27, true);
                WriteLiteral("</p>\n        <p>Tastiness: ");
                EndContext();
                BeginContext(333, 15, false);
#line 14 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml"
                 Write(Model.tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(348, 29, true);
                WriteLiteral("</p>\n        <p>Description: ");
                EndContext();
                BeginContext(378, 17, false);
#line 15 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml"
                   Write(Model.description);

#line default
#line hidden
                EndContext();
                BeginContext(395, 13, true);
                WriteLiteral("</p>\n        ");
                EndContext();
                BeginContext(408, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "207d568c2e12e7b36ea09f522756c3da6e0bc7657346", async() => {
                    BeginContext(443, 62, true);
                    WriteLiteral("\n            <input type = \"submit\" value = \"Delete\">\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 424, "/delete/", 424, 8, true);
#line 16 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml"
AddHtmlAttributeValue("", 432, Model.id, 432, 9, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(512, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(521, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "207d568c2e12e7b36ea09f522756c3da6e0bc7659439", async() => {
                    BeginContext(554, 60, true);
                    WriteLiteral("\n            <input type = \"submit\" value = \"Edit\">\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 537, "/edit/", 537, 6, true);
#line 19 "/Users/Jonathon/Documents/coding_dojo/C#/ORM/EntityFramework/CRUDelicious/Views/Home/Show.cshtml"
AddHtmlAttributeValue("", 543, Model.id, 543, 9, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(621, 1, true);
                WriteLiteral("\n");
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
            BeginContext(635, 8, true);
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