#pragma checksum "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3827c251e8cf14fd5c3074c1edd7f4219ff68324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/_ViewImports.cshtml"
using dojodachi;

#line default
#line hidden
#line 2 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/_ViewImports.cshtml"
using dojodachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3827c251e8cf14fd5c3074c1edd7f4219ff68324", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c43adf8f00d921e1e3f242ef2bcc39f1c89303", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ShinyPikachu.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(57, 88, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <ul>\r\n        <li>Fullness: <span class=\"text-success\">");
            EndContext();
            BeginContext(146, 12, false);
#line 8 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
                                            Write(ViewBag.full);

#line default
#line hidden
            EndContext();
            BeginContext(158, 64, true);
            WriteLiteral("</span></li>\r\n        <li>Happiness: <span class=\"text-success\">");
            EndContext();
            BeginContext(223, 13, false);
#line 9 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
                                             Write(ViewBag.happy);

#line default
#line hidden
            EndContext();
            BeginContext(236, 60, true);
            WriteLiteral("</span></li>\r\n        <li>Meals: <span class=\"text-success\">");
            EndContext();
            BeginContext(297, 12, false);
#line 10 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
                                         Write(ViewBag.meal);

#line default
#line hidden
            EndContext();
            BeginContext(309, 61, true);
            WriteLiteral("</span></li>\r\n        <li>Energy: <span class=\"text-success\">");
            EndContext();
            BeginContext(371, 14, false);
#line 11 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
                                          Write(ViewBag.energy);

#line default
#line hidden
            EndContext();
            BeginContext(385, 205, true);
            WriteLiteral("</span></li>\r\n    </ul>\r\n</div>\r\n<div class=\"border border-dark\" style=\"width:350px; height:350px; margin-left:415px;\">\r\n    <div style=\"width:200px; height:200px; margin:auto; margin-top:80px;\">\r\n        ");
            EndContext();
            BeginContext(590, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3827c251e8cf14fd5c3074c1edd7f4219ff683245928", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(634, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 18 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
     if(ViewBag.energy >= 100 && ViewBag.full >= 100 && ViewBag.happy >= 100)
    {

#line default
#line hidden
            BeginContext(734, 64, true);
            WriteLiteral("        <p class=\"text-success text-center m-3\">You win!!!</p>\r\n");
            EndContext();
#line 21 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(805, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 22 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
     if(ViewBag.full <= 0 || ViewBag.happy <=0)
    {

#line default
#line hidden
            BeginContext(861, 64, true);
            WriteLiteral("        <p class=\"text-danger text-center m-3\">You Lose!!!</p>\r\n");
            EndContext();
#line 25 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
    }
    else{

#line default
#line hidden
            BeginContext(943, 48, true);
            WriteLiteral("        <p class=\"text-success text-center m-3\">");
            EndContext();
            BeginContext(992, 15, false);
#line 27 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
                                           Write(ViewBag.message);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 28 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1020, 50, true);
            WriteLiteral("</div>\r\n<div class=\"text-center mt-5\">\r\n    <ul>\r\n");
            EndContext();
#line 32 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
         if(ViewBag.energy >= 100 && ViewBag.full >= 100 && ViewBag.happy >= 100)
        {

#line default
#line hidden
            BeginContext(1164, 157, true);
            WriteLiteral("        <li>\r\n            <a href=\"/reset\">\r\n                <button class=\"btn btn-outline-success btn-sm\">reset</button>\r\n            </a>\r\n        </li>\r\n");
            EndContext();
#line 39 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1332, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 40 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
         if(ViewBag.full <= 0 || ViewBag.happy <=0)
        {

#line default
#line hidden
            BeginContext(1396, 157, true);
            WriteLiteral("        <li>\r\n            <a href=\"/reset\">\r\n                <button class=\"btn btn-outline-success btn-sm\">reset</button>\r\n            </a>\r\n        </li>\r\n");
            EndContext();
#line 47 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
        }
        else{

#line default
#line hidden
            BeginContext(1579, 634, true);
            WriteLiteral(@"                    <li>
            <a href=""/Feed"">
                <button class=""btn btn-outline-success btn-sm"">Feed</button>
            </a>
        </li>
        <li>
            <a href=""/Play"">
                <button class=""btn btn-outline-success btn-sm"">Play</button>
            </a>
        </li>
        <li>
            <a href=""/Work"">
                <button class=""btn btn-outline-success btn-sm"">Work</button>
            </a>
        </li>
        <li>
            <a href=""/Sleep"">
                <button class=""btn btn-outline-success btn-sm"">Sleep</button>
            </a>
        </li>
");
            EndContext();
#line 69 "/Users/angeloliwanag/Documents/CodingDojo/C#/MVC/dojodachi/Views/Home/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2224, 19, true);
            WriteLiteral("    </ul>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591
