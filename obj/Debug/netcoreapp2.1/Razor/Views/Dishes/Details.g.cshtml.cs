#pragma checksum "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b9d7756e97a62ee9e597dd467e67a888113fdf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dishes_Details), @"mvc.1.0.view", @"/Views/Dishes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dishes/Details.cshtml", typeof(AspNetCore.Views_Dishes_Details))]
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
#line 2 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
using delishapplication.Models;

#line default
#line hidden
#line 3 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
using delishapplication.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b9d7756e97a62ee9e597dd467e67a888113fdf8", @"/Views/Dishes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abcdf7b90ae5d723922d8b0f5438f66052b46a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Dishes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<delishapplication.Models.Dish>
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
            BeginContext(102, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(149, 61, true);
            WriteLiteral("<style>\r\n    body {\r\n        margin: 10px;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(210, 1289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c506ccfc64c7447cb8605fb6698ffd4d", async() => {
                BeginContext(216, 146, true);
                WriteLiteral("\r\n    <h2>Details</h2>\r\n\r\n    <div>\r\n        <h4>Dish</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(363, 44, false);
#line 22 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DishName));

#line default
#line hidden
                EndContext();
                BeginContext(407, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(463, 40, false);
#line 25 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayFor(model => model.DishName));

#line default
#line hidden
                EndContext();
                BeginContext(503, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(559, 41, false);
#line 28 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(600, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(656, 37, false);
#line 31 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(693, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(749, 41, false);
#line 34 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Spicy));

#line default
#line hidden
                EndContext();
                BeginContext(790, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(846, 37, false);
#line 37 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Spicy));

#line default
#line hidden
                EndContext();
                BeginContext(883, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(939, 41, false);
#line 40 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Vegan));

#line default
#line hidden
                EndContext();
                BeginContext(980, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1036, 37, false);
#line 43 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Vegan));

#line default
#line hidden
                EndContext();
                BeginContext(1073, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1129, 47, false);
#line 46 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1176, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1232, 43, false);
#line 49 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1275, 97, true);
                WriteLiteral("\r\n            </dd>\r\n            <dd>\r\n                <p><b>Photo:</b></p>\r\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1372, "\"", 1407, 1);
#line 53 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Dishes\Details.cshtml"
WriteAttributeValue("", 1378, Url.Content(Model.PhotoLink), 1378, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1408, 84, true);
                WriteLiteral(" height=\"200\" width=\"300\" />\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n  \r\n    ");
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
            BeginContext(1499, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<delishapplication.Models.Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
