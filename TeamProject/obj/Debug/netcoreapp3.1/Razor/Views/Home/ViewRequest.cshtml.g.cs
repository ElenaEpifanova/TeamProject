#pragma checksum "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa73498bd14212b41b9ab853dd04d07e7524f44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRequest), @"mvc.1.0.view", @"/Views/Home/ViewRequest.cshtml")]
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
#line 1 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
using TeamProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa73498bd14212b41b9ab853dd04d07e7524f44", @"/Views/Home/ViewRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c546f2974b8dd096bc1b245731dc154b9b13d0f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/graphic.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
  
    Layout = "_View";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Post -->
<article class=""post"">
    <header>
        <div class=""title"">
            <h2>Составление заявки</h2>
        </div>
        <div class=""meta"">
            <h2>Просмотр</h2>
        </div>
    </header>
        <h3>График работ</h3>

    <div id=""visualization""></div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa73498bd14212b41b9ab853dd04d07e7524f443849", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</article>\r\n\r\n\r\n<article class=\"post\">\r\n    <header>\r\n        <div class=\"title\">\r\n            <h3>Раздел 1</h3>\r\n        </div>\r\n    </header>\r\n");
#nullable restore
#line 32 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
      
        var request = Model.request;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>Цех: </b> ");
#nullable restore
#line 34 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                   Write(request.Shop.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p><b>Ответственный:</b> ");
#nullable restore
#line 35 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                            Write(request.Responsible.User.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p><b>Место работы: </b> ");
#nullable restore
#line 36 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                            Write(request.Place.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 37 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
        DateTime time = request.begin;
        string db;
        if (time.Day < 10)
            db = '0' + time.Day.ToString();
        else
            db = time.Day.ToString();
        db += '.';
        if (time.Month < 10)
            db += '0' + time.Month.ToString();
        else
            db += time.Month.ToString();
        db += '.';
        db += time.Year.ToString();

        string tb;
        if (time.Hour < 10)
            tb = '0' + time.Hour.ToString();
        else
            tb = time.Hour.ToString();
        tb += ':';
        if (time.Minute < 10)
            tb += '0' + time.Minute.ToString();
        else
            tb += time.Minute.ToString();

        time = request.end;
        string de;
        if (time.Day < 10)
            de = '0' + time.Day.ToString();
        else
            de = time.Day.ToString();
        de += '.';
        if (time.Month < 10)
            de += '0' + time.Month.ToString();
        else
            de += time.Month.ToString();
        de += '.';
        de += time.Year.ToString();

        string te;
        if (time.Hour < 10)
            te = '0' + time.Hour.ToString();
        else
            te = time.Hour.ToString();
        te += ':';
        if (time.Minute < 10)
            te += '0' + time.Minute.ToString();
        else
            te += time.Minute.ToString();



#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>Дата: </b> с ");
#nullable restore
#line 88 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                      Write(db);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 88 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                           Write(tb);

#line default
#line hidden
#nullable disable
            WriteLiteral(") по ");
#nullable restore
#line 88 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                                   Write(de);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 88 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                                        Write(te);

#line default
#line hidden
#nullable disable
            WriteLiteral(") </p>\r\n        <p>\r\n            <b>Описание работ: </b>\r\n            ");
#nullable restore
#line 91 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
       Write(request.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <b>Комментарий: </b>\r\n            ");
#nullable restore
#line 95 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
       Write(request.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("</article>\r\n\r\n<article class=\"post\">\r\n    <header>\r\n        <div class=\"title\">\r\n            <h3>Раздел 2</h3>\r\n        </div>\r\n    </header>\r\n");
#nullable restore
#line 106 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
      
        int i = 1;
        foreach (var technic in Model.request.technic)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> <b><u> ТЕХНИКА ");
#nullable restore
#line 110 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u> </b></p>\r\n            <p><b>Тип техники: </b> ");
#nullable restore
#line 111 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                               Write(technic.TypeTechnic.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p><b>Количество:</b> ");
#nullable restore
#line 112 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                             Write(technic.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 113 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
            int hour = technic.delay / 2,
               minute = technic.delay % 2 * 30;
            db = "";
            if (hour < 10)
                db = '0' + hour.ToString();
            else
                db = hour.ToString();
            db += ':';
            if (minute < 10)
                db += '0' + minute.ToString();
            else
                db += minute.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><b>Задержка: </b> ");
#nullable restore
#line 125 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                            Write(db);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 126 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
            hour = technic.duration / 2;
            minute = technic.duration % 2 * 30;
            db = "";
            if (hour < 10)
                db = '0' + hour.ToString();
            else
                db = hour.ToString();
            db += ':';
            if (minute < 10)
                db += '0' + minute.ToString();
            else
                db += minute.ToString();


#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><b>Продолжительность: </b> ");
#nullable restore
#line 139 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                                     Write(db);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><b>Путь к файлу: </b> ");
#nullable restore
#line 140 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                                Write(technic.path);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p><b>Исполнитель: </b> ");
#nullable restore
#line 141 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
                               Write(technic.Executor.User.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 142 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\ViewRequest.cshtml"
            i++;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
