#pragma checksum "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3c129f2f5a2e43f44d22fef573583fc1618099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\_ViewImports.cshtml"
using SalesMvcEntityFramework;

#line default
#line hidden
#line 2 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\_ViewImports.cshtml"
using SalesMvcEntityFramework.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3c129f2f5a2e43f44d22fef573583fc1618099", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705550d2dd387c225f003dc83266c6573eb43e6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalesMvcEntityFramework.Models.ViewModels.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(106, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
            EndContext();
            BeginContext(133, 17, false);
#line 6 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\Shared\Error.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(150, 31, true);
            WriteLiteral("</h1>\r\n<h2 class=\"text-danger\">");
            EndContext();
            BeginContext(182, 13, false);
#line 7 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\Shared\Error.cshtml"
                   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(195, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 9 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(234, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(287, 15, false);
#line 12 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(302, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "D:\Projetos Geral\Curso C# .Net\Projeto AspNet\SalesMvcEntityFramework\SalesMvcEntityFramework\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(324, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalesMvcEntityFramework.Models.ViewModels.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
