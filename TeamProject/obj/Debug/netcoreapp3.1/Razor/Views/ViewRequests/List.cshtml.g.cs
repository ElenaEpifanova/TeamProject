#pragma checksum "D:\Documents\TeamProject\TeamProject\Views\ViewRequests\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dc6cd96a1ca2f05b9093ba17dbe6e78d41c8f2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewRequests_List), @"mvc.1.0.view", @"/Views/ViewRequests/List.cshtml")]
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
#line 1 "D:\Documents\TeamProject\TeamProject\Views\ViewRequests\List.cshtml"
using TeamProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dc6cd96a1ca2f05b9093ba17dbe6e78d41c8f2d", @"/Views/ViewRequests/List.cshtml")]
    public class Views_ViewRequests_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewRequestsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Documents\TeamProject\TeamProject\Views\ViewRequests\List.cshtml"
  
    Layout = "_Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n  <tr><td>1</td><td>");
#nullable restore
#line 9 "D:\Documents\TeamProject\TeamProject\Views\ViewRequests\List.cshtml"
               Write(Model.AllRequests.First().begin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 9 "D:\Documents\TeamProject\TeamProject\Views\ViewRequests\List.cshtml"
                                                        Write(Model.AllRequests.First().Responsible.User.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 9 "D:\Documents\TeamProject\TeamProject\Views\ViewRequests\List.cshtml"
                                                                                                                 Write(Model.AllShops.First().name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
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
