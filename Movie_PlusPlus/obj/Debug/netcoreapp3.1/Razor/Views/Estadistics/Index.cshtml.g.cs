#pragma checksum "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc8b1ec53adb2877e2105a2dc901d016ea813e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estadistics_Index), @"mvc.1.0.view", @"/Views/Estadistics/Index.cshtml")]
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
#line 1 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\_ViewImports.cshtml"
using Movie_PlusPlus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\_ViewImports.cshtml"
using Movie_PlusPlus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
using Movie_Plus.Services.Pager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
using Movie_Plus.Services.Estadistic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc8b1ec53adb2877e2105a2dc901d016ea813e2", @"/Views/Estadistics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c0bf5f0f935230d2e2f053df093359262d302e", @"/Views/_ViewImports.cshtml")]
    public class Views_Estadistics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericPager<EstadisticViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewPDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Estadistics</h1>\r\n\r\n");
            WriteLiteral("<div class=\"text-right form-inline\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dc8b1ec53adb2877e2105a2dc901d016ea813e24801", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
       Write(Html.TextBox("_title", null, new
            {
                placeholder = "Title",
                @class = "form-control"
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 22 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
       Write(Html.TextBox("_country", null, new
            {
                placeholder = "Country",
                @class = "form-control "
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 28 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
       Write(Html.TextBox("_kindOfMovie", null, new
            {
                placeholder = "KindOfMovie",
                @class = "form-control "
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 34 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
       Write(Html.TextBox("_duration", null, new
            {
            placeholder = "Duration",
            @class = "form-control numbers",
            @oninput = "this.value=this.value.replace(/[^0-9]/g,'')"
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 41 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
       Write(Html.TextBox("_ranking", null, new
            {
            placeholder = "Ranking",
            @class = "form-control numbers",
            @oninput = "this.value=this.value.replace(/[^0-9]/g,'')"
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 48 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
       Write(Html.TextBox("_actor", null, new
            {
                placeholder = "Actor",
                @class = "form-control "
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            Min Date: <div class=""form-group"">
                <label class=""control-label""></label>
                <input name=""_minDate"" type=""date"" class=""form-control"" />
                <span class=""text-danger""></span>
            </div>

            Max Date: <div class=""form-group"">
                <label class=""control-label""></label>
                <input name=""_maxDate"" type=""date"" class=""form-control"" />
                <span class=""text-danger""></span>
            </div>

        </div>
        <button class=""btn btn-default"" type=""submit"">Search</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
AddHtmlAttributeValue("", 293, Url.Action("Index", "Estadistics" ), 293, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dc8b1ec53adb2877e2105a2dc901d016ea813e29870", async() => {
                WriteLiteral("View PDF");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<table class=""table"">
    <thead>
        <tr>
            <th>
                Title
            </th>
            <th>
                Kind of movie
            </th>
            <th>
                Duration
            </th>
            <th>
                Country
            </th>
            <th>
                Actors
            </th>
            <th>
                Ranking
            </th>
            <th>
                Number Of Entrance
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 101 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
         foreach (var item in Model.Result)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.KindOfMovie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 117 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ranking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 123 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalOfEntrance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 126 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 132 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
 if (Model.Result.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>\r\n        <strong>");
#nullable restore
#line 135 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
           Write(Model.TotalRegisters);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> Registers found\r\n    </span>\r\n    <span>&nbsp;|&nbsp;</span>\r\n    <span>\r\n        Page <strong>");
#nullable restore
#line 139 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
                 Write(Model.ActualPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> of\r\n        <strong>");
#nullable restore
#line 140 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
           Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </span>\r\n    <span>&nbsp;|&nbsp;</span>\r\n");
#nullable restore
#line 143 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>No results</span>\r\n    <span>&nbsp;|&nbsp;</span>\r\n");
#nullable restore
#line 148 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 150 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
 if (Model.ActualPage > 1)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink("<<", "Index", new { page = 1 },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 155 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink("Previous", "Index", new { page = Model.ActualPage - 1 },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
                                                              
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink("<<", "Index", new { page = 1 },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 163 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink("Previous", "Index", new { page = 1 },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
                                                                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<span></span>\r\n");
#nullable restore
#line 167 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
 if (Model.ActualPage < Model.TotalPages)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink("Next", "Index", new { page = Model.ActualPage + 1 },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 172 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink(">>", "Index", new { page = Model.TotalPages },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
                                                              
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink("Next", "Index", new { page = Model.TotalPages - 1 },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 180 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
Write(Html.ActionLink(">>", "Index", new { page = Model.TotalPages },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\Index.cshtml"
                                                                       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericPager<EstadisticViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
