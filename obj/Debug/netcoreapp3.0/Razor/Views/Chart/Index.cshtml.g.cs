#pragma checksum "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Chart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6522f2cc5a134c20c6a68709ff1d1265c2b60c06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_Index), @"mvc.1.0.view", @"/Views/Chart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6522f2cc5a134c20c6a68709ff1d1265c2b60c06", @"/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26df018e614b2c6432df891cc76479e8d3b231eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"	<div id=""chartContainer"" style=""height: 370px; width: 100%;""></div>
 	<div id=""chartContainer2""style=""height: 370px; width: 100%;""></div>
 
	<script type=""text/javascript"">
 
		window.onload = function () {
			var chart = new CanvasJS.Chart(""chartContainer"", {
				theme: ""light2"",
				animationEnabled: true,
				title: {
					text: ");
#nullable restore
#line 11 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Chart\Index.cshtml"
                     Write(Html.Raw(ViewBag.ElaborName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t},\r\n\t\t\t\tsubtitles: [\r\n\t\t\t\t\t{ text: \"Parole precedentemente registrate\" }\r\n\t\t\t\t],\r\n\t\t\t\tdata: [\r\n\t\t\t\t{\r\n\t\t\t\t\ttype: \"bar\", //change type to bar, line, area, pie, etc\r\n\t\t\t\t\t\r\n                                      \r\n\t\t\t\t\tdataPoints: ");
#nullable restore
#line 21 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Chart\Index.cshtml"
                           Write(Html.Raw(ViewBag.DataPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					

					}
				]
			},
			);
			var chart2 = new CanvasJS.Chart(""chartContainer2"", {
				theme: ""light2"",
				animationEnabled: true,
				title: {
					text: ""Parole Trovate e non Trovate""
				},
				subtitles: [
					{ text: ""Parole precedentemente registrate"" }
				],
				data: [
				{
					type: ""pie"", //change type to bar, line, area, pie, etc
					
                                      
					dataPoints: ");
#nullable restore
#line 42 "C:\Users\Neperia\Documenti\NeperiaDizionarioV2\Views\Chart\Index.cshtml"
                           Write(Html.Raw(ViewBag.DataPoints2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\r\n\r\n\t\t\t\t\t}\r\n\t\t\t\t]\r\n\t\t\t});\r\n\t\t\t\r\n\t\t\t\r\n\t\t\r\n\r\n\t\t\tchart.render();\r\n\t\t\tchart2.render();\r\n\t\t};\r\n\t</script>");
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
