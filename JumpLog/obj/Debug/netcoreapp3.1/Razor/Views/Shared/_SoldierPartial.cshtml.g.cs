#pragma checksum "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0ae1d234604924a45602ef7eb0bc90fadc038d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SoldierPartial), @"mvc.1.0.view", @"/Views/Shared/_SoldierPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0ae1d234604924a45602ef7eb0bc90fadc038d0", @"/Views/Shared/_SoldierPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539ad4111112420b1b7a20e986b3b68300bce587", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SoldierPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JumpLog.Models.Soldier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<td scope=\"col\">");
#nullable restore
#line 3 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td scope=\"col\">");
#nullable restore
#line 4 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td scope=\"col\">");
#nullable restore
#line 5 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td scope=\"col\">");
#nullable restore
#line 6 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.DodId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td scope=\"col\">");
#nullable restore
#line 7 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.Ssn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td scope=\"col\">");
#nullable restore
#line 8 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td scope=\"col\">");
#nullable restore
#line 9 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.Platoon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td scope=\"col\">");
#nullable restore
#line 10 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Shared/_SoldierPartial.cshtml"
           Write(Model.DateArrived);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JumpLog.Models.Soldier> Html { get; private set; }
    }
}
#pragma warning restore 1591