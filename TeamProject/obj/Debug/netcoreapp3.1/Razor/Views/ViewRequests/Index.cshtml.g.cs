#pragma checksum "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be04800edabd6056ed1bc789e0b9e20a50854f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewRequests_Index), @"mvc.1.0.view", @"/Views/ViewRequests/Index.cshtml")]
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
#line 1 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
using TeamProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be04800edabd6056ed1bc789e0b9e20a50854f4", @"/Views/ViewRequests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c546f2974b8dd096bc1b245731dc154b9b13d0f2", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewRequests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewRequestsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
  
    Layout = "_Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
  
    int i = 1;
    foreach (var request in Model.AllRequests)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 12 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
       Write(request.begin.ToString().Substring(0, 10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
       Write(request.Responsible.User.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
       Write(request.Shop.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
       Write(request.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\Index.cshtml"
        i++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewRequestsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591