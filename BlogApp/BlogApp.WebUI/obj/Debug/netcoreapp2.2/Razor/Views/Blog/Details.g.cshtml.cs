#pragma checksum "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b207c6a3dc8fcfa3207e93484cdca2f23b86da1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Details.cshtml", typeof(AspNetCore.Views_Blog_Details))]
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
#line 1 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
#line 2 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b207c6a3dc8fcfa3207e93484cdca2f23b86da1", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17871605585b9cacbd9dbdea6982b0a8efc479fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(56, 94, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(151, 43, false);
#line 9 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(194, 150, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"card mb-2\">\r\n                <div class=\"card-header\">\r\n                    ");
            EndContext();
            BeginContext(345, 11, false);
#line 14 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(356, 42, true);
            WriteLiteral("\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(398, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b207c6a3dc8fcfa3207e93484cdca2f23b86da14700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 429, "~/img/", 429, 6, true);
#line 16 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 435, Model.Image, 435, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 454, Model.Title, 454, 12, false);

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
            BeginContext(468, 89, true);
            WriteLiteral("\r\n\r\n                <div class=\"card-block\">\r\n                    <h4 class=\"card-title\">");
            EndContext();
            BeginContext(558, 11, false);
#line 19 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(569, 48, true);
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(618, 17, false);
#line 20 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(635, 47, true);
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(683, 10, false);
#line 21 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Details.cshtml"
                                    Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(693, 108, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<h1>Details</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
