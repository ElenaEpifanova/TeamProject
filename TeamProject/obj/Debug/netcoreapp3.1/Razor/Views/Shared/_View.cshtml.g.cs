#pragma checksum "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Shared\_View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "646920b12b5d9a783d6fedd036c16c762775c9f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__View), @"mvc.1.0.view", @"/Views/Shared/_View.cshtml")]
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
#line 1 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"646920b12b5d9a783d6fedd036c16c762775c9f9", @"/Views/Shared/_View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c546f2974b8dd096bc1b245731dc154b9b13d0f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("single is-preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "646920b12b5d9a783d6fedd036c16c762775c9f93431", async() => {
                WriteLiteral(@"
    <title>Составление заявки</title>
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, user-scalable=no"" />
    <script src=""assets/js/vis-timeline-graph2d.min.js""></script>
    <link rel=""stylesheet"" href=""assets/css/main.css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "646920b12b5d9a783d6fedd036c16c762775c9f94696", async() => {
                WriteLiteral(@"

    <!-- Wrapper -->
    <div id=""wrapper"">

        <!-- Header -->
        <header id=""header"">
            <h1><a href=""/ViewRequests/"">Журнал заявок</a></h1>
            <h1><a href=""/Section1/"">Составление заявки</a></h1>
        </header>

        <!-- Main -->
        <div id=""main"">

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
                <p><font color=""red"" size=4>Перед подачей заявки проверьте введённые Вами данные и полученный график работ. Если всё верно, то ещё раз нажмите кнопку ""Подать заявку"", находящуюся внизу страницы.</font></p>
                <h3>График работ</h3>
                <div id=""visualization""></div>
                ");
#nullable restore
#line 37 "D:\data\5 term\командный проект\TeamProject\TeamProject\Views\Shared\_View.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </article>


            <article class=""post"">
                <header>
                    <div class=""title"">
                        <h3>Раздел 1</h3>
                    </div>
                </header>
                <p><b>Цех: </b> КРС (Капитальный ремонт скважин) </p>
                <p><b>Ответственный:</b> Родзянко А.А. </p>
                <p><b>Дата: </b> с 02.11.2020 (08:00) по 05.11.2020 (20:00) </p>
                <p>
                    <b>Описание работ: </b>
                    Очистка забоя и ствола скважины от металлических предметов
                </p>
                <p>
                    <b>Комментарий: </b>
                    Более подробная информация о проводимых работах находится в прикреплённом файле
                </p>
            </article>

            <article class=""post"">
                <header>
                    <div class=""title"">
                        <h3>Раздел 2</h3>
                    </div>
                </header>");
                WriteLiteral(@"
                <p> <b><u> ТЕХНИКА 1</u> </b></p>
                <p><b>Тип техники: </b> Автокран </p>
                <p><b>Количество:</b> 2 </p>
                <p><b>Задержка: </b> 00:00 </p>
                <p><b>Продолжительность: </b> 36:00</p>
                <p><b>Путь к файлу: </b> Скв316_от_02_10.pdf </p>
                <p><b>Исполнитель: </b> Яременко О.К. </p>

                <p> <b> <u>ТЕХНИКА 2</u></b></p>
                <p><b>Тип техники: </b> Самосвал</p>
                <p><b>Количество:</b> 5 </p>
                <p><b>Задержка: </b> 36:00 </p>
                <p><b>Продолжительность: </b> 12:00</p>
                <p><b>Путь к файлу: </b> Скв316_от_02_10.pdf </p>
                <p><b>Исполнитель: </b> Юрлов Т.С. </p>
            </article>

            <ul class=""actions"">
                <li><a href=""index.html"" class=""button"">Подать заявку</a></li>
            </ul>
            </article>

        </div>

        <!-- Footer -->
        <section id=""footer");
                WriteLiteral(@""">
            <p class=""copyright"">&copy; Епифанова Е.Л.  Морозова А.Р.  Нурушева А.Р.  (АГТУ)</p>
        </section>

    </div>

    <!-- Scripts -->
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/js/browser.min.js""></script>
    <script src=""assets/js/breakpoints.min.js""></script>
    <script src=""assets/js/util.js""></script>
    <script src=""assets/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591