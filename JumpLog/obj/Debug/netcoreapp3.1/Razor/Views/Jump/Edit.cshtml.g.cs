#pragma checksum "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d5776c952b2b23840eb1a6984f5db80a7ea2bba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jump_Edit), @"mvc.1.0.view", @"/Views/Jump/Edit.cshtml")]
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
#line 1 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/_ViewImports.cshtml"
using JumpLog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/_ViewImports.cshtml"
using JumpLog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d5776c952b2b23840eb1a6984f5db80a7ea2bba", @"/Views/Jump/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539ad4111112420b1b7a20e986b3b68300bce587", @"/Views/_ViewImports.cshtml")]
    public class Views_Jump_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JumpLog.Models.Jump>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
  
    ViewData["Title"] = "Edit Jump";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 11 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"section\">\n    <h1>Edit Jump</h1>\n\n");
#nullable restore
#line 16 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
   Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Edit Jump\" />\n");
#nullable restore
#line 20 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\n");
#nullable restore
#line 22 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"section text-center\">\n        <h3>Need to be logged in to view this page.</h3>\n    </section>\n");
#nullable restore
#line 28 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JumpLog.Models.Jump> Html { get; private set; }
    }
}
#pragma warning restore 1591
