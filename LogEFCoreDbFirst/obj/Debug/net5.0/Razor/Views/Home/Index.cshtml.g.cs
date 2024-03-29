#pragma checksum "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db93ec646fadf6c2cd539957b3836451f1c4b687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/_ViewImports.cshtml"
using LogEFCoreDbFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/_ViewImports.cshtml"
using LogEFCoreDbFirst.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
using LogEFCoreDbFirst.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db93ec646fadf6c2cd539957b3836451f1c4b687", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e883ab6d039c77d17eece6ebe50c602261e45fc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ThingsModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/DeleteThings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "待辦清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 8 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>");
#nullable restore
#line 9 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
  Write(TempData["ResultMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db93ec646fadf6c2cd539957b3836451f1c4b6874434", async() => {
                WriteLiteral("\r\n    \r\n    ");
#nullable restore
#line 15 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
Write(Html.ActionLink("新增","CreateThing"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <table style=""width: 100%;"">
        <thead>
            <tr>
                <th>選取</th>
                <th>編號</th>
                <th>標題</th>
                <th>創建時間</th>
                <th>截止時間</th>
                <th>操作</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
              
                foreach(ThingsModel thing in Model){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <th><input type=\"checkbox\" name=\"chbId\"");
                BeginWriteAttribute("value", " value=\"", 775, "\"", 792, 1);
#nullable restore
#line 31 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
WriteAttributeValue("", 783, thing.Id, 783, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></th>\r\n                        <th>");
#nullable restore
#line 32 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                       Write(thing.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 33 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                       Write(thing.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 34 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                       Write(thing.CreateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 35 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                       Write(thing.EndTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 37 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                       Write(Html.ActionLink("編輯","EditThing", new {id=thing.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" | \r\n                            ");
#nullable restore
#line 38 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                       Write(Html.ActionLink("刪除","DeleteThing", new {id=thing.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "/Users/yutou/Desktop/asp.net core/LogEFCoreDbFirst/Views/Home/Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <input type=\"submit\" value=\"批次刪除\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ThingsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
