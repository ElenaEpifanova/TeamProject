#pragma checksum "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\ViewRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19f93748ebe95c3eaebce8dff44517c976695bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewRequests_ViewRequest), @"mvc.1.0.view", @"/Views/ViewRequests/ViewRequest.cshtml")]
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
#line 1 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\ViewRequest.cshtml"
using TeamProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f93748ebe95c3eaebce8dff44517c976695bb9", @"/Views/ViewRequests/ViewRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c546f2974b8dd096bc1b245731dc154b9b13d0f2", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewRequests_ViewRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewRequestsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\ViewRequest.cshtml"
  
    Layout = "_View";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>

    var items = new vis.DataSet({
        type: { start: 'ISODate', end: 'ISODate' }
    });

    var groups = new vis.DataSet([
        {
            id: 'bar',
            content: 'График',
            subgroupStack: { sg_1: true},
            subgroupVisibility: { sg_1: true}
        }
    ]);
    // add items to the DataSet
    items.add([
        {
");
#nullable restore
#line 25 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\ViewRequests\ViewRequest.cshtml"
               
                foreach(var technic in Model.AllRequests)
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            id: 1,
            content: 'Тех1',
            start: '2020-11-02T08:00:00',
            end: '2020-11-04T20:00:00',
            group: 'bar',
            subgroup: 'sg_1',
            subgroupOrder: 0
        },
        {
            id: 2,
            content: 'Тех2',
            start: '2020-11-05T08:00:00',
            end: '2020-11-05T20:00:00',
            group: 'bar',
            subgroup: 'sg_1',
            subgroupOrder: 0
        },
    ]);

    var container = document.getElementById('visualization');

    var options = {
        start: '2020-11-01',
        end: '2020-11-10',
    };

    var timeline = new vis.Timeline(container, items, groups, options);


</script>");
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