#pragma checksum "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\Check\Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5851d7b0e7cf820da37c05896216494f52e59cda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Check_Check), @"mvc.1.0.view", @"/Views/Check/Check.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Check/Check.cshtml", typeof(AspNetCore.Views_Check_Check))]
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
#line 1 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5851d7b0e7cf820da37c05896216494f52e59cda", @"/Views/Check/Check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Check_Check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CheckModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\Check\Check.cshtml"
      
    ViewData["Title"] = "Check";
    

#line default
#line hidden
            BeginContext(74, 344, true);
            WriteLiteral(@"
    <h2 style=""font-size:14px;"">All Cheks</h2>
    <table style=""border:3px solid black;border-collapse:collapse;border-bottom:3px solid black;"">
        <tr>
            <td style=""padding:5px"">Date</td>
            <td style=""padding:5px"">Price</td>
            <td style=""padding:5px"">Sale</td>
            
        </tr>
       
");
            EndContext();
#line 15 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\Check\Check.cshtml"
         foreach (var cl in Model)
    {

#line default
#line hidden
            BeginContext(461, 50, true);
            WriteLiteral("        <tr>\r\n            <td style=\"padding:5px\">");
            EndContext();
            BeginContext(512, 27, false);
#line 18 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\Check\Check.cshtml"
                               Write(cl.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(539, 43, true);
            WriteLiteral("</td>\r\n            <td style=\"padding:5px\">");
            EndContext();
            BeginContext(583, 8, false);
#line 19 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\Check\Check.cshtml"
                               Write(cl.Price);

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("</td>\r\n            <td style=\"padding:5px\">");
            EndContext();
            BeginContext(635, 7, false);
#line 20 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\Check\Check.cshtml"
                               Write(cl.Sale);

#line default
#line hidden
            EndContext();
            BeginContext(642, 35, true);
            WriteLiteral("</td>\r\n           \r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\Михаела\Desktop\c++\WebApplication1\WebApplication1\Views\Check\Check.cshtml"
    }

#line default
#line hidden
            BeginContext(684, 35, true);
            WriteLiteral("        <tr></tr>\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CheckModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591