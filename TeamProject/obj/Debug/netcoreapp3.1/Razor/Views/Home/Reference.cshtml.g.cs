#pragma checksum "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\Reference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bfef49cf3f81b4083ae727550668cec17b6efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Reference), @"mvc.1.0.view", @"/Views/Home/Reference.cshtml")]
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
#line 1 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\Reference.cshtml"
using TeamProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62bfef49cf3f81b4083ae727550668cec17b6efe", @"/Views/Home/Reference.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c546f2974b8dd096bc1b245731dc154b9b13d0f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Reference : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Home\Reference.cshtml"
  
    Layout = "_Reference";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<article class=""post"">
    <header>
        <div class=""title"">
            <h2>Справочная информация</h2>
        </div>
    </header>
    <h2>Журнал заявок</h2>
    <p>Возможна сортировка заявок по следующим параметрам:</p>
    <ul>
        <li>дата,</li>
        <li>ФИО ответственного,</li>
        <li>цех.</li>
    </ul>
    <p>Сортировка осуществляется с помощью нажатия на соответствующие заголовки таблицы.</p>
     <h2>Добавление заявки</h2>
    <p>Если в журнале уже имеется заявка, у которой параметры</p>
    <ul>
        <li>цех,</li>
        <li>ФИО ответственного,</li>
        <li>место работы,</li>
        <li>даты начала и окончания работ</li>
    </ul>
    <p>совпадают с параметрами добавляемой заявки, то данная заявка будет отредактирована с учётом новых введённых данных: все раннее добавленные запросы на технику будут заменены, а также будут изменены описание работ и комментарий.</p>
    <h2>Редактирование заявки перед добавлением</h2>
    <p>Если при редактирование 1-");
            WriteLiteral(@"ого раздела были изменены даты начала и окончания работ, то у всех раннее составленных запросов на технику будут изменены следующие параметры:</p>
    <ul>
        <li>задержка (00:00),</li>
        <li>продолжительность (00:30).</li>
    </ul>
    <p>После чего произойдёт переход ко 2-ому разделу для их повторного ввода.</p>
</article>");
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
