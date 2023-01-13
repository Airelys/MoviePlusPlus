#pragma checksum "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf2c4ee5c2cbdeadbfa79c39f2f0048b24c95ea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estadistics_ViewPDF), @"mvc.1.0.view", @"/Views/Estadistics/ViewPDF.cshtml")]
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
#line 2 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
using Movie_Plus.Services.Estadistic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf2c4ee5c2cbdeadbfa79c39f2f0048b24c95ea8", @"/Views/Estadistics/ViewPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c0bf5f0f935230d2e2f053df093359262d302e", @"/Views/_ViewImports.cshtml")]
    public class Views_Estadistics_ViewPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EstadisticViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
  
    ViewData["Title"] = "ViewPDF";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Estadistics</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2c4ee5c2cbdeadbfa79c39f2f0048b24c95ea83958", async() => {
                WriteLiteral("PDF");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

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
#line 41 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.KindOfMovie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ranking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalOfEntrance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Estadistics\ViewPDF.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EstadisticViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
