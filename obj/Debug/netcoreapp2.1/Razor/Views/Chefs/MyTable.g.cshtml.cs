#pragma checksum "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\MyTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f32d8174e0d06ddd6de2d241c2f44fb2883af590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chefs_MyTable), @"mvc.1.0.view", @"/Views/Chefs/MyTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chefs/MyTable.cshtml", typeof(AspNetCore.Views_Chefs_MyTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32d8174e0d06ddd6de2d241c2f44fb2883af590", @"/Views/Chefs/MyTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abcdf7b90ae5d723922d8b0f5438f66052b46a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Chefs_MyTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<delishapplication.Models.Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\MyTable.cshtml"
  
    ViewData["Title"] = "MyTable";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 28, true);
            WriteLiteral("\r\n<h2>MyTable</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 11 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\MyTable.cshtml"
     foreach (var chef in ViewBag.ourList)
    {

#line default
#line hidden
            BeginContext(222, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(235, 15, false);
#line 13 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\MyTable.cshtml"
       Write(chef.Popularity);

#line default
#line hidden
            EndContext();
            BeginContext(250, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\MyTable.cshtml"

    }

#line default
#line hidden
            BeginContext(266, 81, true);
            WriteLiteral("    \r\n</ul>\r\n\r\n<!--\r\n<script type=\"text/javascript\">\r\n\r\n        var DATA2 = { a: ");
            EndContext();
            BeginContext(348, 17, false);
#line 22 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\MyTable.cshtml"
                    Write(ViewBag.userAdmin);

#line default
#line hidden
            EndContext();
            BeginContext(365, 5, true);
            WriteLiteral(", b: ");
            EndContext();
            BeginContext(371, 18, false);
#line 22 "C:\Users\galsh\OneDrive\שולחן העבודה\גל\לימודים\שנה ב\סמסטר ב\אפליקציות\הגשה\delishapplication\delishapplication\Views\Chefs\MyTable.cshtml"
                                           Write(ViewBag.userMember);

#line default
#line hidden
            EndContext();
            BeginContext(389, 1042, true);
            WriteLiteral(@" }
        var width = 450, height = 450, margin = 40;
        var radius = Math.min(width, height) / 2 - margin;
        var container = d3
            .select('#secondSvg')
            .attr(""width"", width)
            .attr(""height"", height)
            .append(""g"")
            .attr(""transform"", ""translate("" + width / 2 + "","" + height / 2 + "")"");
        var pie = d3.pie()
            .value(data => data.value)
        var data_ready = pie(d3.entries(DATA2))
        var color = 'blue';
        container
            .selectAll('groups')
            .data(data_ready)
            .enter()
            .append('path')
            .attr('d', d3.arc()
                .innerRadius(0)
                .outerRadius(radius)
            )
            .attr('fill', () => {
                if (color == 'blue') { color = 'yellow'; return 'blue'; } else return 'yellow';
            })
            .attr(""stroke"", ""black"")
            .style(""stroke-width"", ""2px"")
            .style(""opacity"", 0.7");
            WriteLiteral(");\r\n</script>\r\n-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<delishapplication.Models.Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591