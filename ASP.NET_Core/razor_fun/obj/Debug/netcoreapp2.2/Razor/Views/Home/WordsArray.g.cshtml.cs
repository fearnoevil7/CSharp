#pragma checksum "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c62ce9ac42c5ae42827618017197694e0ed1bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WordsArray), @"mvc.1.0.view", @"/Views/Home/WordsArray.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WordsArray.cshtml", typeof(AspNetCore.Views_Home_WordsArray))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c62ce9ac42c5ae42827618017197694e0ed1bab", @"/Views/Home/WordsArray.cshtml")]
    public class Views_Home_WordsArray : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 17, true);
            WriteLiteral("<html lang=\"en\">\n");
            EndContext();
            BeginContext(17, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c62ce9ac42c5ae42827618017197694e0ed1bab2878", async() => {
                BeginContext(23, 131, true);
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
            BeginContext(161, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(166, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c62ce9ac42c5ae42827618017197694e0ed1bab4179", async() => {
                BeginContext(172, 49, true);
                WriteLiteral("\n        <h1>Here Are Some Delicious Foods!</h1>\n");
                EndContext();
#line 9 "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml"
          
            var StringList = new List <string>()
                {
                    "Apple Pies",
                    "Burritos",
                    "Clams Casino",
                    "Donuts",
                };
            foreach(var word in StringList)
            {  
                

#line default
#line hidden
#line 19 "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml"
                 if (word[0] == 'C') {

#line default
#line hidden
                BeginContext(549, 43, true);
                WriteLiteral("                    <p style=\"color:red;\" >");
                EndContext();
                BeginContext(593, 4, false);
#line 20 "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml"
                                      Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(597, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 21 "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml"
                } else {

#line default
#line hidden
                BeginContext(627, 23, true);
                WriteLiteral("                    <p>");
                EndContext();
                BeginContext(651, 4, false);
#line 22 "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml"
                  Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(655, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 23 "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml"
                }

#line default
#line hidden
#line 23 "/Users/Jonathon/Documents/coding_dojo/C#/ASP.NET_Core/razor_fun/Views/Home/WordsArray.cshtml"
                 
            }
        

#line default
#line hidden
                BeginContext(702, 4, true);
                WriteLiteral("    ");
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
            BeginContext(713, 8, true);
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
