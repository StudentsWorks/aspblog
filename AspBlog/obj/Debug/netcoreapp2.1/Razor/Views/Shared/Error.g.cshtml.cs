#pragma checksum "C:\Users\FERI\Synology Shared Folders\3.Bc KU\Webdesign 3\Programs\AspBlog\AspBlog\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ece6c70979ac6510ad568725e7a751351246f5"
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
#line 1 "C:\Users\FERI\Synology Shared Folders\3.Bc KU\Webdesign 3\Programs\AspBlog\AspBlog\Views\_ViewImports.cshtml"
using AspBlog;

#line default
#line hidden
#line 2 "C:\Users\FERI\Synology Shared Folders\3.Bc KU\Webdesign 3\Programs\AspBlog\AspBlog\Views\_ViewImports.cshtml"
using AspBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ece6c70979ac6510ad568725e7a751351246f5", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad6b7de5d09085c4994564189f52ee04bb2fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\FERI\Synology Shared Folders\3.Bc KU\Webdesign 3\Programs\AspBlog\AspBlog\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = ViewData["Code"];

#line default
#line hidden
            BeginContext(50, 105, true);
            WriteLiteral("\r\n<section class=\"box p-4\">\r\n\r\n    <div class=\"page-header box-heading\">\r\n        <h1 class=\"text-muted\">");
            EndContext();
            BeginContext(156, 16, false);
#line 8 "C:\Users\FERI\Synology Shared Folders\3.Bc KU\Webdesign 3\Programs\AspBlog\AspBlog\Views\Shared\Error.cshtml"
                          Write(ViewData["Code"]);

#line default
#line hidden
            EndContext();
            BeginContext(172, 33, true);
            WriteLiteral("&nbsp;<span class=\"text-primary\">");
            EndContext();
            BeginContext(206, 19, false);
#line 8 "C:\Users\FERI\Synology Shared Folders\3.Bc KU\Webdesign 3\Programs\AspBlog\AspBlog\Views\Shared\Error.cshtml"
                                                                            Write(ViewData["Heading"]);

#line default
#line hidden
            EndContext();
            BeginContext(225, 43, true);
            WriteLiteral("</span></h1>\r\n    </div>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(269, 19, false);
#line 11 "C:\Users\FERI\Synology Shared Folders\3.Bc KU\Webdesign 3\Programs\AspBlog\AspBlog\Views\Shared\Error.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(288, 62, true);
            WriteLiteral("\r\n    </p>\r\n    <a href=\"/\">späť domov</a>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
