#pragma checksum "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ba7ab6ef99c7e0d9281a58c0d0795cef708af4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountHolder_Delete), @"mvc.1.0.view", @"/Views/AccountHolder/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountHolder/Delete.cshtml", typeof(AspNetCore.Views_AccountHolder_Delete))]
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
#line 1 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\_ViewImports.cshtml"
using MvcCoreProject_Arif;

#line default
#line hidden
#line 2 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\_ViewImports.cshtml"
using MvcCoreProject_Arif.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ba7ab6ef99c7e0d9281a58c0d0795cef708af4f", @"/Views/AccountHolder/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7630c34f7623444a1875035f612d7f4bcfb9a53d", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountHolder_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcCoreProject_Arif.Models.AccountHolder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 174, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AccountHolder</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(315, 40, false);
#line 16 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(355, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(399, 36, false);
#line 19 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(435, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(479, 46, false);
#line 22 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.fatherName));

#line default
#line hidden
            EndContext();
            BeginContext(525, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(569, 42, false);
#line 25 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayFor(model => model.fatherName));

#line default
#line hidden
            EndContext();
            BeginContext(611, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(655, 41, false);
#line 28 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(696, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(740, 37, false);
#line 31 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(777, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(821, 39, false);
#line 34 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(860, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(904, 35, false);
#line 37 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(939, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(983, 47, false);
#line 40 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningDate));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1074, 43, false);
#line 43 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OpeningDate));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1161, 44, false);
#line 46 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1249, 40, false);
#line 49 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1333, 51, false);
#line 52 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1428, 47, false);
#line 55 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1513, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd9ce26c9a541be8859d41da9310bcc", async() => {
                BeginContext(1539, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1549, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66d28c61173443d7bdae14a29844a10f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\AccountHolder\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1585, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1669, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef456658c1f40359973d6069ebc6908", async() => {
                    BeginContext(1691, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1707, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1720, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcCoreProject_Arif.Models.AccountHolder> Html { get; private set; }
    }
}
#pragma warning restore 1591