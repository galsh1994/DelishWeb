#pragma checksum "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9900d67f19d619be1e9b48efe0c3a039832a2f18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_orderHistory), @"mvc.1.0.view", @"/Views/Orders/orderHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/orderHistory.cshtml", typeof(AspNetCore.Views_Orders_orderHistory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9900d67f19d619be1e9b48efe0c3a039832a2f18", @"/Views/Orders/orderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abcdf7b90ae5d723922d8b0f5438f66052b46a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_orderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<delishapplication.Models.Order>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
  
    ViewData["Title"] = "orderHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 61, true);
            WriteLiteral("<style>\r\n    body {\r\n        margin: 10px;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(210, 1521, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2af8a70b95b140b6abc5805ccc98c47a", async() => {
                BeginContext(216, 191, true);
                WriteLiteral("\r\n    <h2> Order History</h2>\r\n    <center>\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                  \r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(408, 45, false);
#line 21 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
                EndContext();
                BeginContext(453, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(533, 47, false);
#line 24 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                   Write(Html.DisplayNameFor(model => model.ArrivalDate));

#line default
#line hidden
                EndContext();
                BeginContext(580, 99, true);
                WriteLiteral("\r\n                    </th>\r\n                  \r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(680, 46, false);
#line 28 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
                EndContext();
                BeginContext(726, 126, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 34 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(917, 86, true);
                WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1004, 44, false);
#line 39 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
                EndContext();
                BeginContext(1048, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1140, 46, false);
#line 42 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ArrivalDate));

#line default
#line hidden
                EndContext();
                BeginContext(1186, 93, true);
                WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1280, 45, false);
#line 46 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1325, 62, true);
                WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
                EndContext();
#line 50 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
                }

#line default
#line hidden
                BeginContext(1406, 213, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <h4>You have an option to order the same order like your previous one in a click!</h4>\r\n        <button style=\"width:200px; background-color:darksalmon; color:white\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1619, "\"", 1688, 4);
                WriteAttributeValue("", 1629, "window.location.href=", 1629, 21, true);
                WriteAttributeValue(" ", 1650, "\'", 1651, 2, true);
#line 54 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\orderHistory.cshtml"
WriteAttributeValue("", 1652, Url.Action("copyOrder", "Orders"), 1652, 34, false);

#line default
#line hidden
                WriteAttributeValue("", 1686, "\';", 1686, 2, true);
                EndWriteAttribute();
                BeginContext(1689, 35, true);
                WriteLiteral(">re-Order</button>\r\n    </center>\r\n");
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
            BeginContext(1731, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<delishapplication.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
