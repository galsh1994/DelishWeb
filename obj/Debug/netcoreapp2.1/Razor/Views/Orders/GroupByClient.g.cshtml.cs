#pragma checksum "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47921da9d74ac6da5065b76ce76a825c7cb9d52d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_GroupByClient), @"mvc.1.0.view", @"/Views/Orders/GroupByClient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/GroupByClient.cshtml", typeof(AspNetCore.Views_Orders_GroupByClient))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47921da9d74ac6da5065b76ce76a825c7cb9d52d", @"/Views/Orders/GroupByClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abcdf7b90ae5d723922d8b0f5438f66052b46a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_GroupByClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<delishapplication.Models.Order>>
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
#line 3 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
  
    ViewData["Title"] = "GroupByClient";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 61, true);
            WriteLiteral("<style>\r\n    body {\r\n        margin: 10px;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(211, 1175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21fc0c4760f84026bd94b0849b9fed0b", async() => {
                BeginContext(217, 256, true);
                WriteLiteral(@"
    <h3> Orders Grouped by clients </h3>
    <br />
    <table class=""joinTable"">
        <tr>
            <th> Oreder ID</th>
            <th> Client name</th>
            <th> Arrival Date</th>
            <th> Total Price </th>
        </tr>
");
                EndContext();
#line 22 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
          

            var groupbyList = ViewBag.groupBy;
            foreach (var list in groupbyList)
            {
                var group = list.GetEnumerator();
                do
                {
                    Order current = group.Current;
                    if (current == null) { continue; }

#line default
#line hidden
                BeginContext(795, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(850, 15, false);
#line 33 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
                       Write(current.OrderID);

#line default
#line hidden
                EndContext();
                BeginContext(865, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(901, 22, false);
#line 34 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
                       Write(current.ClientUserName);

#line default
#line hidden
                EndContext();
                BeginContext(923, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(959, 19, false);
#line 35 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
                       Write(current.ArrivalDate);

#line default
#line hidden
                EndContext();
                BeginContext(978, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1014, 18, false);
#line 36 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
                       Write(current.TotalPrice);

#line default
#line hidden
                EndContext();
                BeginContext(1032, 36, true);
                WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
                EndContext();
#line 39 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
                } while (group.MoveNext());


#line default
#line hidden
                BeginContext(1115, 181, true);
                WriteLiteral("                <tr>\r\n                    <td>---</td>\r\n                    <td>---</td>\r\n                    <td>---</td>\r\n                    <td>---</td>\r\n                </tr>\r\n");
                EndContext();
#line 47 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Orders\GroupByClient.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1322, 57, true);
                WriteLiteral("    </table>\r\n    </center>\r\n    <br />\r\n    <br />\r\n    ");
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
            BeginContext(1386, 4, true);
            WriteLiteral("\r\n\r\n");
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