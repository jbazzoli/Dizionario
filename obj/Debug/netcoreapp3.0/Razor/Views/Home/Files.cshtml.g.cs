#pragma checksum "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c4e2222ad6da075c2bc1d213ee4777412854e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Files), @"mvc.1.0.view", @"/Views/Home/Files.cshtml")]
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
#line 1 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\_ViewImports.cshtml"
using NeperiaDizionarioV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\_ViewImports.cshtml"
using NeperiaDizionarioV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c4e2222ad6da075c2bc1d213ee4777412854e9", @"/Views/Home/Files.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26df018e614b2c6432df891cc76479e8d3b231eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Files : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NeperiaDizionarioV2.Models.Elabor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/MY-CONTROLLER_MY-PAGE.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
  
    ViewData["Title"] = "Lista di Archivi";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Lista di Archivi!!</h1>
   

<table id=""fileDataTable"" class=""table table-striped"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Id</th>
      <th scope=""col"">Data</th>
      <th scope=""col"">Quantità </th>
      <th scope=""col"">Peso </th>
     <th scope=""col"">Nome del Archivo </th>
    </tr>
  </thead>
  <tbody>
           
");
#nullable restore
#line 26 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
       foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th scope=\"row\"></th>\r\n      <td> ");
#nullable restore
#line 29 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
      Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td> ");
#nullable restore
#line 30 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
      Write(Html.DisplayFor(modelItem => item.DataStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td> ");
#nullable restore
#line 31 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
      Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
     Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td> ");
#nullable restore
#line 33 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
      Write(Html.DisplayFor(modelItem => item.NameFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n     \r\n    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n    \r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<!-- For the DataTables grid -->
	<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"">
	<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js""></script>

	<!-- Page-specific script -->
	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90c4e2222ad6da075c2bc1d213ee4777412854e96473", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Home\Files.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NeperiaDizionarioV2.Models.Elabor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
