#pragma checksum "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cefb4afc9da9e6430a1aaaaf3bb28eb78388f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditThing), @"mvc.1.0.view", @"/Views/Home/EditThing.cshtml")]
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
#line 1 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/_ViewImports.cshtml"
using EFCoreDbFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/_ViewImports.cshtml"
using EFCoreDbFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cefb4afc9da9e6430a1aaaaf3bb28eb78388f29", @"/Views/Home/EditThing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2215427530c1ec15ee7cbace43cb4828a9135bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditThing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFCoreDbFirst.Data.ModelsDB.ThingsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/EditThing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
  
    ViewData["Title"] = "編輯";
    string createTime = @Model.CreateTime.ToString("yyyy-MM-ddTHH:mm");
    string endTime = @Model.EndTime.ToString("yyyy-MM-ddTHH:mm");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">");
#nullable restore
#line 8 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <p>");
#nullable restore
#line 9 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
  Write(ViewData["ResultMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n<br>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cefb4afc9da9e6430a1aaaaf3bb28eb78388f294695", async() => {
                WriteLiteral("\n    <div>\n        <label");
                BeginWriteAttribute("for", " for=\"", 417, "\"", 423, 0);
                EndWriteAttribute();
                WriteLiteral(">編號</label>\n        <div>\n            <input type=\"text\" name=\"Id\"");
                BeginWriteAttribute("id", " id=\"", 490, "\"", 495, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 496, "\"", 513, 1);
#nullable restore
#line 17 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
WriteAttributeValue("", 504, Model.Id, 504, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\n        </div>\n    </div>\n    <div>\n        <label");
                BeginWriteAttribute("for", " for=\"", 575, "\"", 581, 0);
                EndWriteAttribute();
                WriteLiteral(">標題</label>\n        <div>\n            <input type=\"text\" name=\"Title\"");
                BeginWriteAttribute("id", " id=\"", 651, "\"", 656, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 657, "\"", 677, 1);
#nullable restore
#line 23 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
WriteAttributeValue("", 665, Model.Title, 665, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        </div>\n    </div>\n    <div>\n        <label");
                BeginWriteAttribute("for", " for=\"", 730, "\"", 736, 0);
                EndWriteAttribute();
                WriteLiteral(">創建時間</label>\n        <div>\n            <input type=\"datetime-local\" name=\"CreateTime\"");
                BeginWriteAttribute("id", " id=\"", 823, "\"", 828, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 829, "\"", 848, 1);
#nullable restore
#line 29 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
WriteAttributeValue("", 837, createTime, 837, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        </div>\n    </div>\n    <div>\n        <label");
                BeginWriteAttribute("for", " for=\"", 901, "\"", 907, 0);
                EndWriteAttribute();
                WriteLiteral(">截止時間</label>\n        <div>\n            <input type=\"datetime-local\" name=\"EndTime\"");
                BeginWriteAttribute("id", " id=\"", 991, "\"", 996, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 997, "\"", 1013, 1);
#nullable restore
#line 35 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
WriteAttributeValue("", 1005, endTime, 1005, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        </div>\n    </div>\n    <br>\n");
#nullable restore
#line 39 "/Users/yutou/Desktop/asp.net core/EFCoreDbFirst/Views/Home/EditThing.cshtml"
      
        Model.CreateTime = DateTime.Parse(createTime);       
        Model.EndTime = DateTime.Parse(endTime);       
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"submit\" value=\"儲存\">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFCoreDbFirst.Data.ModelsDB.ThingsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
