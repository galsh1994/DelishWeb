#pragma checksum "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecf926ea7d83c5e0473debe5898e458bde8ca34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chefs_Delete), @"mvc.1.0.view", @"/Views/Chefs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chefs/Delete.cshtml", typeof(AspNetCore.Views_Chefs_Delete))]
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
#line 1 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\_ViewImports.cshtml"
using delishapplication;

#line default
#line hidden
#line 2 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\_ViewImports.cshtml"
using delishapplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ecf926ea7d83c5e0473debe5898e458bde8ca34", @"/Views/Chefs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abcdf7b90ae5d723922d8b0f5438f66052b46a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Chefs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<delishapplication.Models.Chef>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Chef</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(248, 48, false);
#line 15 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ChefUserName));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(340, 44, false);
#line 18 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ChefUserName));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(428, 45, false);
#line 21 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(473, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(517, 41, false);
#line 24 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(602, 44, false);
#line 27 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(646, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(690, 40, false);
#line 30 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(730, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(774, 47, false);
#line 33 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(821, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(865, 43, false);
#line 36 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(908, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(952, 41, false);
#line 39 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(993, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1037, 37, false);
#line 42 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1118, 44, false);
#line 45 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1206, 40, false);
#line 48 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1290, 46, false);
#line 51 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1380, 42, false);
#line 54 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Experience));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1466, 40, false);
#line 57 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1550, 36, false);
#line 60 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1630, 42, false);
#line 63 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Kosher));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1716, 38, false);
#line 66 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Kosher));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1798, 43, false);
#line 69 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1885, 39, false);
#line 72 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(1924, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1962, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bd5f2730f049718dd6d3d2423b0192", async() => {
                BeginContext(1988, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1998, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b641fc4965243c0b5657080e631c5f0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ChefID);

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
                BeginContext(2038, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2122, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85ef1c01643e4d69abf16a41b34325dc", async() => {
                    BeginContext(2144, 12, true);
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
                BeginContext(2160, 6, true);
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
            BeginContext(2173, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<delishapplication.Models.Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591